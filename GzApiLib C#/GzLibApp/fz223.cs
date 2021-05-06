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
    public partial class fz223 : Form
    {
        public fz223()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var Glavsite = "https://zakupki.gov.ru/";
            var Modul = "api/mobile/proxy/917/";
            string Name = textBox1.Text;
            var name = @"223?\/?\w+\b\S+";

            var Rgx = new Regex(name);
           
            if (!Name.StartsWith("https://zakupki.gov.ru/223"))
            {
                textBox1.Text = "enter wrong address";
            }
            else
            {
                foreach (Match mt in Rgx.Matches(Name))
                {
                    textBox1.Text = Glavsite + Modul + mt.Value;
                }

                var gz = new gzclient();

                GzApi.fz223 Fz223 = await gz.getdatabyurl(textBox1.Text);

                if (Fz223.data.noticeInfo.lots[0].reestrNumber == null)
                    textBox2.Text = "no information";
                else textBox2.Text = Fz223.data.noticeInfo.lots[0].reestrNumber;

                if (Fz223.data.purchaseMethod.name == null)
                    textBox3.Text = "no information";
                else textBox3.Text = Fz223.data.purchaseMethod.name;

                if (Fz223.data.noticeInfo.purchaseName == null)
                    textBox4.Text = "no information";
                else textBox4.Text = Fz223.data.noticeInfo.purchaseName;

                if (Fz223.data.noticeInfo.lots[0].commoditiesWorkServiceses[0].orderNumber == null)
                    textBox5.Text = "no information";
                else textBox5.Text = Fz223.data.noticeInfo.lots[0].commoditiesWorkServiceses[0].orderNumber.ToString();

                if (Fz223.data.noticeInfo.customerName == null)
                    textBox6.Text = "no information";
                else textBox6.Text = Fz223.data.noticeInfo.customerName;

                if (Fz223.data.noticeInfo.urlVsrz == null)
                    textBox7.Text = "no information";
                else textBox7.Text = Fz223.data.noticeInfo.urlVsrz;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var firstpart = "https://zakupki.gov.ru/";
            var modul = "api/mobile/proxy/917/";
            var secondpart = "223/purchase/public/purchase/info/common-info.html?regNumber=";
            string Num = textBox8.Text;
            var thirdpart = "&backUrl=8302e5ba-26ee-4d21-b182-e8e4c9540928";

            var regex = new Regex("[0-9]{11}");

            foreach (Match match in regex.Matches(Num))
            {
                textBox8.Text = firstpart + modul + secondpart + match.Value + thirdpart;

                var gz = new gzclient();

                GzApi.fz223 Fz223 = await gz.getdatabyurl(textBox8.Text);

                if (Fz223.data.noticeInfo.lots[0].reestrNumber == null)
                    textBox2.Text = "no information";
                else textBox2.Text = Fz223.data.noticeInfo.lots[0].reestrNumber;

                if (Fz223.data.purchaseMethod.name == null)
                    textBox3.Text = "no information";
                else textBox3.Text = Fz223.data.purchaseMethod.name;

                if (Fz223.data.noticeInfo.purchaseName == null)
                    textBox4.Text = "no information";
                else textBox4.Text = Fz223.data.noticeInfo.purchaseName;

                if (Fz223.data.noticeInfo.lots[0].commoditiesWorkServiceses[0].orderNumber == null)
                    textBox5.Text = "no information";
                else textBox5.Text = Fz223.data.noticeInfo.lots[0].commoditiesWorkServiceses[0].orderNumber.ToString();

                if (Fz223.data.noticeInfo.customerName == null)
                    textBox6.Text = "no information";
                else textBox6.Text = Fz223.data.noticeInfo.customerName;

                if (Fz223.data.noticeInfo.urlVsrz == null)
                    textBox7.Text = "no information";
                else textBox7.Text = Fz223.data.noticeInfo.urlVsrz;

                textBox1.Text = textBox8.Text;
            }
            textBox8.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (var doc = new documents())
            {

                doc.Name = textBox1.Text;
                string name = textBox1.Text;

                var Gozcl = new Gozclient();

                name = name.Replace("common-info", "documents");

                GzApi.documents223 doc223 = await Gozcl.GetDatabyurl(name);

                int n = doc223.data.noticeInfoAttDtoList.attachment.Count;

                for (int i = 0; i < n; i++)
                {
                    doc.textBox1.AppendText(i + 1 + ".   " + doc223.data.noticeInfoAttDtoList.attachment[i].fileName + "\n");
                }
                doc.Show();
            }
            this.Close();
        }
    }
}
