namespace Apu_Real_Estate__ARE_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cmbLegalForm = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            cmbCountry = new ComboBox();
            label4 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtZipCode = new TextBox();
            label2 = new Label();
            txtStreet = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            cmbNotUsed = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            cmbResidentialType = new ComboBox();
            cmbFloor = new ComboBox();
            cmbRoom = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox6 = new GroupBox();
            lblEstateItem = new Label();
            lstEstate = new ListBox();
            cmbTypeEstate = new ComboBox();
            btnAdd = new Button();
            picBoxEstate = new PictureBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxEstate).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbLegalForm);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(32, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estate-common data";
            // 
            // cmbLegalForm
            // 
            cmbLegalForm.FormattingEnabled = true;
            cmbLegalForm.Location = new Point(101, 63);
            cmbLegalForm.Name = "cmbLegalForm";
            cmbLegalForm.Size = new Size(138, 23);
            cmbLegalForm.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 66);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 8;
            label6.Text = "Legal Form";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 34);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 7;
            label5.Text = "Type of Estate";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbCountry);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtZipCode);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtStreet);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(332, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 130);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Address";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(81, 92);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(213, 23);
            cmbCountry.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 95);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.AccessibleDescription = "";
            txtCity.AccessibleName = "";
            txtCity.Location = new Point(181, 63);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(182, 23);
            txtCity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 66);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "City";
            // 
            // txtZipCode
            // 
            txtZipCode.AccessibleDescription = "";
            txtZipCode.AccessibleName = "";
            txtZipCode.Location = new Point(81, 60);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(60, 23);
            txtZipCode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 66);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Zip Code";
            // 
            // txtStreet
            // 
            txtStreet.AccessibleDescription = "";
            txtStreet.AccessibleName = "";
            txtStreet.Location = new Point(81, 31);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(282, 23);
            txtStreet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Street";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Location = new Point(32, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(567, 161);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Specificed Data";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cmbNotUsed);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(300, 40);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(232, 100);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Object-specific";
            // 
            // cmbNotUsed
            // 
            cmbNotUsed.FormattingEnabled = true;
            cmbNotUsed.Location = new Point(81, 20);
            cmbNotUsed.Name = "cmbNotUsed";
            cmbNotUsed.Size = new Size(109, 23);
            cmbNotUsed.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 59);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 14;
            label11.Text = "No. of rooms";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 28);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 13;
            label10.Text = "Not used!";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmbResidentialType);
            groupBox4.Controls.Add(cmbFloor);
            groupBox4.Controls.Add(cmbRoom);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(48, 183);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(223, 111);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Category-specific";
            // 
            // cmbResidentialType
            // 
            cmbResidentialType.FormattingEnabled = true;
            cmbResidentialType.Location = new Point(102, 78);
            cmbResidentialType.Name = "cmbResidentialType";
            cmbResidentialType.Size = new Size(109, 23);
            cmbResidentialType.TabIndex = 14;
            // 
            // cmbFloor
            // 
            cmbFloor.FormattingEnabled = true;
            cmbFloor.Location = new Point(85, 49);
            cmbFloor.Name = "cmbFloor";
            cmbFloor.Size = new Size(109, 23);
            cmbFloor.TabIndex = 13;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(85, 20);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(109, 23);
            cmbRoom.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 85);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 12;
            label9.Text = "Residential type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 59);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 11;
            label8.Text = "No. of floors";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 28);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 10;
            label7.Text = "No. of rooms";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblEstateItem);
            groupBox6.Controls.Add(lstEstate);
            groupBox6.Location = new Point(32, 350);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1194, 214);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "List of Estate";
            // 
            // lblEstateItem
            // 
            lblEstateItem.BackColor = SystemColors.MenuBar;
            lblEstateItem.BorderStyle = BorderStyle.FixedSingle;
            lblEstateItem.Location = new Point(801, 32);
            lblEstateItem.Margin = new Padding(0);
            lblEstateItem.Name = "lblEstateItem";
            lblEstateItem.Size = new Size(362, 169);
            lblEstateItem.TabIndex = 1;
            // 
            // lstEstate
            // 
            lstEstate.FormattingEnabled = true;
            lstEstate.ItemHeight = 15;
            lstEstate.Location = new Point(16, 32);
            lstEstate.Name = "lstEstate";
            lstEstate.Size = new Size(739, 169);
            lstEstate.TabIndex = 0;
            // 
            // cmbTypeEstate
            // 
            cmbTypeEstate.FormattingEnabled = true;
            cmbTypeEstate.Location = new Point(133, 56);
            cmbTypeEstate.Name = "cmbTypeEstate";
            cmbTypeEstate.Size = new Size(138, 23);
            cmbTypeEstate.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.Location = new Point(626, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 59);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // picBoxEstate
            // 
            picBoxEstate.BorderStyle = BorderStyle.FixedSingle;
            picBoxEstate.Location = new Point(738, 25);
            picBoxEstate.Name = "picBoxEstate";
            picBoxEstate.Size = new Size(273, 308);
            picBoxEstate.TabIndex = 10;
            picBoxEstate.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Window;
            btnUpdate.Location = new Point(32, 570);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(188, 46);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Window;
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(319, 568);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 46);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = SystemColors.Window;
            btnDeleteAll.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteAll.Location = new Point(599, 568);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(188, 46);
            btnDeleteAll.TabIndex = 13;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 626);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(picBoxEstate);
            Controls.Add(btnAdd);
            Controls.Add(cmbTypeEstate);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxEstate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox txtStreet;
        private Label label1;
        private Label label4;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtZipCode;
        private Label label2;
        private ComboBox cmbLegalForm;
        private Label label6;
        private Label label5;
        private ComboBox cmbCountry;
        private ComboBox cmbTypeEstate;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cmbResidentialType;
        private ComboBox cmbFloor;
        private ComboBox cmbRoom;
        private Label label11;
        private Label label10;
        private ComboBox cmbNotUsed;
        private ListBox lstEstate;
        private Button btnAdd;
        private PictureBox picBoxEstate;
        private Label lblEstateItem;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
    }
}
