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
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Net;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace GzLibApp
{
    public partial class fz44 : Form
    {
        public fz44()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var glavsite = "https://zakupki.gov.ru/";
            var modul = "api/mobile/proxy/917/";
            string Name = textBox9.Text;
            var name = @"epz?\/?\w+\b\S+";

            var rgx = new Regex(name);

            if (!Name.StartsWith("https://zakupki.gov.ru/epz"))
                textBox9.Text = "enter wrong address";
            else
            {
                foreach (Match match in rgx.Matches(Name))
                {
                    textBox9.Text = glavsite + modul + match.Value;
                }

                var gzClient = new GzClient();

                GzApi.fz44 Fz44 = await gzClient.GetDataByUrl(textBox9.Text);

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.numberStandardContract != null)
                {
                    if (Fz44.data.dto.generalInformationOnPurchaseBlock.numberStandardContract.title == null)
                        textBox7.Text = "no information";
                    else textBox7.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.numberStandardContract.title.ToString();
                }
                else textBox7.Text = "no information";

                if (Fz44.data.dto.headerBlock.placingWayName == null)
                    textBox1.Text = "no information";
                else textBox1.Text = Fz44.data.dto.headerBlock.placingWayName;

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.nameOfElectronicPlatform == null)
                    textBox2.Text = "no information";
                else textBox2.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.nameOfElectronicPlatform;

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.webAddressOfElectronicPlatform.title == null)
                    textBox3.Text = "no information";
                else textBox3.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.webAddressOfElectronicPlatform.title;

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.placementGeneralInformationOfPurchase
                        .powerOfOrganization == null)
                    textBox4.Text = "no information";
                else textBox4.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.placementGeneralInformationOfPurchase
                   .powerOfOrganization;

                if (Fz44.data.dto.headerBlock.purchaseObjectName == null)
                    textBox5.Text = "no information";
                else textBox5.Text = Fz44.data.dto.headerBlock.purchaseObjectName.ToString();

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.stageOfPurchase == null)
                    textBox8.Text = "no information";
                else textBox8.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.stageOfPurchase.ToString();

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.relationshipWithRPG[0].title == null)
                    textBox6.Text = "no information";
                else textBox6.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.relationshipWithRPG[0].title.ToString();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var firstpart = "https://zakupki.gov.ru/";
            var modul = "api/mobile/proxy/917/";
            var secondpart = "epz/order/notice/ea44/view/common-info.html?regNumber=";
            string Num = textBox10.Text;
            var thirdpart = "&backUrl=4daf74c0-ca31-4bc1-882b-75559c681c35";
            
            var regex = new Regex("[0-9]{19}");

            foreach (Match match in regex.Matches(Num))
            {
                textBox10.Text = firstpart + modul + secondpart + match.Value + thirdpart;

                var gzClient = new GzClient();

                GzApi.fz44 Fz44 = await gzClient.GetDataByUrl(textBox10.Text);

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.numberStandardContract != null)
                {
                    if (Fz44.data.dto.generalInformationOnPurchaseBlock.numberStandardContract.title == null)
                        textBox7.Text = "no information";
                    else textBox7.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.numberStandardContract.title.ToString();
                }
                else textBox7.Text = "no information";

                if (Fz44.data.dto.headerBlock.placingWayName == null)
                    textBox1.Text = "no information";
                else textBox1.Text = Fz44.data.dto.headerBlock.placingWayName;

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.nameOfElectronicPlatform == null)
                    textBox2.Text = "no information";
                else textBox2.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.nameOfElectronicPlatform;

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.webAddressOfElectronicPlatform.title == null)
                    textBox3.Text = "no information";
                else textBox3.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.webAddressOfElectronicPlatform.title;

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.placementGeneralInformationOfPurchase
                        .powerOfOrganization == null)
                    textBox4.Text = "no information";
                else textBox4.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.placementGeneralInformationOfPurchase
                   .powerOfOrganization;

                if (Fz44.data.dto.headerBlock.purchaseObjectName == null)
                    textBox5.Text = "no information";
                else textBox5.Text = Fz44.data.dto.headerBlock.purchaseObjectName.ToString();

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.stageOfPurchase == null)
                    textBox8.Text = "no information";
                else textBox8.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.stageOfPurchase.ToString();

                if (Fz44.data.dto.generalInformationOnPurchaseBlock.relationshipWithRPG[0].title == null)
                    textBox6.Text = "no information";
                else textBox6.Text = Fz44.data.dto.generalInformationOnPurchaseBlock.relationshipWithRPG[0].title.ToString();
                textBox9.Text = textBox10.Text;
            }
            textBox10.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

       private async void button3_Click(object sender, EventArgs e)
        {
            using (var doc = new documents())
            {

                doc.setIs44();

                doc.Name = textBox9.Text;
                string name = textBox9.Text;

                var GozCl = new GozClient();

                name = name.Replace("common-info", "documents");

                GzApi.documents44 doc44 = await GozCl.Getdatabyurl(name);

                int n = doc44.data.dto.structuredDocumentation[0].attachments.Count;

                for (var i = 0; i < n; i++)
                {
                    doc.textBox1.AppendText(i + 1 + ".   " + doc44.data.dto.structuredDocumentation[0].attachments[i].fileName + "\n");
                }
                doc.Show();
            }
            this.Close();
        }
    }
}
       

    


