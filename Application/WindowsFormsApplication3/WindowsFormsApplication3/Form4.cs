///Copyright 2013 IBM Corp.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        ObjectStoreSDK.Client client;
        ObjectStoreSDK.Handler handler;
        String obj;
        public Form4(ObjectStoreSDK.Client client,String obj)
        {
            InitializeComponent();
            this.client = client;
            this.obj = obj;
        }

        private void login_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            handler = client.getHandler();
            foreach (String container in handler.displayAccountContents())
            {
                listBox1.Items.Add(container);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (.txt) | *.txt";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {

               // File.Create("F:/TestFolder/tri.txt");
                
                //StreamWriter sw = new StreamWriter("F:/TestFolder/tri.txt");
                File.WriteAllText("F:/TestFolder/tri.txt","\"studentName\" : \"" 
                    + obj + "\" , \"cTime\" : \"" + DateTime.Now.ToString() + "\" , \"subject\" : \"" + textBox1.Text + "\"");
               
                if (/*handler.createObject(Convert.ToString(listBox1.SelectedItem),
                    open.SafeFileName, open.FileName,"studentName",obj))*/handler.createObject(Convert.ToString(listBox1.SelectedItem),
                    open.SafeFileName,open.FileName,"F:/TestFolder/tri.txt"))
                {
                    MessageBox.Show("Assignment submitted", "Success");
                }
                else
                    MessageBox.Show("Failed to upload assignment","Error");
            }
        }

        
    }
}
