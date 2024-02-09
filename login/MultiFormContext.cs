using System.Windows.Forms;
using DOwnloadFileProgress;

namespace login
{
    internal class MultiFormContext : Form
    {
        private Form1 form1;
        private downloader downloader;

        public MultiFormContext(Form1 form1, downloader downloader)
        {
            this.form1 = form1;
            this.downloader = downloader;
        }
    }
}