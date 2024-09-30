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
            txtObjectSpecific2 = new TextBox();
            cmbObjectSpecific1 = new ComboBox();
            lblObjectSpecific2 = new Label();
            lblObjectSpecific1 = new Label();
            groupBox4 = new GroupBox();
            txtCategory2 = new TextBox();
            txtCategory1 = new TextBox();
            cmbCategorySpecific3 = new ComboBox();
            lblcategorySpecific3 = new Label();
            lblCategorySpecific2 = new Label();
            lblCategorySpecific1 = new Label();
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
            cmbLegalForm.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
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
            groupBox5.Controls.Add(txtObjectSpecific2);
            groupBox5.Controls.Add(cmbObjectSpecific1);
            groupBox5.Controls.Add(lblObjectSpecific2);
            groupBox5.Controls.Add(lblObjectSpecific1);
            groupBox5.Location = new Point(300, 40);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(242, 100);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Object-specific";
            // 
            // txtObjectSpecific2
            // 
            txtObjectSpecific2.AccessibleDescription = "";
            txtObjectSpecific2.AccessibleName = "";
            txtObjectSpecific2.Location = new Point(123, 51);
            txtObjectSpecific2.Name = "txtObjectSpecific2";
            txtObjectSpecific2.Size = new Size(109, 23);
            txtObjectSpecific2.TabIndex = 16;
            // 
            // cmbObjectSpecific1
            // 
            cmbObjectSpecific1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjectSpecific1.FormattingEnabled = true;
            cmbObjectSpecific1.Location = new Point(123, 22);
            cmbObjectSpecific1.Name = "cmbObjectSpecific1";
            cmbObjectSpecific1.Size = new Size(109, 23);
            cmbObjectSpecific1.TabIndex = 15;
            // 
            // lblObjectSpecific2
            // 
            lblObjectSpecific2.AutoSize = true;
            lblObjectSpecific2.Location = new Point(6, 59);
            lblObjectSpecific2.Name = "lblObjectSpecific2";
            lblObjectSpecific2.Size = new Size(89, 15);
            lblObjectSpecific2.TabIndex = 14;
            lblObjectSpecific2.Text = "ObjectSpecific2";
            // 
            // lblObjectSpecific1
            // 
            lblObjectSpecific1.AutoSize = true;
            lblObjectSpecific1.Location = new Point(6, 28);
            lblObjectSpecific1.Name = "lblObjectSpecific1";
            lblObjectSpecific1.Size = new Size(89, 15);
            lblObjectSpecific1.TabIndex = 13;
            lblObjectSpecific1.Text = "ObjectSpecific1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtCategory2);
            groupBox4.Controls.Add(txtCategory1);
            groupBox4.Controls.Add(cmbCategorySpecific3);
            groupBox4.Controls.Add(lblcategorySpecific3);
            groupBox4.Controls.Add(lblCategorySpecific2);
            groupBox4.Controls.Add(lblCategorySpecific1);
            groupBox4.Location = new Point(48, 183);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(266, 111);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Category-specific";
            // 
            // txtCategory2
            // 
            txtCategory2.AccessibleDescription = "";
            txtCategory2.AccessibleName = "";
            txtCategory2.Location = new Point(148, 48);
            txtCategory2.Name = "txtCategory2";
            txtCategory2.Size = new Size(109, 23);
            txtCategory2.TabIndex = 15;
            // 
            // txtCategory1
            // 
            txtCategory1.AccessibleDescription = "";
            txtCategory1.AccessibleName = "";
            txtCategory1.Location = new Point(148, 20);
            txtCategory1.Name = "txtCategory1";
            txtCategory1.Size = new Size(109, 23);
            txtCategory1.TabIndex = 8;
            // 
            // cmbCategorySpecific3
            // 
            cmbCategorySpecific3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorySpecific3.FormattingEnabled = true;
            cmbCategorySpecific3.Location = new Point(148, 77);
            cmbCategorySpecific3.Name = "cmbCategorySpecific3";
            cmbCategorySpecific3.Size = new Size(109, 23);
            cmbCategorySpecific3.TabIndex = 14;
            // 
            // lblcategorySpecific3
            // 
            lblcategorySpecific3.AutoSize = true;
            lblcategorySpecific3.Location = new Point(6, 85);
            lblcategorySpecific3.Name = "lblcategorySpecific3";
            lblcategorySpecific3.Size = new Size(100, 15);
            lblcategorySpecific3.TabIndex = 12;
            lblcategorySpecific3.Text = "categorySpecific3";
            // 
            // lblCategorySpecific2
            // 
            lblCategorySpecific2.AutoSize = true;
            lblCategorySpecific2.Location = new Point(6, 59);
            lblCategorySpecific2.Name = "lblCategorySpecific2";
            lblCategorySpecific2.Size = new Size(100, 15);
            lblCategorySpecific2.TabIndex = 11;
            lblCategorySpecific2.Text = "categorySpecific2";
            // 
            // lblCategorySpecific1
            // 
            lblCategorySpecific1.AutoSize = true;
            lblCategorySpecific1.Location = new Point(6, 28);
            lblCategorySpecific1.Name = "lblCategorySpecific1";
            lblCategorySpecific1.Size = new Size(100, 15);
            lblCategorySpecific1.TabIndex = 10;
            lblCategorySpecific1.Text = "categorySpecific1";
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
            cmbTypeEstate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeEstate.FormattingEnabled = true;
            cmbTypeEstate.Location = new Point(133, 56);
            cmbTypeEstate.Name = "cmbTypeEstate";
            cmbTypeEstate.Size = new Size(138, 23);
            cmbTypeEstate.TabIndex = 8;
            cmbTypeEstate.SelectedIndexChanged += cmbTypeEstate_SelectedIndexChanged;
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
            btnAdd.Click += btnAdd_Click;
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
        private Label lblcategorySpecific3;
        private Label lblCategorySpecific2;
        private Label lblCategorySpecific1;
        private ComboBox cmbCategorySpecific3;
        private Label lblObjectSpecific2;
        private Label lblObjectSpecific1;
        private ComboBox cmbObjectSpecific1;
        private ListBox lstEstate;
        private Button btnAdd;
        private PictureBox picBoxEstate;
        private Label lblEstateItem;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private TextBox txtCategory2;
        private TextBox txtCategory1;
        private TextBox txtObjectSpecific2;
    }
}
