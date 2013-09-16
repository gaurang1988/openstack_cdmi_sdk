using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        ObjectStoreSDK.Client client;
        ObjectStoreSDK.Handler handler;
        List<String> professors;
        private bool flag;

        public Form2(ObjectStoreSDK.Client client)
        {
            InitializeComponent();
            this.client = client;
            handler = client.getHandler();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            text = text.Replace(' ', '_');
            foreach (string professor in professors)
            {
                if (text.Equals(professor))
                {
                    MessageBox.Show("Professor already exists", "Error!!");
                    flag = true;
                }
            }
            if (!flag)
            {
                if (handler.createContainer(text,"password",textBox2.Text))
                {
                    MessageBox.Show("Professor Added!!", "Success");
                    listBox1.Items.Clear();
                    professors = handler.displayAccountContents();
                    foreach (String professor in professors)
                        listBox1.Items.Add(professor);
                }
                textBox1.Visible = false;
                textBox1.Clear();
                textBox2.Visible = false;
                textBox2.Clear();
                button3.Visible = false;
                button1.Enabled = true;
                button2.Enabled = true;
                /*ObjectStoreSDK.Container container = handler.getContainer(Convert.ToString(listBox1.SelectedItem));
                ObjectStoreSDK.Metadata metadata = container.getMetadata();
                textBox2.Text = metadata.getUserMetadata("password");*/
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            professors = handler.displayAccountContents();
            foreach (String professor in professors)
                listBox1.Items.Add(professor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (handler.deleteContainer(Convert.ToString(listBox1.SelectedItem)))
            {
                MessageBox.Show("Professor Deleted!!", "Success");
                listBox1.Items.Clear();
                professors = handler.displayAccountContents();
                foreach (String professor in professors)
                    listBox1.Items.Add(professor);
            }
            else
                MessageBox.Show("Cannot delete professor", "Error");
        }

       

    }
}
