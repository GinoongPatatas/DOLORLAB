using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratory01
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }



        public static string SetFileName { get; private set; }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            String getInput = txtStudNuma.Text;
            String getInput1 = txtLname.Text;
            String getInput2 = txtAge.Text;
            String getInput3 = dTPBirthday.Text;
            String getInput4 = cbProgram.Text;
            String getInput5 = txtFirstName.Text;
            String getInput6 = cbGender.Text;
            String getInput7 = txtContactNum.Text;
            String getInput8 = txtMiddleInitial.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            getInput + ".txt")))
            {
                outputFile.WriteLine("Student Number: " + getInput);
                outputFile.WriteLine("Last Name: " + getInput1);
                outputFile.WriteLine("Age: " + getInput2);
                outputFile.WriteLine("Birthday: " + getInput3);
                outputFile.WriteLine("Program: " + getInput4);
                outputFile.WriteLine("First Name: " + getInput5);
                outputFile.WriteLine("Gender: " + getInput6);
                outputFile.WriteLine("Contact No.: " + getInput7);
                outputFile.WriteLine("M.I: " + getInput8);

                Console.WriteLine(getInput);

            }
            Close();
            }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {

        }
    }
    }

