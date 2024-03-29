using Excel = Microsoft.Office.Interop.Excel;
using System.Xml;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Globalization;


namespace test11
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.xml)|*.xml";
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            txtbox_filename.Text = filename;
            MessageBox.Show("Файл открыт");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string filePath = txtbox_filename.Text;
            string _date = txtbox_data1.Text;
            string snils = txtbox_snils.Text;
            string newValue = txtbox_lpu1.Text;
            string speciality = txtbox_spec.Text;
            string vmp = txtbox_vmp.Text;



            XmlDocument doc = new XmlDocument();
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", encoding.HeaderName, null);
            doc.InsertBefore(xmlDeclaration, doc.DocumentElement);
            using (var reader = new StreamReader(filePath, encoding))
            {
                doc.Load(reader);
            }
            // Чтение XML файла с указанием кодировки UTF-8



            doc.Load(filePath);



            XmlNodeList nodes = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "' and IDDOKT='" + snils + "' and PRVS= '" + speciality + "']");

            foreach (XmlNode node in nodes)
            {
                XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
                if (lpu1Node != null)
                {
                    lpu1Node.InnerText = newValue;
                }
            }


            doc.Save(filePath);


            XmlNodeList nodes_1 = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL/USL[DATE_IN='" + _date + "' and KOD_VMP='" + vmp + "' and MR_USL_N/CODE_MD='" + snils + "' and MR_USL_N/PRVS= '" + speciality + "']");

            foreach (XmlNode node in nodes_1)
            {
                XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
                if (lpu1Node != null)
                {
                    lpu1Node.InnerText = newValue;
                }
            }

            // Сохранение изменений обратно в XML файл с указанием кодировки


            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            Encoding encoding_1 = Encoding.GetEncoding("windows-1251"); // Windows-1251, так как в .NET называется windows-1252
            settings.Encoding = encoding_1;
            using (var writer = XmlWriter.Create(filePath, settings))
            {
                doc.Save(writer);
            }

            MessageBox.Show("Файл сохранен!");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string filePath = txtbox_filename.Text;
            string _date = txtbox_data1.Text;
            string snils = txtbox_snils.Text;
            string newValue = txtbox_lpu1.Text;
            string speciality = txtbox_spec.Text;



            XmlDocument doc = new XmlDocument();
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", encoding.HeaderName, null);
            doc.InsertBefore(xmlDeclaration, doc.DocumentElement);
            using (var reader = new StreamReader(filePath, encoding))
            {
                doc.Load(reader);
            }
            // Чтение XML файла с указанием кодировки UTF-8



            doc.Load(filePath);



            XmlNodeList nodes = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "']");

            foreach (XmlNode node in nodes)
            {
                XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
                if (lpu1Node != null)
                {
                    lpu1Node.InnerText = newValue;
                }
            }


            doc.Save(filePath);


            XmlNodeList nodes_1 = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL/USL[DATE_IN='" + _date + "']");

            foreach (XmlNode node in nodes_1)
            {
                XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
                if (lpu1Node != null)
                {
                    lpu1Node.InnerText = newValue;
                }
            }

            // Сохранение изменений обратно в XML файл с указанием кодировки


            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            Encoding encoding_1 = Encoding.GetEncoding("windows-1251"); // Windows-1251, так как в .NET называется windows-1252
            settings.Encoding = encoding_1;
            using (var writer = XmlWriter.Create(filePath, settings))
            {
                doc.Save(writer);
            }

            MessageBox.Show("Файл сохранен!");

        }

        private void btn_back_menu_Click(object sender, EventArgs e)
        {
            Menu newForm = new Menu();
            newForm.Show();
            this.Close();
        }
    }
}
