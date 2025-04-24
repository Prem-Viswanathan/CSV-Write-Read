using CsvHelper;
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

namespace Create_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var Location1 = "";
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Files (*.csv)|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture));
                        writer.WriteHeader(typeof(Student));
                        writer.NextRecord();
                        foreach (Student s in studentBindingSource.DataSource as List<Student>)
                        {
                            writer.WriteRecord(s);
                            writer.NextRecord();
                        }

                    }
                    MessageBox.Show("Your data has been Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = new List<Student>();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV Files (*.csv)|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = true
                    });
                    var student = csv.GetRecords<Student>().ToList();
                    studentBindingSource.DataSource = student;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Files (*.csv)|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine(txtempID.Text + "," + txtempName.Text + "," + txtSalary.Text);
                        MessageBox.Show("Data Saved");
                        cleardata();
                    }
                }
            }
        }

        private void cleardata()
        {
            txtSalary.Text = string.Empty;
            txtempName.Text = string.Empty;
            txtempID.Text = string.Empty;
            txtempID.Focus();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog sfd = new SaveFileDialog() {
                Filter = "CSV Files (*.csv)|*.csv", 
                Title = " Choose Location to save CSV File",
                
                ValidateNames = true })
            {
                sfd.FileName = txtcvsFilename.Text;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                     txtLoc .Text = sfd.FileName;   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (StreamWriter sw = File.AppendText(@"D:\Prem Training\CSV\gery.csv"))
           //FileName = txtcvsFilename.Text,
            using (StreamWriter sw = File.AppendText(txtLoc.Text))
            {
                sw.WriteLine(txtempID.Text + "," + txtempName.Text + "," + txtSalary.Text);
                MessageBox.Show("Data Saved");
                cleardata();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
