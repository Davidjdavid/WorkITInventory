using ExcelDataReader;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace OSR_Inventory {
    public partial class formInv : Form {

        public DateTime today = DateTime.Today;
        String pathLI = "W:\\IT\\Help Desk\\Equipment Inventory";

        public formInv() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            maskedTextBoxTodayDate.Text = DateTime.Today.ToString("MM-dd-yyyy");
        }

        private void Clear_Click(object sender, EventArgs e) {
            comboBoxTypeOfItem.Text = String.Empty;
            richTextBoxNotes.Text = String.Empty;
            comboBoxReasonForOSR.Text = String.Empty;
            textBoxMake.Text = String.Empty;
            textBoxModelNumber.Text = String.Empty;
            textBoxSerialNumber.Text = String.Empty;
            maskedTextBoxLI.Text = String.Empty;
        }


        private void checkBoxMultiple_CheckedChanged(object sender, EventArgs e) {
            if(checkBoxMultiple.Checked) {
                textBoxMake.Enabled = false;
                textBoxModelNumber.Enabled = false;
                textBoxSerialNumber.Enabled = false;
                maskedTextBoxLI.Enabled = false;
                numericUpDown1.Enabled = true;
            } else {
                textBoxMake.Enabled = true;
                textBoxModelNumber.Enabled = true;
                textBoxSerialNumber.Enabled = true;
                maskedTextBoxLI.Enabled = true;
                numericUpDown1.Enabled = false;

            }
            
        }

        private void Submit_Click(object sender, EventArgs e) {
            int index = this.dataGridView1.Rows.Count;
            index++;
            this.dataGridView1.Rows.Add();
            dataGridView1.Rows[index-1].Cells[0].Value = comboBoxReasonForOSR.SelectedValue;
        }

        private void buttonOpenLI_Click(object sender, EventArgs e) {
            
            if(Directory.Exists(pathLI)) {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                Process.Start("W:\\IT\\Help Desk\\Equipment Inventory\\LI Log.mdb");
            } else {
                System.Windows.Forms.MessageBox.Show("Unable to locate the LI Log file. Make sure the file is located in W:\\IT\\Help Desk\\Equipment Inventory", "File not found");

            }
        }
        
        private void comboBoxTypeOfItem_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void comboBoxReasonForOSR_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void Tab_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (Tab.SelectedTab == Search) {
                this.Size = new System.Drawing.Size(1154, 599);
                Console.WriteLine("x");

            }
            else if (Tab.SelectedTab == Incoming) {
                this.Size = new System.Drawing.Size(622, 635);
                Console.WriteLine("x");

            }
        }


        private void comboBoxReasonForOSR_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (comboBoxReasonForOSR.SelectedItem == "Other") {
                textBoxOther.Enabled = true;
            }
            else {
                textBoxOther.Enabled = false;

            }
        }

        private void comboBoxTypeOfItem_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (comboBoxTypeOfItem.SelectedItem == "Other") {
                textBoxOtherItem.Enabled = true;
            }
            else {
                textBoxOtherItem.Enabled = false;
            }
        }
    }
}
