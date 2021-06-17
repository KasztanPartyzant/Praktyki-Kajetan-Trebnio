using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace Praktyki_Kajetan_Trebnio
{
    public partial class Form1 : Form
    {

        private String api = "https://ktrebnio.httpd.pl";
        private String klucz = null;

        public Form1()
        {
            InitializeComponent();
            this.initializeFunction();
        }

        private void initializeFunction()
        {
            contents.Appearance = TabAppearance.FlatButtons;
            contents.ItemSize = new Size(0, 1);
            contents.SizeMode = TabSizeMode.Fixed;


            // Licencja
            licenceStatus.Text = "";
            this.klucz = Properties.Settings.Default.klucz;
            this.licenceKey.Text = this.klucz;
            this.checkLicence();

            Console.WriteLine("Klucz: " + this.klucz);

            // TAbela produktowa
            tableProdukty.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableProdukty.Controls.Add(new Label() { Text = "#" }, 0, 0);
            tableProdukty.Controls.Add(new Label() { Text = "ID" }, 1, 0);
            tableProdukty.Controls.Add(new Label() { Text = "Nazwa produktu" }, 2, 0);
            tableProdukty.Controls.Add(new Label() { Text = "Cena" }, 3, 0);
            tableProdukty.Controls.Add(new Label() { Text = "Cena promocyjna" }, 4, 0);
            tableProdukty.Controls.Add(new Label() { Text = "Ilość" }, 5, 0);
            tableProdukty.Controls.Add(new Label() { Text = "Akcja" }, 5, 0);

            // Zaczytywanie produktów

            String products = this.requestToServer("/get", null, "GET");
            Console.WriteLine(products);

            dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(products);

            foreach (dynamic i in obj)
            {
                int id = int.Parse(i["id"].ToString());
                int cena = int.Parse(i["cena"].ToString());
                int cena_promocyjna = int.Parse(i["cena_promocyjna"].ToString());
                int ilosc = int.Parse(i["ilosc"].ToString());
                string name = i["produkt"].ToString();

                this.DodajProdukt(id, name, cena, cena_promocyjna, ilosc);

            }

        }

        private string requestToServer(String endpoint, String data = null, String method = "POST")
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(this.api + endpoint);
            //httpWebRequest.ContentType = "application/json";

            if (data != null)
            {
                var dataToSend = Encoding.ASCII.GetBytes(data);

                httpWebRequest.Method = method;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.ContentLength = data.Length;

                using (var stream = httpWebRequest.GetRequestStream())
                {
                    stream.Write(dataToSend, 0, dataToSend.Length);
                }

            }

            String tmp = "";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                    
                if (result.ToString() != "")
                {
                    tmp = result.ToString();
                }
            }

            return tmp;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void produktyGroup_Enter(object sender, EventArgs e)
        {

        }

        private void produktyButton_Click(object sender, EventArgs e)
        {
            contents.SelectTab(produktyTab);
        }

        private void sprzedazButton_Click(object sender, EventArgs e)
        {
            contents.SelectTab(sprzedazTab);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contents.SelectTab(produktTab);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contents.SelectTab(sprzedajTab);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sprzedajTab_Click(object sender, EventArgs e)
        {

        }

        private void sprzedazTab_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            contents.SelectTab(licenceTab);
        }

        private void checkLicence()
        {
            if (licenceKey.Text != "")
            {
                String tmplicenceKey = licenceKey.Text;
                String test = this.requestToServer("/licenceCheck/" + tmplicenceKey, null, "GET");

                test = test.Trim();

                Console.WriteLine(test);

                if (test == "OK")
                {
                    Properties.Settings.Default.klucz = tmplicenceKey;
                    Properties.Settings.Default.Save();
                    licence_error.Text = "";
                    licenceStatus.Text = "Licencja aktywna";
                    licenceStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#008000");
                }
                else
                {
                    contents.SelectTab(licenceTab);
                    licence_error.Text = "Wprowadzony klucz jest niepoprawny";
                    licence_error.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");

                    licenceStatus.Text = "Licencja nieporpawna";
                    licenceStatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");

                    licenceKey.Text = "";
                    //this.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.checkLicence();
        }

        private void licenceStatus_Click(object sender, EventArgs e)
        {

        }


        private void DodajProdukt(int id, string name, int price, int promotion_price, int quantity)
        {
            RowStyle temp = this.tableProdukty.RowStyles[0];

            int liczbaPorzadkowa = this.tableProdukty.RowCount;

            price = price / 100;
            promotion_price = promotion_price / 100;

            this.tableProdukty.RowCount++;
            this.tableProdukty.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));

            this.tableProdukty.Controls.Add(new Label() { Text = liczbaPorzadkowa.ToString() }, 0, liczbaPorzadkowa);
            this.tableProdukty.Controls.Add(new Label() { Text = id.ToString() }, 1, liczbaPorzadkowa);
            this.tableProdukty.Controls.Add(new Label() { Text = name }, 2, liczbaPorzadkowa);
            this.tableProdukty.Controls.Add(new TextBox() { Text = price.ToString("C") }, 3, liczbaPorzadkowa);
            this.tableProdukty.Controls.Add(new TextBox() { Text = promotion_price.ToString("C") }, 4, liczbaPorzadkowa);
            this.tableProdukty.Controls.Add(new Label() { Text = quantity.ToString() }, 5, liczbaPorzadkowa);
            this.tableProdukty.Controls.Add(new Label() { Text = "" }, 5, liczbaPorzadkowa);
        }
    }
}
