using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace DotNetResourcer
{
    public partial class frmMain : Form
    {
        Dictionary<string, string> ReplaceLetters = new Dictionary<string, string>();
        public static string FILE_PATH = "";
        private void LoadSettings()
        {
        }

        private string ConvertKey(string text)
        {
            return text.ToLower().Replace(" ", "_").Replace("ş", "s").Replace("ö", "o").Replace("ü", "u")
                .Replace("ı", "i").Replace("ü", "u").Replace("ğ", "g").Replace("ç", "c").Replace("/", "")
                .Replace("?", "").Replace("!", "").Replace(".", "_").Replace(",", "").Replace(":", "").Replace("\n", "").Replace("-", "_");
        }

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSettings();

            lblTextMaxLength.Text = txtText.MaxLength.ToString();

            this.ActiveControl = txtText;
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text.Replace(Environment.NewLine, "");
            txtKey.Text = this.ConvertKey(txtText.Text);

            lblTextMaxLength.Text = (txtText.MaxLength - txtText.TextLength).ToString();
        }
        private void txtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtText.Text = Clipboard.GetText();
        }

        private void btnCopyForCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrefix.Text))
            {
                Clipboard.SetText(txtPrefix.Text + "." + txtKey.Text);
            }
            else
            {
                Clipboard.SetText(txtKey.Text);
            }
        }

        bool isText = false;
        bool isKey = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FILE_PATH))
            {
                MessageBox.Show("Dosya yolunu seçmelisiniz !");
                return;
            }
            isText = false;
            isKey = false;
            XDocument xDocument = XmlRead(txtText.Text, (txtKey.Text.ToLower() + txtPrefix.Text.ToLower()));

            string key = txtKey.Text + txtPrefix.Text;
            string word = txtText.Text;

            if (!isText)
            {
                if (isKey)
                {
                    key = key + "_text";
                }
                XmlWrite(xDocument, key, word);
            }

            string text = "R.string." + key;
            lblText.Text = text;
            Clipboard.SetText(text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FILE_PATH))
            {
                MessageBox.Show("Dosya yolunu seçmelisiniz !");
                return;
            }
            isText = false;
            isKey = false;
            XDocument xDocument = XmlRead(txtText.Text, (txtKey.Text.ToLower() + txtPrefix.Text.ToLower()));

            string key = txtKey.Text + txtPrefix.Text;
            string word = txtText.Text;

            if (!isText)
            {
                if (isKey)
                {
                    key = key + "_text";
                }
                XmlWrite(xDocument, key, word);
            }

            string text = "@string/" + key;
            lblText.Text = text;
            Clipboard.SetText(text);
        }
        private XDocument XmlRead(string key, string value)
        {
            string filePath = FILE_PATH + @"\values\strings.xml";
            XDocument xDoc = XDocument.Load(filePath);
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            foreach (var item in xDoc.Element("resources").Elements())
            {
                keyValues.Add(item.FirstAttribute.Value, item.Value);
                if (String.Equals(item.Value, value))
                {
                    isText = true;
                    txtKey.Text = item.FirstAttribute.Value;
                }
                if (String.Equals(item.FirstAttribute.Value.ToLower(), key.ToLower()))
                {
                    isKey = true;
                }
            }
            return xDoc;
        }
        private void XmlWrite(XDocument xDocument, string key, string text)
        {
            // C:\Ordinatrum\sarusmobil_repository\app\src\main\res\values

            string filePath = FILE_PATH + @"\values\strings.xml";
            XDocument xDoc = new XDocument();
            xDoc.Add(new XElement("resources"));
            foreach (var item in xDocument.Element("resources").Elements())
            {
                xDoc.Element("resources").Add(new XElement("string", item.Value, new XAttribute("name", item.FirstAttribute.Value)));
            }
            if (!String.IsNullOrEmpty(key))
            {
                xDoc.Element("resources").Add(new XElement("string", text, new XAttribute("name", key)));
            }
            try
            {
                xDoc.Save(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private void xmlOpen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FILE_PATH))
            {
                MessageBox.Show("Dosya yolunu seçmelisiniz !");
                return;
            }
            try
            {
                List<string> fileList = new List<string>();
                string[] array = Directory.GetDirectories(FILE_PATH);
                foreach (var item in array.Where(w => w.Contains("layout")))
                {
                    fileList.AddRange(Directory.GetFiles(item).ToList());
                }
                foreach (var filePath in fileList)
                {
                    XDocument doc = XDocument.Load(filePath);
                    foreach (XElement el in doc.Root.Elements())
                    {
                        controlXelement(el);
                    }
                    write(doc, filePath);
                }

                ////string fileName =fileList.FirstOrDefault();
                ////XDocument doc = XDocument.Load(fileName);
                ////foreach (XElement el in doc.Root.Elements())
                ////{
                ////    controlXelement(el);
                ////}
                ////write(doc);

            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void write(XDocument xDocument, string FILE_PATH)
        {
            //string FILE_PATH = @"C:\Ordinatrum\sarusmobil_repository\app\src\main\res\layout\activity_add_medicine_order_123.xml";

            try
            {
                xDocument.Declaration = new XDeclaration("1.0", null, null);
                xDocument.Save(FILE_PATH);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private XElement controlXelement(XElement xElement)
        {
            if (xElement.HasElements)
            {
                foreach (XElement element in xElement.Elements())
                {
                    controlXelement(element);
                }
            }
            if (xElement.HasAttributes)
            {
                foreach (XAttribute item in xElement.Attributes())
                {
                    if (item.Name.LocalName == "hint")
                    {
                        if (item.Value.StartsWith("@") == false)
                        {
                            string key = this.ConvertKey(item.Value);
                            string word = item.Value;

                            isText = false;
                            isKey = false;
                            XDocument xDocument1 = XmlRead(key, word);

                            if (!isText)
                            {
                                if (isKey)
                                {
                                    key = key + "_text";
                                }
                                XmlWrite(xDocument1, key, word);
                            }

                            string text = "@string/" + key;
                            item.Value = text;
                        }

                    }
                    else if (item.Name.LocalName == "text")
                    {
                        if (item.Value.StartsWith("@") == false)
                        {
                            string key = this.ConvertKey(item.Value);
                            string word = item.Value;

                            isText = false;
                            isKey = false;
                            XDocument xDocument1 = XmlRead(key, word);

                            if (!isText)
                            {
                                if (isKey)
                                {
                                    key = key + "_text";
                                }
                                XmlWrite(xDocument1, key, word);
                            }

                            string text = "@string/" + key;
                            item.Value = text;
                        }
                    }
                }
            }
            return xElement;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projenin 'res' Klasörünü seçiniz !");
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                FILE_PATH = directchoosedlg.SelectedPath;
                lblText.Text = "Seçili Dosya Yolu :" + directchoosedlg.SelectedPath;
            }
            else
            {
                MessageBox.Show("Hiçbir Klasör Seçilmedi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = FILE_PATH + @"\values\strings.xml";
            XDocument xDoc = XDocument.Load(filePath);
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            foreach (var item in xDoc.Element("resources").Elements())
            {
                keyValues.Add(item.FirstAttribute.Value, item.Value);
            }
            MessageBox.Show("Çıkarılacak Excel Seçiniz !");
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                lblText.Text = "Seçili Dosya Yolu :" + directchoosedlg.SelectedPath;
                string file_path = directchoosedlg.SelectedPath;

                Excel.Application ExcelUygulama0;             // excel uygulaması tanımla
                Excel.Workbook CalismaKitabi0;                // çalışma Kitabı tanımla
                Excel.Worksheet CalismaSayfasi0;              // çalışma Sayfası tanımla               
                ExcelUygulama0 = new Excel.Application();     // yeni bir excel uygulaması yarat

                CalismaKitabi0 = ExcelUygulama0.Workbooks.Open(file_path);                  // dosyayı aç
                CalismaSayfasi0 = (Excel.Worksheet)CalismaKitabi0.Worksheets.get_Item(1);   // 1. sayfayı aç
                int i = 1;
                foreach (var item in keyValues)
                {
                    CalismaSayfasi0.Cells[i, 1] = item.Key;
                    CalismaSayfasi0.Cells[i, 2] = item.Value;
                    i++;
                }

                ExcelUygulama0.Visible = true;                 // excel' i görünür yap

                ExcelUygulama0.Quit();      // excel uygulamasını kapat
            }
            else
            {
                MessageBox.Show("Hiçbir Klasör Seçilmedi");
            }

           
        }
    }
}