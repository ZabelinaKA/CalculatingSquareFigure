using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GzApi;
using System.Net;
using System.Net.Http;
using GzApi;


namespace GzLibApp
{
    public partial class documents : Form
    {

        bool is44;

        public documents()
        {
            InitializeComponent();
        }
      
        public void setIs44()
        {
            is44 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = Name;

            if (is44)
            {
                var GozCl = new GozClient();

                name = name.Replace("common-info", "documents");

                GzApi.documents44 doc44 = await GozCl.Getdatabyurl(name);

                int n = doc44.data.dto.structuredDocumentation[0].attachments.Count;

                using (var webClient = new WebClient())
                {

                    for (var i = 0; i < n; i++)
                    {
                        string site = doc44.data.dto.structuredDocumentation[0].attachments[i].linkDownload;
                        var save_path = "D:\\";
                        string Fname = doc44.data.dto.structuredDocumentation[0].attachments[i].fileName.ToString();

                        try
                        {
                            webClient.Headers.Add("User-Agent", "PostmanRuntime/7.26.1");
                            webClient.DownloadFile(site, save_path + Fname);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("При загрузке произошла ошибка!");
                        }
                    }
                    MessageBox.Show("загрузка завершена!");
                }
                this.Close();
            }
            else
            {
                name = name.Replace("common-info", "documents");

                var Gozcl = new Gozclient();

                GzApi.documents223 doc223 = await Gozcl.GetDatabyurl(name);

                int n = doc223.data.noticeInfoAttDtoList.attachment.Count;

                using (var webClient = new WebClient())
                {

                    for (var i = 0; i < n; i++)
                    {
                        string Site = doc223.data.noticeInfoAttDtoList.attachment[i].id.ToString();
                        string site = "https://zakupki.gov.ru/223/purchase/public/download/download.html?id=" + Site;
                        var save_path = "D:\\";
                        string Fname = doc223.data.noticeInfoAttDtoList.attachment[i].fileName;

                        try
                        {
                            webClient.Headers.Add("User-Agent", "PostmanRuntime/7.26.1");
                            webClient.DownloadFile(site, save_path + Fname);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("При загрузке произошла ошибка!");
                        }
                    }
                    MessageBox.Show("загрузка завершена!");
                }
                this.Close();
            }
        }
    }
}
