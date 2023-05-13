using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8f
{
    public partial class Form1 : Form
    {
        List<studentinfo> l = new List<studentinfo>();
        string combine = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var query = from num in l orderby num.gender ascending select num;
            foreach (studentinfo b in query)
            {
                dataGridView1.Rows.Add(b.StudentID, b.StudentName, b.Age, b.marks, b.gender);
            }
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("No Data found");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var query = from num in l select num;

            foreach (studentinfo b in query)
            {
                dataGridView1.Rows.Add(b.StudentID, b.StudentName, b.Age, b.marks, b.gender);
                //combine = combine + " Name=  " + b.StudentName + " ,ID= " + b.StudentID + " ,Age= " + b.Age + " Gender= " + b.gender + " ,Marks= " + b.marks + " \n";
            }
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("No Data found");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
            {
                MessageBox.Show("Some field missing ");
            }
            else
            {
                studentinfo s = new studentinfo();
                s.StudentID = int.Parse(textBox1.Text);
                s.StudentName = textBox2.Text;
                s.Age = int.Parse(textBox3.Text);
                s.marks = int.Parse(textBox4.Text);
                s.gender = textBox5.Text;
                l.Add(s);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                MessageBox.Show("Data Added");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 0)
            {
                MessageBox.Show("Plz enter the name");
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                var query = from num in l where num.StudentName == textBox7.Text select num;
                foreach (studentinfo b in query)
                {
                    dataGridView1.Rows.Add(b.StudentID, b.StudentName, b.Age, b.marks, b.gender);
                    //combine = combine + " Name=  " + b.StudentName + " ,ID= " + b.StudentID + " ,Age= " + b.Age + " Gender= " + b.gender + " ,Marks= " + b.marks + " \n";
                }
            }
            if (textBox7.Text.Length != 0)
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("No Data found");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 0)
            {
                MessageBox.Show("Plz enter the marks");
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                var query = from num in l where num.marks == int.Parse(textBox6.Text) select num;
                foreach (studentinfo b in query)
                {
                    dataGridView1.Rows.Add(b.StudentID, b.StudentName, b.Age, b.marks, b.gender);
                }
              
            }
            if (textBox6.Text.Length != 0)
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("No Data found");
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var query = from num in l orderby num.marks ascending select num;
            foreach (studentinfo b in query)
            {
                dataGridView1.Rows.Add(b.StudentID, b.StudentName, b.Age, b.marks, b.gender);
            }
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("No Data found");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

