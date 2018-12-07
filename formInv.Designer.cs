using System.Windows.Forms;

namespace OSR_Inventory {
    partial class formInv {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Tab = new System.Windows.Forms.TabControl();
            this.Search = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TypeOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonForOSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBroughtToOSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveFromOSR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Incoming = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonOpenLI = new System.Windows.Forms.Button();
            this.MMddYYYY = new System.Windows.Forms.Label();
            this.textBoxOtherItem = new System.Windows.Forms.TextBox();
            this.labelOtherItem = new System.Windows.Forms.Label();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.labelOtherOSR = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxLI = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTodayDate = new System.Windows.Forms.MaskedTextBox();
            this.labelMultiple = new System.Windows.Forms.Label();
            this.checkBoxMultiple = new System.Windows.Forms.CheckBox();
            this.labelTodayDate = new System.Windows.Forms.Label();
            this.textBoxYourName = new System.Windows.Forms.TextBox();
            this.labelYourName = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.labelMake = new System.Windows.Forms.Label();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.labelModelNumber = new System.Windows.Forms.Label();
            this.textBoxModelNumber = new System.Windows.Forms.TextBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.labelDatePurchased = new System.Windows.Forms.Label();
            this.labelLiNumber = new System.Windows.Forms.Label();
            this.comboBoxReasonForOSR = new System.Windows.Forms.ComboBox();
            this.labelReasonForOSR = new System.Windows.Forms.Label();
            this.labelItemType = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.comboBoxTypeOfItem = new System.Windows.Forms.ComboBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Tab.SuspendLayout();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Incoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.Search);
            this.Tab.Controls.Add(this.Incoming);
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1154, 599);
            this.Tab.TabIndex = 0;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged_1);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Controls.Add(this.dataGridView1);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1146, 573);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfItem,
            this.ReasonForOSR,
            this.Make,
            this.ModelNumber,
            this.SerialNumber,
            this.DatePurchased,
            this.LI,
            this.Amount,
            this.AddedBy,
            this.DateBroughtToOSR,
            this.RemoveFromOSR});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 573);
            this.dataGridView1.TabIndex = 0;
            // 
            // TypeOfItem
            // 
            this.TypeOfItem.HeaderText = "Type Of Item";
            this.TypeOfItem.Name = "TypeOfItem";
            this.TypeOfItem.ReadOnly = true;
            // 
            // ReasonForOSR
            // 
            this.ReasonForOSR.HeaderText = "Reason For OSR";
            this.ReasonForOSR.Name = "ReasonForOSR";
            this.ReasonForOSR.ReadOnly = true;
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            this.Make.ReadOnly = true;
            // 
            // ModelNumber
            // 
            this.ModelNumber.HeaderText = "Model Number";
            this.ModelNumber.Name = "ModelNumber";
            this.ModelNumber.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "SerialNumber";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // DatePurchased
            // 
            this.DatePurchased.HeaderText = "Date Purchased";
            this.DatePurchased.Name = "DatePurchased";
            this.DatePurchased.ReadOnly = true;
            // 
            // LI
            // 
            this.LI.HeaderText = "LI";
            this.LI.Name = "LI";
            this.LI.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // AddedBy
            // 
            this.AddedBy.HeaderText = "Added By";
            this.AddedBy.Name = "AddedBy";
            this.AddedBy.ReadOnly = true;
            // 
            // DateBroughtToOSR
            // 
            this.DateBroughtToOSR.HeaderText = "Date Brought To OSR";
            this.DateBroughtToOSR.Name = "DateBroughtToOSR";
            this.DateBroughtToOSR.ReadOnly = true;
            // 
            // RemoveFromOSR
            // 
            this.RemoveFromOSR.HeaderText = "RemoveFromOSR";
            this.RemoveFromOSR.Name = "RemoveFromOSR";
            this.RemoveFromOSR.ReadOnly = true;
            // 
            // Incoming
            // 
            this.Incoming.Controls.Add(this.maskedTextBox1);
            this.Incoming.Controls.Add(this.buttonOpenLI);
            this.Incoming.Controls.Add(this.MMddYYYY);
            this.Incoming.Controls.Add(this.textBoxOtherItem);
            this.Incoming.Controls.Add(this.labelOtherItem);
            this.Incoming.Controls.Add(this.textBoxOther);
            this.Incoming.Controls.Add(this.labelOtherOSR);
            this.Incoming.Controls.Add(this.numericUpDown1);
            this.Incoming.Controls.Add(this.maskedTextBoxLI);
            this.Incoming.Controls.Add(this.maskedTextBoxTodayDate);
            this.Incoming.Controls.Add(this.labelMultiple);
            this.Incoming.Controls.Add(this.checkBoxMultiple);
            this.Incoming.Controls.Add(this.labelTodayDate);
            this.Incoming.Controls.Add(this.textBoxYourName);
            this.Incoming.Controls.Add(this.labelYourName);
            this.Incoming.Controls.Add(this.labelUser);
            this.Incoming.Controls.Add(this.labelDetails);
            this.Incoming.Controls.Add(this.labelEquipment);
            this.Incoming.Controls.Add(this.labelMake);
            this.Incoming.Controls.Add(this.textBoxMake);
            this.Incoming.Controls.Add(this.labelModelNumber);
            this.Incoming.Controls.Add(this.textBoxModelNumber);
            this.Incoming.Controls.Add(this.labelSerialNumber);
            this.Incoming.Controls.Add(this.textBoxSerialNumber);
            this.Incoming.Controls.Add(this.labelDatePurchased);
            this.Incoming.Controls.Add(this.labelLiNumber);
            this.Incoming.Controls.Add(this.comboBoxReasonForOSR);
            this.Incoming.Controls.Add(this.labelReasonForOSR);
            this.Incoming.Controls.Add(this.labelItemType);
            this.Incoming.Controls.Add(this.labelNotes);
            this.Incoming.Controls.Add(this.richTextBoxNotes);
            this.Incoming.Controls.Add(this.comboBoxTypeOfItem);
            this.Incoming.Controls.Add(this.Clear);
            this.Incoming.Controls.Add(this.Submit);
            this.Incoming.Location = new System.Drawing.Point(4, 22);
            this.Incoming.Name = "Incoming";
            this.Incoming.Padding = new System.Windows.Forms.Padding(3);
            this.Incoming.Size = new System.Drawing.Size(1146, 573);
            this.Incoming.TabIndex = 1;
            this.Incoming.Text = "Add to Inventory";
            this.Incoming.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(13, 381);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox1.TabIndex = 37;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // buttonOpenLI
            // 
            this.buttonOpenLI.Location = new System.Drawing.Point(54, 427);
            this.buttonOpenLI.Name = "buttonOpenLI";
            this.buttonOpenLI.Size = new System.Drawing.Size(75, 30);
            this.buttonOpenLI.TabIndex = 36;
            this.buttonOpenLI.Text = "Open LI Log";
            this.buttonOpenLI.UseVisualStyleBackColor = true;
            this.buttonOpenLI.Click += new System.EventHandler(this.buttonOpenLI_Click);
            // 
            // MMddYYYY
            // 
            this.MMddYYYY.AutoSize = true;
            this.MMddYYYY.Location = new System.Drawing.Point(503, 135);
            this.MMddYYYY.Name = "MMddYYYY";
            this.MMddYYYY.Size = new System.Drawing.Size(79, 13);
            this.MMddYYYY.TabIndex = 35;
            this.MMddYYYY.Text = "MM/DD/YYYY";
            // 
            // textBoxOtherItem
            // 
            this.textBoxOtherItem.Enabled = false;
            this.textBoxOtherItem.Location = new System.Drawing.Point(216, 86);
            this.textBoxOtherItem.Name = "textBoxOtherItem";
            this.textBoxOtherItem.Size = new System.Drawing.Size(186, 20);
            this.textBoxOtherItem.TabIndex = 34;
            // 
            // labelOtherItem
            // 
            this.labelOtherItem.AutoSize = true;
            this.labelOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherItem.Location = new System.Drawing.Point(212, 61);
            this.labelOtherItem.Name = "labelOtherItem";
            this.labelOtherItem.Size = new System.Drawing.Size(149, 20);
            this.labelOtherItem.TabIndex = 33;
            this.labelOtherItem.Text = "Other Type of Item: ";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Enabled = false;
            this.textBoxOther.Location = new System.Drawing.Point(216, 133);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(186, 20);
            this.textBoxOther.TabIndex = 32;
            // 
            // labelOtherOSR
            // 
            this.labelOtherOSR.AutoSize = true;
            this.labelOtherOSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherOSR.Location = new System.Drawing.Point(212, 108);
            this.labelOtherOSR.Name = "labelOtherOSR";
            this.labelOtherOSR.Size = new System.Drawing.Size(179, 20);
            this.labelOtherOSR.TabIndex = 31;
            this.labelOtherOSR.Text = "Other Reason for OSR: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(13, 519);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 30;
            // 
            // maskedTextBoxLI
            // 
            this.maskedTextBoxLI.Location = new System.Drawing.Point(13, 427);
            this.maskedTextBoxLI.Mask = "0000";
            this.maskedTextBoxLI.Name = "maskedTextBoxLI";
            this.maskedTextBoxLI.Size = new System.Drawing.Size(35, 20);
            this.maskedTextBoxLI.TabIndex = 29;
            // 
            // maskedTextBoxTodayDate
            // 
            this.maskedTextBoxTodayDate.BeepOnError = true;
            this.maskedTextBoxTodayDate.Location = new System.Drawing.Point(428, 132);
            this.maskedTextBoxTodayDate.Mask = "00/00/0000";
            this.maskedTextBoxTodayDate.Name = "maskedTextBoxTodayDate";
            this.maskedTextBoxTodayDate.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBoxTodayDate.TabIndex = 28;
            this.maskedTextBoxTodayDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelMultiple
            // 
            this.labelMultiple.AutoSize = true;
            this.labelMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultiple.Location = new System.Drawing.Point(8, 460);
            this.labelMultiple.Name = "labelMultiple";
            this.labelMultiple.Size = new System.Drawing.Size(165, 25);
            this.labelMultiple.TabIndex = 26;
            this.labelMultiple.Text = "Multiple Items:";
            // 
            // checkBoxMultiple
            // 
            this.checkBoxMultiple.AutoSize = true;
            this.checkBoxMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMultiple.Location = new System.Drawing.Point(13, 488);
            this.checkBoxMultiple.Name = "checkBoxMultiple";
            this.checkBoxMultiple.Size = new System.Drawing.Size(126, 24);
            this.checkBoxMultiple.TabIndex = 25;
            this.checkBoxMultiple.Text = "Multiple Items";
            this.checkBoxMultiple.UseVisualStyleBackColor = true;
            this.checkBoxMultiple.CheckedChanged += new System.EventHandler(this.checkBoxMultiple_CheckedChanged);
            // 
            // labelTodayDate
            // 
            this.labelTodayDate.AutoSize = true;
            this.labelTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTodayDate.Location = new System.Drawing.Point(424, 108);
            this.labelTodayDate.Name = "labelTodayDate";
            this.labelTodayDate.Size = new System.Drawing.Size(114, 20);
            this.labelTodayDate.TabIndex = 23;
            this.labelTodayDate.Text = "Today\'s Date:  ";
            // 
            // textBoxYourName
            // 
            this.textBoxYourName.Location = new System.Drawing.Point(428, 85);
            this.textBoxYourName.Name = "textBoxYourName";
            this.textBoxYourName.Size = new System.Drawing.Size(154, 20);
            this.textBoxYourName.TabIndex = 22;
            // 
            // labelYourName
            // 
            this.labelYourName.AutoSize = true;
            this.labelYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourName.Location = new System.Drawing.Point(424, 61);
            this.labelYourName.Name = "labelYourName";
            this.labelYourName.Size = new System.Drawing.Size(101, 20);
            this.labelYourName.TabIndex = 21;
            this.labelYourName.Text = "Your Name:  ";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(423, 24);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(68, 25);
            this.labelUser.TabIndex = 20;
            this.labelUser.Text = "User:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(8, 185);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(92, 25);
            this.labelDetails.TabIndex = 19;
            this.labelDetails.Text = "Details:";
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipment.Location = new System.Drawing.Point(8, 24);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(143, 25);
            this.labelEquipment.TabIndex = 18;
            this.labelEquipment.Text = "Equipement:";
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMake.Location = new System.Drawing.Point(16, 220);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(56, 20);
            this.labelMake.TabIndex = 17;
            this.labelMake.Text = "Make: ";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(13, 243);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(186, 20);
            this.textBoxMake.TabIndex = 16;
            // 
            // labelModelNumber
            // 
            this.labelModelNumber.AutoSize = true;
            this.labelModelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelNumber.Location = new System.Drawing.Point(20, 266);
            this.labelModelNumber.Name = "labelModelNumber";
            this.labelModelNumber.Size = new System.Drawing.Size(120, 20);
            this.labelModelNumber.TabIndex = 15;
            this.labelModelNumber.Text = "Model Number: ";
            // 
            // textBoxModelNumber
            // 
            this.textBoxModelNumber.Location = new System.Drawing.Point(13, 289);
            this.textBoxModelNumber.Name = "textBoxModelNumber";
            this.textBoxModelNumber.Size = new System.Drawing.Size(186, 20);
            this.textBoxModelNumber.TabIndex = 14;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumber.Location = new System.Drawing.Point(16, 312);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(117, 20);
            this.labelSerialNumber.TabIndex = 13;
            this.labelSerialNumber.Text = "Serial Number: ";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(13, 335);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(186, 20);
            this.textBoxSerialNumber.TabIndex = 12;
            // 
            // labelDatePurchased
            // 
            this.labelDatePurchased.AutoSize = true;
            this.labelDatePurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatePurchased.Location = new System.Drawing.Point(16, 358);
            this.labelDatePurchased.Name = "labelDatePurchased";
            this.labelDatePurchased.Size = new System.Drawing.Size(128, 20);
            this.labelDatePurchased.TabIndex = 11;
            this.labelDatePurchased.Text = "DatePurchased: ";
            // 
            // labelLiNumber
            // 
            this.labelLiNumber.AutoSize = true;
            this.labelLiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLiNumber.Location = new System.Drawing.Point(18, 404);
            this.labelLiNumber.Name = "labelLiNumber";
            this.labelLiNumber.Size = new System.Drawing.Size(87, 20);
            this.labelLiNumber.TabIndex = 9;
            this.labelLiNumber.Text = "LI Number:";
            // 
            // comboBoxReasonForOSR
            // 
            this.comboBoxReasonForOSR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReasonForOSR.Items.AddRange(new object[] {
            "Store in OSR indefinitely",
            "Store in OSR until certain date",
            "Keep for spare parts",
            "DA 110",
            "Other"});
            this.comboBoxReasonForOSR.Location = new System.Drawing.Point(13, 132);
            this.comboBoxReasonForOSR.Name = "comboBoxReasonForOSR";
            this.comboBoxReasonForOSR.Size = new System.Drawing.Size(184, 21);
            this.comboBoxReasonForOSR.TabIndex = 7;
            this.comboBoxReasonForOSR.SelectedIndexChanged += new System.EventHandler(this.comboBoxReasonForOSR_SelectedIndexChanged_1);
            // 
            // labelReasonForOSR
            // 
            this.labelReasonForOSR.AutoSize = true;
            this.labelReasonForOSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReasonForOSR.Location = new System.Drawing.Point(13, 108);
            this.labelReasonForOSR.Name = "labelReasonForOSR";
            this.labelReasonForOSR.Size = new System.Drawing.Size(135, 20);
            this.labelReasonForOSR.TabIndex = 6;
            this.labelReasonForOSR.Text = "Reason for OSR: ";
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemType.Location = new System.Drawing.Point(13, 61);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(105, 20);
            this.labelItemType.TabIndex = 5;
            this.labelItemType.Text = "Type of Item: ";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(222, 185);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(87, 25);
            this.labelNotes.TabIndex = 4;
            this.labelNotes.Text = "Notes: ";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(227, 213);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxNotes.Size = new System.Drawing.Size(355, 272);
            this.richTextBoxNotes.TabIndex = 3;
            this.richTextBoxNotes.Text = "";
            // 
            // comboBoxTypeOfItem
            // 
            this.comboBoxTypeOfItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfItem.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Monitor",
            "Internal Computer Part",
            "External Computer Part",
            "Networking Device",
            "Cable",
            "Non Computer Item",
            "Other"});
            this.comboBoxTypeOfItem.Location = new System.Drawing.Point(13, 84);
            this.comboBoxTypeOfItem.Name = "comboBoxTypeOfItem";
            this.comboBoxTypeOfItem.Size = new System.Drawing.Size(184, 21);
            this.comboBoxTypeOfItem.TabIndex = 2;
            this.comboBoxTypeOfItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfItem_SelectedIndexChanged_1);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(394, 521);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(97, 46);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(497, 521);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(97, 46);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // formInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 596);
            this.Controls.Add(this.Tab);
            this.Name = "formInv";
            this.Text = "OSR Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tab.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Incoming.ResumeLayout(false);
            this.Incoming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Incoming;
        private Button Clear;
        private Button Submit;
        private ComboBox comboBoxTypeOfItem;
        private Label labelNotes;
        private RichTextBox richTextBoxNotes;
        private ComboBox comboBoxReasonForOSR;
        private Label labelReasonForOSR;
        private Label labelItemType;
        private Label labelMake;
        private TextBox textBoxMake;
        private Label labelModelNumber;
        private TextBox textBoxModelNumber;
        private Label labelSerialNumber;
        private TextBox textBoxSerialNumber;
        private Label labelDatePurchased;
        private Label labelLiNumber;
        private Label labelEquipment;
        private Label labelTodayDate;
        private TextBox textBoxYourName;
        private Label labelYourName;
        private Label labelUser;
        private Label labelDetails;
        private Label labelMultiple;
        private CheckBox checkBoxMultiple;
        private MaskedTextBox maskedTextBoxTodayDate;
        private MaskedTextBox maskedTextBoxLI;
        private NumericUpDown numericUpDown1;
        private TextBox textBoxOther;
        private Label labelOtherOSR;
        private TextBox textBoxOtherItem;
        private Label labelOtherItem;
        private Label MMddYYYY;
        private Button buttonOpenLI;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TypeOfItem;
        private DataGridViewTextBoxColumn ReasonForOSR;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewTextBoxColumn ModelNumber;
        private DataGridViewTextBoxColumn SerialNumber;
        private DataGridViewTextBoxColumn DatePurchased;
        private DataGridViewTextBoxColumn LI;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AddedBy;
        private DataGridViewTextBoxColumn DateBroughtToOSR;
        private DataGridViewCheckBoxColumn RemoveFromOSR;
        private MaskedTextBox maskedTextBox1;
    }
}

