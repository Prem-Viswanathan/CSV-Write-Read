using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_CSV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnfirstvalue_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var reader = new StreamReader(ofd.FileName))
                        using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
                        {
                            HasHeaderRecord = true // Assumes first row is headers
                        }))
                        {
                            // Get the first record from the CSV file
                            var student = csv.GetRecords<Student>().FirstOrDefault();  // Get the first record

                            if (student != null)
                            {
                                // Populate the TextBoxes with data from the first student record
                                txtempID.Text = student.StudentID;
                                txtempName.Text = student.StudentName;
                                txtSalary.Text = student.StudentEmail;
                                
                            }
                            else
                            {
                                MessageBox.Show("No data found in the CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
             
                    
            
        }

        private void btnspectvalu_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var reader = new StreamReader(ofd.FileName))
                        using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
                        {
                            HasHeaderRecord = true // Assumes first row is headers
                        }))
                        {
                            // Get the first record from the CSV file
                            var student = csv.GetRecords<Student>().FirstOrDefault(s => s.StudentID == txtcond.Text);  // Get the first record

                            if (student != null)
                            {
                                // Populate the TextBoxes with data from the first student record
                                txtempID.Text = student.StudentID;
                                txtempName.Text = student.StudentName;
                                txtSalary.Text = student.StudentEmail;

                            }
                            else
                            {
                                MessageBox.Show("No data found in the CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
