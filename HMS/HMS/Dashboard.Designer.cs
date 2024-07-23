
namespace HMS
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.controller = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFullHistory = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBxWardType = new System.Windows.Forms.ComboBox();
            this.comboBxWard = new System.Windows.Forms.ComboBox();
            this.txtBxMedicines = new System.Windows.Forms.TextBox();
            this.txtBxDiagonosis = new System.Windows.Forms.TextBox();
            this.txtBxSymptoms = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtAny = new System.Windows.Forms.TextBox();
            this.txtBlood = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System (HMS)";
            // 
            // controller
            // 
            this.controller.AutoSize = true;
            this.controller.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controller.Location = new System.Drawing.Point(25, 42);
            this.controller.Name = "controller";
            this.controller.Size = new System.Drawing.Size(128, 19);
            this.controller.TabIndex = 1;
            this.controller.Text = "controller";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(30, 89);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(158, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New Patient Record";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add diagnosis Information";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFullHistory
            // 
            this.btnFullHistory.Location = new System.Drawing.Point(30, 186);
            this.btnFullHistory.Name = "btnFullHistory";
            this.btnFullHistory.Size = new System.Drawing.Size(158, 23);
            this.btnFullHistory.TabIndex = 4;
            this.btnFullHistory.Text = "Full History of the Patient";
            this.btnFullHistory.UseVisualStyleBackColor = true;
            // 
            // btnHospital
            // 
            this.btnHospital.Location = new System.Drawing.Point(30, 233);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(158, 23);
            this.btnHospital.TabIndex = 5;
            this.btnHospital.Text = "Hospital Information";
            this.btnHospital.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(61, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.comboGender);
            this.panel1.Controls.Add(this.txtPID);
            this.panel1.Controls.Add(this.txtAny);
            this.panel1.Controls.Add(this.txtBlood);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(194, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 344);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBxWardType);
            this.panel2.Controls.Add(this.comboBxWard);
            this.panel2.Controls.Add(this.txtBxMedicines);
            this.panel2.Controls.Add(this.txtBxDiagonosis);
            this.panel2.Controls.Add(this.txtBxSymptoms);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(194, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 344);
            this.panel2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBxWardType
            // 
            this.comboBxWardType.FormattingEnabled = true;
            this.comboBxWardType.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac",
            "None"});
            this.comboBxWardType.Location = new System.Drawing.Point(441, 243);
            this.comboBxWardType.Name = "comboBxWardType";
            this.comboBxWardType.Size = new System.Drawing.Size(121, 20);
            this.comboBxWardType.TabIndex = 13;
            // 
            // comboBxWard
            // 
            this.comboBxWard.FormattingEnabled = true;
            this.comboBxWard.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBxWard.Location = new System.Drawing.Point(441, 209);
            this.comboBxWard.Name = "comboBxWard";
            this.comboBxWard.Size = new System.Drawing.Size(121, 20);
            this.comboBxWard.TabIndex = 12;
            // 
            // txtBxMedicines
            // 
            this.txtBxMedicines.Location = new System.Drawing.Point(93, 269);
            this.txtBxMedicines.Name = "txtBxMedicines";
            this.txtBxMedicines.Size = new System.Drawing.Size(100, 22);
            this.txtBxMedicines.TabIndex = 11;
            // 
            // txtBxDiagonosis
            // 
            this.txtBxDiagonosis.Location = new System.Drawing.Point(93, 237);
            this.txtBxDiagonosis.Name = "txtBxDiagonosis";
            this.txtBxDiagonosis.Size = new System.Drawing.Size(100, 22);
            this.txtBxDiagonosis.TabIndex = 10;
            // 
            // txtBxSymptoms
            // 
            this.txtBxSymptoms.Location = new System.Drawing.Point(93, 209);
            this.txtBxSymptoms.Name = "txtBxSymptoms";
            this.txtBxSymptoms.Size = new System.Drawing.Size(100, 22);
            this.txtBxSymptoms.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(343, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 7;
            this.label17.Text = "Type of Ward";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(343, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "Wrad Required?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "Medcines";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "Diagnosis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "Symptom\'s";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 101);
            this.dataGridView1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "Pid";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(147, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adding More Information About Patient";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(418, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboGender.Location = new System.Drawing.Point(194, 169);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(298, 20);
            this.comboGender.TabIndex = 16;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(65, 292);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(317, 22);
            this.txtPID.TabIndex = 15;
            // 
            // txtAny
            // 
            this.txtAny.Location = new System.Drawing.Point(65, 243);
            this.txtAny.Name = "txtAny";
            this.txtAny.Size = new System.Drawing.Size(427, 22);
            this.txtAny.TabIndex = 14;
            // 
            // txtBlood
            // 
            this.txtBlood.Location = new System.Drawing.Point(194, 194);
            this.txtBlood.Name = "txtBlood";
            this.txtBlood.Size = new System.Drawing.Size(298, 22);
            this.txtBlood.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(194, 143);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(298, 22);
            this.txtAge.TabIndex = 12;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(194, 115);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(298, 22);
            this.txtContact.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(194, 87);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(298, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 22);
            this.txtName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "Patient ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "Any Major Diease Suffered Earlier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Blood Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add New Patient Record";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHospital);
            this.Controls.Add(this.btnFullHistory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.controller);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label controller;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFullHistory;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtAny;
        private System.Windows.Forms.TextBox txtBlood;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBxWardType;
        private System.Windows.Forms.ComboBox comboBxWard;
        private System.Windows.Forms.TextBox txtBxMedicines;
        private System.Windows.Forms.TextBox txtBxDiagonosis;
        private System.Windows.Forms.TextBox txtBxSymptoms;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}