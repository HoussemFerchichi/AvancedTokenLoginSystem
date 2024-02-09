using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tunisian_Future_Role_Play_Launcher;

namespace DOwnloadFileProgress
{
    public partial class downloader : Form
    {
        private readonly string Version = "1.0";
        public downloader()
        {
            InitializeComponent();
        }
        public void someValFromTrackBar(TrackBar valFromTrackBar)
        {

            label1.Text = valFromTrackBar.Value.ToString();

        }

    public string getVersion()
        {
            return Version;
        }
        //Method to Update 
        private void checkForUpdate()
        {
            string URL = "https://houssemferchichi.000webhostapp.com/";
            string AppName = "https://houssemferchichi.000webhostapp.com/Route_66_Role_Play_Launcher.exe";
            string ServerVersion;
            string serverVersionName = "Update.txt";
            // i will make take a old app to check if its work :) 

            WebRequest req = WebRequest.Create(URL + serverVersionName);
            WebResponse res = req.GetResponse();
            Stream str = res.GetResponseStream();
            StreamReader tr = new StreamReader(str);
            ServerVersion = tr.ReadLine();


            if (getVersion() != ServerVersion)
            {
                {
                    WebClient client = new WebClient();
                    byte[] appdata = client.DownloadData(AppName);

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = File.Create(saveFileDialog1.FileName))
                        {
                            fs.Write(appdata, 0, appdata.Length);
                        }
                    }
                    Application.Exit();
                }
            }
            else
            {
                Updated up = new Updated();
                up.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            checkForUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkForUpdate();
        }

        private void downloader_Load(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
    //ktSp&EgbWQ6NTg^nEP#Q

}