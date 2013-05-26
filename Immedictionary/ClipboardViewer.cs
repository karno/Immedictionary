using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Immedictionary
{
    // code by http://www.atmarkit.co.jp/fdotnet/dotnettips/848cbviewer/cbviewer.html 
    public class ClipboardEventArgs : EventArgs
    {
        private readonly string _text;

        public string Text
        {
            get { return this._text; }
        }

        public ClipboardEventArgs(string str)
        {
            this._text = str;
        }
    }

    public delegate void ClipboardChangedEventHandler(
                            object sender, ClipboardEventArgs ev);

    [System.Security.Permissions.PermissionSet(
          System.Security.Permissions.SecurityAction.Demand,
          Name = "FullTrust")]
    internal class ClipboardViewer : NativeWindow
    {
        [DllImport("user32")]
        public static extern IntPtr SetClipboardViewer(
                IntPtr hWndNewViewer);

        [DllImport("user32")]
        public static extern bool ChangeClipboardChain(
                IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32")]
        public extern static int SendMessage(
                IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        // ReSharper disable InconsistentNaming
        private const int WM_DRAWCLIPBOARD = 0x0308;
        private const int WM_CHANGECBCHAIN = 0x030D;
        // ReSharper restore InconsistentNaming
        private IntPtr _nextHandle;

        public event ClipboardChangedEventHandler ClipboardChanged;

        public ClipboardViewer(Form f)
        {
            f.HandleCreated += this.OnHandleCreated;
            f.HandleDestroyed += this.OnHandleDestroyed;
        }

        internal void OnHandleCreated(object sender, EventArgs e)
        {
            AssignHandle(((Form)sender).Handle);
            // ビューアを登録
            this._nextHandle = SetClipboardViewer(this.Handle);
        }

        internal void OnHandleDestroyed(object sender, EventArgs e)
        {
            // ビューアを解除
            ChangeClipboardChain(this.Handle, this._nextHandle);
            ReleaseHandle();
        }

        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {

                case WM_DRAWCLIPBOARD:
                    if (Clipboard.ContainsText())
                    {
                        // クリップボードの内容がテキストの場合のみ
                        if (this.ClipboardChanged != null)
                        {
                            // クリップボードの内容を取得してハンドラを呼び出す
                            this.ClipboardChanged(this,
                                new ClipboardEventArgs(Clipboard.GetText()));
                        }
                    }
                    if ((int)this._nextHandle != 0)
                        SendMessage(
                            this._nextHandle, msg.Msg, msg.WParam, msg.LParam);
                    break;

                // クリップボード・ビューア・チェーンが更新された
                case WM_CHANGECBCHAIN:
                    if (msg.WParam == this._nextHandle)
                    {
                        this._nextHandle = msg.LParam;
                    }
                    else if ((int)this._nextHandle != 0)
                        SendMessage(
                            this._nextHandle, msg.Msg, msg.WParam, msg.LParam);
                    break;
            }
            base.WndProc(ref msg);
        }
    }
}
