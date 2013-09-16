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
    public partial class Form3 : Form
    {
        ObjectStoreSDK.Container container;
        ObjectStoreSDK.Object childObject;
        public Form3(ObjectStoreSDK.Container container)
        {
            InitializeComponent();
            this.container = container;
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (String child in container.getChildren())
            {
                if (!child.Equals(null))
                {
                    listBox1.Items.Add(child);
                    
                }
            }
            foreach (string child in listBox1.Items)
            {
                ObjectStoreSDK.Object childObject = container.getChildObject(child);
                if (childObject.isGetSuccessful() & (!container.getChildrenRange().Equals("0-0")))
                {
                    ObjectStoreSDK.Metadata metadata = childObject.getMetadata();

                    listBox2.Items.Add(metadata.getUserMetadata("studentName"));
                    listBox3.Items.Add(metadata.getUserMetadata("cTime"));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            childObject = container.getChildObject
                (Convert.ToString(listBox1.SelectedItem));
            if (childObject.isGetSuccessful())
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text Files (.txt) | *.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (childObject.writeObjectToFile(save.FileName))
                        MessageBox.Show("Assignment saved", "Success");
                }
            }
            else
                MessageBox.Show("Cannot Retrieve file", "Error");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!container.getChildrenRange().Equals("0-0"))
            {
                if (container.deleteChildObject
                    (Convert.ToString(listBox1.SelectedItem)))
                {
                    MessageBox.Show("File deleted successfully", "Success");
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    foreach (String child in container.getChildren())
                    {
                        if (!child.Equals(null))
                        {
                            listBox1.Items.Add(child);
                            /*ObjectStoreSDK.Object childObject = container.getChildObject(child);
                            if (childObject.isGetSuccessful())
                            {
                                ObjectStoreSDK.Metadata metadata = childObject.getMetadata();

                                listBox2.Items.Add(metadata.getUserMetadata("studentName"));
                                listBox3.Items.Add(metadata.getUserMetadata("cTime"));
                            }*/
                        }
                    }

                    foreach (string child in listBox1.Items)
                    {
                        ObjectStoreSDK.Object childObject = container.getChildObject(child);
                        if (childObject.isGetSuccessful() & (!container.getChildrenRange().Equals("0-0")))
                        {
                            ObjectStoreSDK.Metadata metadata = childObject.getMetadata();
                            listBox2.Items.Add(metadata.getUserMetadata("studentName"));
                            listBox3.Items.Add(metadata.getUserMetadata("cTime"));
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Cannot Delete", "Error");
                }
            }
            else
            {
                MessageBox.Show("Cannot Delete","Error");
            }
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            if (container.updateMetadata("password", textBox3.Text))
            {
                MessageBox.Show("Password changed!","Success");
            }
            else
            {
                MessageBox.Show("Failed to change password!", "Error");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            ObjectStoreSDK.Metadata metadata;
            String md;
            ObjectStoreSDK.Object ob;
            foreach (String child in container.getChildren())
            {
                ob = container.getChildObject(child);
                metadata = ob.getMetadata();
                md = metadata.getUserMetadata("subject");
                if(md.Equals(textBox1.Text))
                {
                    listBox1.Items.Add(child);
                    listBox2.Items.Add(metadata.getUserMetadata("studentName"));
                    listBox3.Items.Add(metadata.getUserMetadata("cTime"));

                }
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (String child in container.getChildren())
            {
                if (!child.Equals(null))
                {
                    listBox1.Items.Add(child);

                }
            }
            foreach (string child in listBox1.Items)
            {
                ObjectStoreSDK.Object childObject = container.getChildObject(child);
                if (childObject.isGetSuccessful() & (!container.getChildrenRange().Equals("0-0")))
                {
                    ObjectStoreSDK.Metadata metadata = childObject.getMetadata();

                    listBox2.Items.Add(metadata.getUserMetadata("studentName"));
                    listBox3.Items.Add(metadata.getUserMetadata("cTime"));
                }
            }
        }


    }
}
