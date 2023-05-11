using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Завдання_XML
{
    public partial class Form1 : Form
    {
       
        
        

        private void LoadEmployees()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("xmltext.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int age = int.Parse(node["Age"].InnerText);
                bool programmer = bool.Parse(node["Programmer"].InnerText);
                listBox1.Items.Add(new Employee(name, age, programmer));

            }
        }

        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
