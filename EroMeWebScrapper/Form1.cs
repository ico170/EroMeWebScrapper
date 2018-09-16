using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EroMeWebScrapper
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetTextForDownloadStatusLabel(string myText)
        {
            this.TxtDownloadStatus.Text = myText;
        }


        //edit here to populate the list from the add button and just start download here.

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            /*lbDownloadStatus.Text = "Downloading started";
            EroMeScrapper eroScrapper = new EroMeScrapper();
            string website = eroScrapper.InitScrapper(txtURL.Text);
            List<string> links = eroScrapper.GetLinks(website);
            eroScrapper.ExtractLinks(links);
            
            if (eroScrapper.DownloadLinks(links, tbFilePath.Text))
            {
                MessageBox.Show("Downloaded");
                lbDownloadStatus.Text = " ";
            }
            */
            lbDownloadStatus.Text = " ";
            EroMeScrapper eroScrapper = new EroMeScrapper();
            for (int i = 0; i < LinkList.Items.Count; i++)
            {
                if (LinkList.GetItemChecked(i))
                {
                    eroScrapper.DownloadLinks(LinkList.Items[i].ToString(), tbFilePath.Text);
                }
            }
            lbDownloadStatus.Text = "Download Completed";
        }
        private void LinkAddBtn_Click(object sender, EventArgs e)
        {
            lbDownloadStatus.Text = "Links added";
            EroMeScrapper eroScrapper = new EroMeScrapper();
            string website = eroScrapper.InitScrapper(txtURL.Text);
            List<string> links = eroScrapper.GetLinks(website);
            eroScrapper.ExtractLinks(links);

            foreach (string link in links)
            {
                LinkList.Items.Add(link);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFilePath.Text = fbd.SelectedPath;
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LinkList.Items.Count; i++)
            {
                LinkList.SetItemChecked(i, true);
            }

        }

        private void BtnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LinkList.Items.Count; i++)
            {
                LinkList.SetItemChecked(i, false);
            }
        }
    }
}

/*
 * TODO
 * Progress bar
 * tumbnal images before download
 * remember last download location
 *df
 *
 * */



