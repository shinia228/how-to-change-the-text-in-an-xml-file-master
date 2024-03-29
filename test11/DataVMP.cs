using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace test11
{
    public partial class DataVMP : Form
    {
        public DataVMP()
        {
            
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.xml)|*.xml";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string filePath = txtbox_filename1.Text;
            string _date = txtbox_data.Text;
            string vmp = txtbox_vmp.Text;
            string newValue = txtbox_lpu11.Text;




            XmlDocument doc = new XmlDocument();
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", encoding.HeaderName, null);
            doc.InsertBefore(xmlDeclaration, doc.DocumentElement);
            using (var reader = new StreamReader(filePath, encoding))
            {
                doc.Load(reader);
            }
            // Чтение XML файла с указанием кодировки UTF-8


            XmlNodeList slList = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "' and USL/KOD_VMP='" + vmp + "']");

            foreach (XmlNode slNode in slList)
            {
                XmlNode uslNode = slNode.SelectSingleNode("USL");
                if (uslNode != null)
                {
                    XmlNode lpu1Node = slNode.SelectSingleNode("LPU_1");

                    // Проверка условий
                    if (lpu1Node != null)
                    {
                        // Изменение значения <LPU_1>
                        
                        lpu1Node.InnerText = newValue;
                        
                    }
                }

            }

            XmlNodeList nodes22 = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL/USL[KOD_VMP='" + vmp+"' and DATE_IN='"+ _date +"']");

            foreach (XmlNode node in nodes22)
            {
                XmlNode lpu1Node22 = node.SelectSingleNode("LPU_1");
                if (lpu1Node22 != null)
                {
                    lpu1Node22.InnerText = newValue;
                }
            }




            doc.Save(filePath);
            MessageBox.Show("Файл сохранен!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            txtbox_filename1.Text = filename;
            MessageBox.Show("Файл открыт");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Menu newForm = new Menu();
            newForm.Show();
            this.Close();
        }
    }
}
//XmlNodeList nodes = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "']");

//foreach (XmlNode node in nodes)
//{
//    XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
//    if (lpu1Node != null)
//    {
//        lpu1Node.InnerText = newValue;
//    }
//}
//XmlNodeList nodes1 = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "']");

//foreach (XmlNode node in nodes1)
//{
//    XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
//    if (lpu1Node != null)
//    {
//        lpu1Node.InnerText = newValue;
//    }
//}

//doc.Save(filePath);


//XmlNodeList nodes_1 = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL/USL[KOD_VMP='" + vmp + "']");

//foreach (XmlNode node in nodes_1)
//{
//    XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
//    if (lpu1Node != null)
//    {
//        lpu1Node.InnerText = newValue;
//    }
//}

//XmlNodeList nodes2 = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "']");

//foreach (XmlNode node in nodes2)
//{
//    XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
//    if (lpu1Node != null)
//    {
//        lpu1Node.InnerText = newValue;
//    }
//}


//foreach (XmlNode node in nodes_1)
//{
//    XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
//    if (lpu1Node != null)
//    {

//        lpu1Node.InnerText = newValue;
//    }
//}
//foreach (XmlNode node in nodes_2)
//{
//    XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
//    if (lpu1Node != null)
//    {

//        lpu1Node.InnerText = newValue;
//    }
//}
//XmlNodeList nodes = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "']");

//foreach (XmlNode node in nodes)
//{
//    XmlNode lpu1Node = node.SelectSingleNode("LPU_1");
//    if (lpu1Node != null)
//    {
//        lpu1Node.InnerText = newValue;
//    }
//////////////////}

//ListBox listBoxOutput = new ListBox(); // Создаем ListBox
//listBoxOutput.Name = "listBoxOutput"; // Указываем имя для ListBox
//listBoxOutput.Dock = DockStyle.Fill; // Занимает всю доступную область
//this.Controls.Add(listBoxOutput); // Добавляем ListBox на форму

//XmlNodeList slList = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL[DATE_1='" + _date + "']");
//foreach (XmlNode slNode in slList)
//{
//    XmlNode SLNode = slNode.SelectSingleNode("SL");

//    if (SLNode != null)
//    {

//        XmlNode lpu1Node = slNode.SelectSingleNode("SL");
//        if (lpu1Node != null)
//        {
//            listBoxOutput.Items.Add("Текущее значение LPU_1: " + lpu1Node.InnerText);
//            lpu1Node.InnerText = newValue;
//            listBoxOutput.Items.Add("Новое значение LPU_1: " + lpu1Node.InnerText);
//        }
//        XmlNodeList slList1 = doc.SelectNodes("ZL_LIST/ZAP/Z_SL/SL/USL[KOD_VMP='" + vmp + "']");
//        foreach (XmlNode slNode1 in slList1)
//        {
//            XmlNode UslNode1 = slNode1.SelectSingleNode("USL");
//            if (UslNode1 != null)
//            {

//                XmlNode lpu1Node1 = slNode1.SelectSingleNode("LPU_1");
//                if (lpu1Node != null)
//                {
//                    lpu1Node1.InnerText = newValue;
//                    listBoxOutput.Items.Add("Текущее значение LPU_1: " + lpu1Node.InnerText);
//                    listBoxOutput.Items.Add("Новое значение LPU_1: " + lpu1Node.InnerText);
//                }
//            }
//        }

//    }

//}

//XmlNodeList slList1 = doc.SelectNodes("OK/SL/USL[KOD_VMP='" + vmp + "']");

//listBoxOutput.Items.Add("Найдено узлов: " + slList.Count);

//foreach (XmlNode slNode1 in slList1)
//{
//    XmlNode uslNode1 = slNode1.SelectSingleNode("USL");
//    if (uslNode1 != null)
//    {
//        XmlNode lpu1Node1 = slNode1.SelectSingleNode("LPU_1");

//        // Проверка условий
//        if (lpu1Node1 != null)
//        {
//            // Изменение значения <LPU_1>
//            listBoxOutput.Items.Add("Текущее значение LPU_1: " + lpu1Node1.InnerText);
//            lpu1Node1.InnerText = newValue;
//            listBoxOutput.Items.Add("Новое значение LPU_1: " + lpu1Node1.InnerText);
//        }
//    }

//}
