using System;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Immedictionary
{
    public partial class MainForm : Form
    {
        private readonly ClipboardViewer _viewer;
        private const string AppTitle = "Immedictionary";

        public MainForm()
        {
            InitializeComponent();
            _viewer = new ClipboardViewer(this);
            _viewer.ClipboardChanged += _viewer_ClipboardChanged;
        }

        void _viewer_ClipboardChanged(object sender, ClipboardEventArgs ev)
        {
            if (!this.toggleWatchClipboardButton.Checked) return;
            this.searchTextBox.Text = ev.Text;
            this.executeSearchButton.PerformClick();
        }

        private void browserOwnerTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.executeSearchButton.PerformClick();
        }

        private void executeSearchButton_Click(object sender, EventArgs e)
        {
            this.Text = searchTextBox.Text + " - " + AppTitle;
            var encoded = HttpUtility.UrlEncode(searchTextBox.Text);
            switch (browserOwnerTab.SelectedIndex)
            {
                case 0:
                    browserWeblio.Navigate("http://ejje.weblio.jp/content/" + encoded);
                    break;
                case 1:
                    browserNaver.Navigate("http://endic.naver.jp/srch/ej/N/" + encoded);
                    break;
                case 2:
                    browserSpaceAlc.Navigate("http://eow.alc.co.jp/search?q=" + encoded);
                    break;
            }
        }
    }
}
