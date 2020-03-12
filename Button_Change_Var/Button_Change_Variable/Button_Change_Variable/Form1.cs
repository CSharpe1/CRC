using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Button_Change_Variable
{
    public partial class Form1 : Form
    {
        // Initalise all variables to default values
        int VarA = 0;
        public Form1() {
          

            InitializeComponent();
            
            LabelVar.Text = $"{VarA}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e) {
            string name1 = "Rutendo";
            if (name1 == "Charles") {
                name1 = "Rutendo";
                label1.Text = $"My Name is {name1}";
                return;
            }
            else if (name1 == "Rutendo") {
                name1 = "Charles";
                label1.Text = $"My Name is {name1}";
                return;
            }
            else{
          //      name1 = "Nothign here";

            }

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void LabelVar_Click(object sender, EventArgs e) {
        
        }

        private void ChangeVar_Click(object sender, EventArgs e) {
            if (VarA == 0) {
                VarA = 1;
                LabelVar.Text = $"{VarA}";
            } 
            else if (VarA == 1) {
                VarA = 0;
                LabelVar.Text = $"{VarA}";
            } 
            else {
                LabelVar.Text = "ERROR!";
                VarA = 0;
                return;
            }
        }
    }
}
