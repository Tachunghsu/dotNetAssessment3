namespace dotNetAssessment3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSelectTagRange = new System.Windows.Forms.Label();
            this.btnTagSelectQuery = new System.Windows.Forms.Button();
            this.lblTagSelectlSelectMeassage = new System.Windows.Forms.Label();
            this.txtTagSelectId = new System.Windows.Forms.TextBox();
            this.pnAddTag = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTagImprotOwnerInfo = new System.Windows.Forms.Button();
            this.btnScanTag = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblAddTagSN = new System.Windows.Forms.Label();
            this.btnAddTagOwnerSave = new System.Windows.Forms.Button();
            this.txtAddTagOwnerAddress = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblAddTagStatus = new System.Windows.Forms.Label();
            this.lblAddTagOwnerAddress = new System.Windows.Forms.Label();
            this.lblAddTagOwnerLastName = new System.Windows.Forms.Label();
            this.lblAddTagOwnerFirstName = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.pnSelectedTag = new System.Windows.Forms.Panel();
            this.cbShowSelectedTagStatus = new System.Windows.Forms.ComboBox();
            this.lblSelectedtagStatus = new System.Windows.Forms.Label();
            this.lblShowSelectedOwnerAddress = new System.Windows.Forms.Label();
            this.lblSelectedAddress = new System.Windows.Forms.Label();
            this.lblShowSelectedOwnerId = new System.Windows.Forms.Label();
            this.lblSelectedOwnerId = new System.Windows.Forms.Label();
            this.lblShowSelectedOwnerName = new System.Windows.Forms.Label();
            this.lblSelectedOwnerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTrackingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTrackingDataSet = new dotNetAssessment3.AnimalTrackingDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ownersTableAdapter = new dotNetAssessment3.AnimalTrackingDataSetTableAdapters.OwnersTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnAddTag.SuspendLayout();
            this.pnSelectedTag.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTrackingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTrackingDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSelectTagRange);
            this.tabPage1.Controls.Add(this.btnTagSelectQuery);
            this.tabPage1.Controls.Add(this.lblTagSelectlSelectMeassage);
            this.tabPage1.Controls.Add(this.txtTagSelectId);
            this.tabPage1.Controls.Add(this.pnAddTag);
            this.tabPage1.Controls.Add(this.btnAddTag);
            this.tabPage1.Controls.Add(this.pnSelectedTag);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tag";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSelectTagRange
            // 
            this.lblSelectTagRange.AutoSize = true;
            this.lblSelectTagRange.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelectTagRange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectTagRange.Location = new System.Drawing.Point(294, 23);
            this.lblSelectTagRange.Name = "lblSelectTagRange";
            this.lblSelectTagRange.Size = new System.Drawing.Size(41, 18);
            this.lblSelectTagRange.TabIndex = 14;
            this.lblSelectTagRange.Text = "(1-X)";
            // 
            // btnTagSelectQuery
            // 
            this.btnTagSelectQuery.Location = new System.Drawing.Point(355, 9);
            this.btnTagSelectQuery.Name = "btnTagSelectQuery";
            this.btnTagSelectQuery.Size = new System.Drawing.Size(99, 39);
            this.btnTagSelectQuery.TabIndex = 13;
            this.btnTagSelectQuery.Text = "Query";
            this.btnTagSelectQuery.UseVisualStyleBackColor = true;
            this.btnTagSelectQuery.Click += new System.EventHandler(this.btnTagSelectQuery_Click);
            // 
            // lblTagSelectlSelectMeassage
            // 
            this.lblTagSelectlSelectMeassage.AutoSize = true;
            this.lblTagSelectlSelectMeassage.ForeColor = System.Drawing.Color.Red;
            this.lblTagSelectlSelectMeassage.Location = new System.Drawing.Point(221, 47);
            this.lblTagSelectlSelectMeassage.Name = "lblTagSelectlSelectMeassage";
            this.lblTagSelectlSelectMeassage.Size = new System.Drawing.Size(141, 21);
            this.lblTagSelectlSelectMeassage.TabIndex = 12;
            this.lblTagSelectlSelectMeassage.Text = "SystemMessage";
            // 
            // txtTagSelectId
            // 
            this.txtTagSelectId.Location = new System.Drawing.Point(201, 15);
            this.txtTagSelectId.Name = "txtTagSelectId";
            this.txtTagSelectId.Size = new System.Drawing.Size(87, 29);
            this.txtTagSelectId.TabIndex = 11;
            // 
            // pnAddTag
            // 
            this.pnAddTag.Controls.Add(this.label7);
            this.pnAddTag.Controls.Add(this.label6);
            this.pnAddTag.Controls.Add(this.label5);
            this.pnAddTag.Controls.Add(this.btnAddTagImprotOwnerInfo);
            this.pnAddTag.Controls.Add(this.btnScanTag);
            this.pnAddTag.Controls.Add(this.textBox6);
            this.pnAddTag.Controls.Add(this.lblAddTagSN);
            this.pnAddTag.Controls.Add(this.btnAddTagOwnerSave);
            this.pnAddTag.Controls.Add(this.txtAddTagOwnerAddress);
            this.pnAddTag.Controls.Add(this.textBox2);
            this.pnAddTag.Controls.Add(this.textBox1);
            this.pnAddTag.Controls.Add(this.comboBox2);
            this.pnAddTag.Controls.Add(this.lblAddTagStatus);
            this.pnAddTag.Controls.Add(this.lblAddTagOwnerAddress);
            this.pnAddTag.Controls.Add(this.lblAddTagOwnerLastName);
            this.pnAddTag.Controls.Add(this.lblAddTagOwnerFirstName);
            this.pnAddTag.Location = new System.Drawing.Point(542, 73);
            this.pnAddTag.Name = "pnAddTag";
            this.pnAddTag.Size = new System.Drawing.Size(444, 418);
            this.pnAddTag.TabIndex = 10;
            this.pnAddTag.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(256, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "SystemMessage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(256, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "SystemMessage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(256, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "SystemMessage";
            // 
            // btnAddTagImprotOwnerInfo
            // 
            this.btnAddTagImprotOwnerInfo.Location = new System.Drawing.Point(35, 138);
            this.btnAddTagImprotOwnerInfo.Name = "btnAddTagImprotOwnerInfo";
            this.btnAddTagImprotOwnerInfo.Size = new System.Drawing.Size(390, 34);
            this.btnAddTagImprotOwnerInfo.TabIndex = 20;
            this.btnAddTagImprotOwnerInfo.Text = "Import owner data from DB";
            this.btnAddTagImprotOwnerInfo.UseVisualStyleBackColor = true;
            // 
            // btnScanTag
            // 
            this.btnScanTag.Location = new System.Drawing.Point(35, 46);
            this.btnScanTag.Name = "btnScanTag";
            this.btnScanTag.Size = new System.Drawing.Size(212, 30);
            this.btnScanTag.TabIndex = 19;
            this.btnScanTag.Text = "Scan( for testing)";
            this.btnScanTag.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(222, 11);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 29);
            this.textBox6.TabIndex = 18;
            // 
            // lblAddTagSN
            // 
            this.lblAddTagSN.AutoSize = true;
            this.lblAddTagSN.Location = new System.Drawing.Point(46, 14);
            this.lblAddTagSN.Name = "lblAddTagSN";
            this.lblAddTagSN.Size = new System.Drawing.Size(160, 21);
            this.lblAddTagSN.TabIndex = 17;
            this.lblAddTagSN.Text = "Tag Serial Number";
            // 
            // btnAddTagOwnerSave
            // 
            this.btnAddTagOwnerSave.Location = new System.Drawing.Point(184, 367);
            this.btnAddTagOwnerSave.Name = "btnAddTagOwnerSave";
            this.btnAddTagOwnerSave.Size = new System.Drawing.Size(100, 37);
            this.btnAddTagOwnerSave.TabIndex = 16;
            this.btnAddTagOwnerSave.Text = "Save";
            this.btnAddTagOwnerSave.UseVisualStyleBackColor = true;
            // 
            // txtAddTagOwnerAddress
            // 
            this.txtAddTagOwnerAddress.Location = new System.Drawing.Point(39, 304);
            this.txtAddTagOwnerAddress.Name = "txtAddTagOwnerAddress";
            this.txtAddTagOwnerAddress.Size = new System.Drawing.Size(386, 29);
            this.txtAddTagOwnerAddress.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 29);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 29);
            this.textBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox2.Location = new System.Drawing.Point(222, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 29);
            this.comboBox2.TabIndex = 12;
            // 
            // lblAddTagStatus
            // 
            this.lblAddTagStatus.AutoSize = true;
            this.lblAddTagStatus.Location = new System.Drawing.Point(46, 94);
            this.lblAddTagStatus.Name = "lblAddTagStatus";
            this.lblAddTagStatus.Size = new System.Drawing.Size(102, 21);
            this.lblAddTagStatus.TabIndex = 8;
            this.lblAddTagStatus.Text = "Tag Status:";
            // 
            // lblAddTagOwnerAddress
            // 
            this.lblAddTagOwnerAddress.AutoSize = true;
            this.lblAddTagOwnerAddress.Location = new System.Drawing.Point(31, 280);
            this.lblAddTagOwnerAddress.Name = "lblAddTagOwnerAddress";
            this.lblAddTagOwnerAddress.Size = new System.Drawing.Size(138, 21);
            this.lblAddTagOwnerAddress.TabIndex = 6;
            this.lblAddTagOwnerAddress.Text = "Owner Address:";
            // 
            // lblAddTagOwnerLastName
            // 
            this.lblAddTagOwnerLastName.AutoSize = true;
            this.lblAddTagOwnerLastName.Location = new System.Drawing.Point(31, 232);
            this.lblAddTagOwnerLastName.Name = "lblAddTagOwnerLastName";
            this.lblAddTagOwnerLastName.Size = new System.Drawing.Size(158, 21);
            this.lblAddTagOwnerLastName.TabIndex = 4;
            this.lblAddTagOwnerLastName.Text = "Owner Last Name:";
            // 
            // lblAddTagOwnerFirstName
            // 
            this.lblAddTagOwnerFirstName.AutoSize = true;
            this.lblAddTagOwnerFirstName.Location = new System.Drawing.Point(31, 188);
            this.lblAddTagOwnerFirstName.Name = "lblAddTagOwnerFirstName";
            this.lblAddTagOwnerFirstName.Size = new System.Drawing.Size(159, 21);
            this.lblAddTagOwnerFirstName.TabIndex = 2;
            this.lblAddTagOwnerFirstName.Text = "Owner First Name:";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(657, 9);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(195, 39);
            this.btnAddTag.TabIndex = 4;
            this.btnAddTag.Text = "Add a new tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // pnSelectedTag
            // 
            this.pnSelectedTag.Controls.Add(this.cbShowSelectedTagStatus);
            this.pnSelectedTag.Controls.Add(this.lblSelectedtagStatus);
            this.pnSelectedTag.Controls.Add(this.lblShowSelectedOwnerAddress);
            this.pnSelectedTag.Controls.Add(this.lblSelectedAddress);
            this.pnSelectedTag.Controls.Add(this.lblShowSelectedOwnerId);
            this.pnSelectedTag.Controls.Add(this.lblSelectedOwnerId);
            this.pnSelectedTag.Controls.Add(this.lblShowSelectedOwnerName);
            this.pnSelectedTag.Controls.Add(this.lblSelectedOwnerName);
            this.pnSelectedTag.Location = new System.Drawing.Point(31, 73);
            this.pnSelectedTag.Name = "pnSelectedTag";
            this.pnSelectedTag.Size = new System.Drawing.Size(423, 417);
            this.pnSelectedTag.TabIndex = 3;
            this.pnSelectedTag.Visible = false;
            // 
            // cbShowSelectedTagStatus
            // 
            this.cbShowSelectedTagStatus.FormattingEnabled = true;
            this.cbShowSelectedTagStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbShowSelectedTagStatus.Location = new System.Drawing.Point(189, 23);
            this.cbShowSelectedTagStatus.Name = "cbShowSelectedTagStatus";
            this.cbShowSelectedTagStatus.Size = new System.Drawing.Size(151, 29);
            this.cbShowSelectedTagStatus.TabIndex = 11;
            // 
            // lblSelectedtagStatus
            // 
            this.lblSelectedtagStatus.AutoSize = true;
            this.lblSelectedtagStatus.Location = new System.Drawing.Point(35, 26);
            this.lblSelectedtagStatus.Name = "lblSelectedtagStatus";
            this.lblSelectedtagStatus.Size = new System.Drawing.Size(102, 21);
            this.lblSelectedtagStatus.TabIndex = 8;
            this.lblSelectedtagStatus.Text = "Tag Status:";
            // 
            // lblShowSelectedOwnerAddress
            // 
            this.lblShowSelectedOwnerAddress.AutoSize = true;
            this.lblShowSelectedOwnerAddress.Location = new System.Drawing.Point(40, 212);
            this.lblShowSelectedOwnerAddress.Name = "lblShowSelectedOwnerAddress";
            this.lblShowSelectedOwnerAddress.Size = new System.Drawing.Size(133, 21);
            this.lblShowSelectedOwnerAddress.TabIndex = 7;
            this.lblShowSelectedOwnerAddress.Text = "Owner Address";
            // 
            // lblSelectedAddress
            // 
            this.lblSelectedAddress.AutoSize = true;
            this.lblSelectedAddress.Location = new System.Drawing.Point(35, 185);
            this.lblSelectedAddress.Name = "lblSelectedAddress";
            this.lblSelectedAddress.Size = new System.Drawing.Size(138, 21);
            this.lblSelectedAddress.TabIndex = 6;
            this.lblSelectedAddress.Text = "Owner Address:";
            // 
            // lblShowSelectedOwnerId
            // 
            this.lblShowSelectedOwnerId.AutoSize = true;
            this.lblShowSelectedOwnerId.Location = new System.Drawing.Point(190, 93);
            this.lblShowSelectedOwnerId.Name = "lblShowSelectedOwnerId";
            this.lblShowSelectedOwnerId.Size = new System.Drawing.Size(86, 21);
            this.lblShowSelectedOwnerId.TabIndex = 5;
            this.lblShowSelectedOwnerId.Text = "Owner ID";
            // 
            // lblSelectedOwnerId
            // 
            this.lblSelectedOwnerId.AutoSize = true;
            this.lblSelectedOwnerId.Location = new System.Drawing.Point(35, 93);
            this.lblSelectedOwnerId.Name = "lblSelectedOwnerId";
            this.lblSelectedOwnerId.Size = new System.Drawing.Size(91, 21);
            this.lblSelectedOwnerId.TabIndex = 4;
            this.lblSelectedOwnerId.Text = "Owner ID:";
            // 
            // lblShowSelectedOwnerName
            // 
            this.lblShowSelectedOwnerName.AutoSize = true;
            this.lblShowSelectedOwnerName.Location = new System.Drawing.Point(190, 137);
            this.lblShowSelectedOwnerName.Name = "lblShowSelectedOwnerName";
            this.lblShowSelectedOwnerName.Size = new System.Drawing.Size(114, 21);
            this.lblShowSelectedOwnerName.TabIndex = 3;
            this.lblShowSelectedOwnerName.Text = "Owner Name";
            // 
            // lblSelectedOwnerName
            // 
            this.lblSelectedOwnerName.AutoSize = true;
            this.lblSelectedOwnerName.Location = new System.Drawing.Point(35, 137);
            this.lblSelectedOwnerName.Name = "lblSelectedOwnerName";
            this.lblSelectedOwnerName.Size = new System.Drawing.Size(119, 21);
            this.lblSelectedOwnerName.TabIndex = 2;
            this.lblSelectedOwnerName.Text = "Owner Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the tag by id:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TagOwner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ownersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 420);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.animalTrackingDataSetBindingSource;
            // 
            // animalTrackingDataSetBindingSource
            // 
            this.animalTrackingDataSetBindingSource.DataSource = this.animalTrackingDataSet;
            this.animalTrackingDataSetBindingSource.Position = 0;
            // 
            // animalTrackingDataSet
            // 
            this.animalTrackingDataSet.DataSetName = "AnimalTrackingDataSet";
            this.animalTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(576, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 420);
            this.panel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add new owner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 29);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(229, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 29);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(229, 144);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 29);
            this.textBox5.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Owner Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Owner Last Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Owner First Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Operator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(552, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 420);
            this.panel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 47);
            this.button4.TabIndex = 16;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(229, 201);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(151, 29);
            this.textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(229, 144);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(151, 29);
            this.textBox9.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operator Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Operator First Name:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(470, 419);
            this.dataGridView2.TabIndex = 0;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Animal Tracking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnAddTag.ResumeLayout(false);
            this.pnAddTag.PerformLayout();
            this.pnSelectedTag.ResumeLayout(false);
            this.pnSelectedTag.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTrackingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTrackingDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnAddTag;
        private System.Windows.Forms.Label lblAddTagStatus;
        private System.Windows.Forms.Label lblAddTagOwnerAddress;
        private System.Windows.Forms.Label lblAddTagOwnerLastName;
        private System.Windows.Forms.Label lblAddTagOwnerFirstName;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Panel pnSelectedTag;
        private System.Windows.Forms.ComboBox cbShowSelectedTagStatus;
        private System.Windows.Forms.Label lblSelectedtagStatus;
        private System.Windows.Forms.Label lblShowSelectedOwnerAddress;
        private System.Windows.Forms.Label lblSelectedAddress;
        private System.Windows.Forms.Label lblShowSelectedOwnerId;
        private System.Windows.Forms.Label lblSelectedOwnerId;
        private System.Windows.Forms.Label lblShowSelectedOwnerName;
        private System.Windows.Forms.Label lblSelectedOwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnAddTagOwnerSave;
        private System.Windows.Forms.TextBox txtAddTagOwnerAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTagSelectlSelectMeassage;
        private System.Windows.Forms.TextBox txtTagSelectId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddTagImprotOwnerInfo;
        private System.Windows.Forms.Button btnScanTag;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblAddTagSN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTagSelectQuery;
        private System.Windows.Forms.Label lblSelectTagRange;
        private System.Windows.Forms.BindingSource animalTrackingDataSetBindingSource;
        private AnimalTrackingDataSet animalTrackingDataSet;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private AnimalTrackingDataSetTableAdapters.OwnersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    }
}

