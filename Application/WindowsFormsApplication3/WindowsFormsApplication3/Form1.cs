///Copyright 2013 IBM Corp.

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
    public partial class Form1 : Form
    {
        ObjectStoreSDK.Client client;
        ObjectStoreSDK.Handler handler;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
            progressBar1.Value = progressBar1.Value + 5;
                
            }
            else
            {
                timer1.Stop();
                
                client=new ObjectStoreSDK.Client(textBox1.Text,"admin","admin","admin");
                if (!client.getAuthorizationToken())
                {
                    //this.Show();
                    MessageBox.Show("Cannot Authenticate User","Error!!");
                }
         

                else if (administrator.Checked == true)
                {
                    Form2 f2 = new Form2(client);
                    f2.Show();
                    this.Hide();
                }
                else if (professor.Checked == true)
                {
                    handler = client.getHandler();
                    ObjectStoreSDK.Container container = handler.getContainer(textBox2.Text);
                    ObjectStoreSDK.Metadata metadata = container.getMetadata();

                    if (container.isGetSuccessful() && textBox3.Text.Equals(metadata.getUserMetadata("password")))
                    {
                        Form3 f3 = new Form3(container);
                        f3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password","Error!");
                        textBox2.Clear();
                        textBox3.Clear();
                        progressBar1.Value = 0;
                        //this.Show();
                    }
                }
                else if (student.Checked == true)
                {
                    Form4 f4 = new Form4(client,textBox4.Text);
                    f4.Show();
                    this.Hide();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void professor_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox2.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
        }

        private void administrator_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox2.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;

        }

        private void student_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox2.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            label8.Visible = true;
            textBox4.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
