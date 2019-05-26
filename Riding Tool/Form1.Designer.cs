namespace Riding_Tool
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
            this.Data_DataGridView = new System.Windows.Forms.DataGridView();
            this.Col_Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Horse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Transport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Private = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox_Data_Input = new System.Windows.Forms.RichTextBox();
            this.Button_Stable_Email = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Stable_Subject = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_Beginner_Address = new System.Windows.Forms.Button();
            this.Button_Beginner_Subject = new System.Windows.Forms.Button();
            this.Button_Beginner_Email = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_Improver_Address = new System.Windows.Forms.Button();
            this.Button_Improver_Subject = new System.Windows.Forms.Button();
            this.Button_Improver_Email = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Button_Intermediate_Address = new System.Windows.Forms.Button();
            this.Button_Intermediate_Subject = new System.Windows.Forms.Button();
            this.Button_Intermediate_Email = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Button_Advanced_Address = new System.Windows.Forms.Button();
            this.Button_Advanced_Subject = new System.Windows.Forms.Button();
            this.Button_Advanced_Email = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data_DataGridView
            // 
            this.Data_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Timestamp,
            this.Col_Group,
            this.Col_Name,
            this.Col_Email,
            this.Col_Horse,
            this.Col_Transport,
            this.Col_Private});
            this.Data_DataGridView.Location = new System.Drawing.Point(12, 146);
            this.Data_DataGridView.Name = "Data_DataGridView";
            this.Data_DataGridView.Size = new System.Drawing.Size(757, 142);
            this.Data_DataGridView.TabIndex = 0;
            // 
            // Col_Timestamp
            // 
            this.Col_Timestamp.HeaderText = "Timestamp";
            this.Col_Timestamp.Name = "Col_Timestamp";
            // 
            // Col_Group
            // 
            this.Col_Group.HeaderText = "Group";
            this.Col_Group.Name = "Col_Group";
            // 
            // Col_Name
            // 
            this.Col_Name.HeaderText = "Name";
            this.Col_Name.Name = "Col_Name";
            // 
            // Col_Email
            // 
            this.Col_Email.HeaderText = "Email";
            this.Col_Email.Name = "Col_Email";
            // 
            // Col_Horse
            // 
            this.Col_Horse.HeaderText = "Horse";
            this.Col_Horse.Name = "Col_Horse";
            // 
            // Col_Transport
            // 
            this.Col_Transport.HeaderText = "Transport";
            this.Col_Transport.Name = "Col_Transport";
            // 
            // Col_Private
            // 
            this.Col_Private.HeaderText = "Private";
            this.Col_Private.Name = "Col_Private";
            // 
            // TextBox_Data_Input
            // 
            this.TextBox_Data_Input.Location = new System.Drawing.Point(12, 12);
            this.TextBox_Data_Input.Name = "TextBox_Data_Input";
            this.TextBox_Data_Input.Size = new System.Drawing.Size(757, 128);
            this.TextBox_Data_Input.TabIndex = 1;
            this.TextBox_Data_Input.Text = "";
            this.TextBox_Data_Input.TextChanged += new System.EventHandler(this.TextBox_Data_Input_TextChanged);
            // 
            // Button_Stable_Email
            // 
            this.Button_Stable_Email.Location = new System.Drawing.Point(6, 19);
            this.Button_Stable_Email.Name = "Button_Stable_Email";
            this.Button_Stable_Email.Size = new System.Drawing.Size(130, 23);
            this.Button_Stable_Email.TabIndex = 2;
            this.Button_Stable_Email.Text = "Click For Email";
            this.Button_Stable_Email.UseVisualStyleBackColor = true;
            this.Button_Stable_Email.Click += new System.EventHandler(this.Button_Stable_Email_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Stable_Subject);
            this.groupBox1.Controls.Add(this.Button_Stable_Email);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stables";
            // 
            // Button_Stable_Subject
            // 
            this.Button_Stable_Subject.Location = new System.Drawing.Point(142, 19);
            this.Button_Stable_Subject.Name = "Button_Stable_Subject";
            this.Button_Stable_Subject.Size = new System.Drawing.Size(130, 23);
            this.Button_Stable_Subject.TabIndex = 5;
            this.Button_Stable_Subject.Text = "Click For Subject";
            this.Button_Stable_Subject.UseVisualStyleBackColor = true;
            this.Button_Stable_Subject.Click += new System.EventHandler(this.Button_Stable_Subject_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_Beginner_Address);
            this.groupBox2.Controls.Add(this.Button_Beginner_Subject);
            this.groupBox2.Controls.Add(this.Button_Beginner_Email);
            this.groupBox2.Location = new System.Drawing.Point(12, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beginners";
            // 
            // Button_Beginner_Address
            // 
            this.Button_Beginner_Address.Location = new System.Drawing.Point(278, 19);
            this.Button_Beginner_Address.Name = "Button_Beginner_Address";
            this.Button_Beginner_Address.Size = new System.Drawing.Size(130, 23);
            this.Button_Beginner_Address.TabIndex = 4;
            this.Button_Beginner_Address.Text = "Click For Address";
            this.Button_Beginner_Address.UseVisualStyleBackColor = true;
            this.Button_Beginner_Address.Click += new System.EventHandler(this.Button_Beginner_Address_Click);
            // 
            // Button_Beginner_Subject
            // 
            this.Button_Beginner_Subject.Location = new System.Drawing.Point(142, 19);
            this.Button_Beginner_Subject.Name = "Button_Beginner_Subject";
            this.Button_Beginner_Subject.Size = new System.Drawing.Size(130, 23);
            this.Button_Beginner_Subject.TabIndex = 3;
            this.Button_Beginner_Subject.Text = "Click For Subject";
            this.Button_Beginner_Subject.UseVisualStyleBackColor = true;
            this.Button_Beginner_Subject.Click += new System.EventHandler(this.Button_Beginner_Subject_Click);
            // 
            // Button_Beginner_Email
            // 
            this.Button_Beginner_Email.Location = new System.Drawing.Point(6, 19);
            this.Button_Beginner_Email.Name = "Button_Beginner_Email";
            this.Button_Beginner_Email.Size = new System.Drawing.Size(130, 23);
            this.Button_Beginner_Email.TabIndex = 2;
            this.Button_Beginner_Email.Text = "Click For Email";
            this.Button_Beginner_Email.UseVisualStyleBackColor = true;
            this.Button_Beginner_Email.Click += new System.EventHandler(this.Button_Beginner_Email_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_Improver_Address);
            this.groupBox3.Controls.Add(this.Button_Improver_Subject);
            this.groupBox3.Controls.Add(this.Button_Improver_Email);
            this.groupBox3.Location = new System.Drawing.Point(12, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Improvers";
            // 
            // Button_Improver_Address
            // 
            this.Button_Improver_Address.Location = new System.Drawing.Point(278, 19);
            this.Button_Improver_Address.Name = "Button_Improver_Address";
            this.Button_Improver_Address.Size = new System.Drawing.Size(130, 23);
            this.Button_Improver_Address.TabIndex = 6;
            this.Button_Improver_Address.Text = "Click For Address";
            this.Button_Improver_Address.UseVisualStyleBackColor = true;
            this.Button_Improver_Address.Click += new System.EventHandler(this.Button_Improver_Address_Click);
            // 
            // Button_Improver_Subject
            // 
            this.Button_Improver_Subject.Location = new System.Drawing.Point(142, 19);
            this.Button_Improver_Subject.Name = "Button_Improver_Subject";
            this.Button_Improver_Subject.Size = new System.Drawing.Size(130, 23);
            this.Button_Improver_Subject.TabIndex = 5;
            this.Button_Improver_Subject.Text = "Click For Subject";
            this.Button_Improver_Subject.UseVisualStyleBackColor = true;
            this.Button_Improver_Subject.Click += new System.EventHandler(this.Button_Improver_Subject_Click);
            // 
            // Button_Improver_Email
            // 
            this.Button_Improver_Email.Location = new System.Drawing.Point(6, 19);
            this.Button_Improver_Email.Name = "Button_Improver_Email";
            this.Button_Improver_Email.Size = new System.Drawing.Size(130, 23);
            this.Button_Improver_Email.TabIndex = 2;
            this.Button_Improver_Email.Text = "Click For Email";
            this.Button_Improver_Email.UseVisualStyleBackColor = true;
            this.Button_Improver_Email.Click += new System.EventHandler(this.Button_Improver_Email_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Button_Intermediate_Address);
            this.groupBox4.Controls.Add(this.Button_Intermediate_Subject);
            this.groupBox4.Controls.Add(this.Button_Intermediate_Email);
            this.groupBox4.Location = new System.Drawing.Point(12, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 53);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Intermediate";
            // 
            // Button_Intermediate_Address
            // 
            this.Button_Intermediate_Address.Location = new System.Drawing.Point(278, 19);
            this.Button_Intermediate_Address.Name = "Button_Intermediate_Address";
            this.Button_Intermediate_Address.Size = new System.Drawing.Size(130, 23);
            this.Button_Intermediate_Address.TabIndex = 6;
            this.Button_Intermediate_Address.Text = "Click For Address";
            this.Button_Intermediate_Address.UseVisualStyleBackColor = true;
            this.Button_Intermediate_Address.Click += new System.EventHandler(this.Button_Intermediate_Address_Click);
            // 
            // Button_Intermediate_Subject
            // 
            this.Button_Intermediate_Subject.Location = new System.Drawing.Point(142, 19);
            this.Button_Intermediate_Subject.Name = "Button_Intermediate_Subject";
            this.Button_Intermediate_Subject.Size = new System.Drawing.Size(130, 23);
            this.Button_Intermediate_Subject.TabIndex = 5;
            this.Button_Intermediate_Subject.Text = "Click For Subject";
            this.Button_Intermediate_Subject.UseVisualStyleBackColor = true;
            this.Button_Intermediate_Subject.Click += new System.EventHandler(this.Button_Intermediate_Subject_Click);
            // 
            // Button_Intermediate_Email
            // 
            this.Button_Intermediate_Email.Location = new System.Drawing.Point(6, 19);
            this.Button_Intermediate_Email.Name = "Button_Intermediate_Email";
            this.Button_Intermediate_Email.Size = new System.Drawing.Size(130, 23);
            this.Button_Intermediate_Email.TabIndex = 2;
            this.Button_Intermediate_Email.Text = "Click For Email";
            this.Button_Intermediate_Email.UseVisualStyleBackColor = true;
            this.Button_Intermediate_Email.Click += new System.EventHandler(this.Button_Intermediate_Email_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Button_Advanced_Address);
            this.groupBox5.Controls.Add(this.Button_Advanced_Subject);
            this.groupBox5.Controls.Add(this.Button_Advanced_Email);
            this.groupBox5.Location = new System.Drawing.Point(12, 530);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 53);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Advanced";
            // 
            // Button_Advanced_Address
            // 
            this.Button_Advanced_Address.Location = new System.Drawing.Point(278, 19);
            this.Button_Advanced_Address.Name = "Button_Advanced_Address";
            this.Button_Advanced_Address.Size = new System.Drawing.Size(130, 23);
            this.Button_Advanced_Address.TabIndex = 6;
            this.Button_Advanced_Address.Text = "Click For Address";
            this.Button_Advanced_Address.UseVisualStyleBackColor = true;
            this.Button_Advanced_Address.Click += new System.EventHandler(this.Button_Advanced_Address_Click);
            // 
            // Button_Advanced_Subject
            // 
            this.Button_Advanced_Subject.Location = new System.Drawing.Point(142, 19);
            this.Button_Advanced_Subject.Name = "Button_Advanced_Subject";
            this.Button_Advanced_Subject.Size = new System.Drawing.Size(130, 23);
            this.Button_Advanced_Subject.TabIndex = 5;
            this.Button_Advanced_Subject.Text = "Click For Subject";
            this.Button_Advanced_Subject.UseVisualStyleBackColor = true;
            this.Button_Advanced_Subject.Click += new System.EventHandler(this.Button_Advanced_Subject_Click);
            // 
            // Button_Advanced_Email
            // 
            this.Button_Advanced_Email.Location = new System.Drawing.Point(6, 19);
            this.Button_Advanced_Email.Name = "Button_Advanced_Email";
            this.Button_Advanced_Email.Size = new System.Drawing.Size(130, 23);
            this.Button_Advanced_Email.TabIndex = 2;
            this.Button_Advanced_Email.Text = "Click For Email";
            this.Button_Advanced_Email.UseVisualStyleBackColor = true;
            this.Button_Advanced_Email.Click += new System.EventHandler(this.Button_Advanced_Email_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 626);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBox_Data_Input);
            this.Controls.Add(this.Data_DataGridView);
            this.Name = "Form1";
            this.Text = "Riding Tool";
            ((System.ComponentModel.ISupportInitialize)(this.Data_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Horse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Transport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Private;
        private System.Windows.Forms.RichTextBox TextBox_Data_Input;
        private System.Windows.Forms.Button Button_Stable_Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Stable_Subject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_Beginner_Address;
        private System.Windows.Forms.Button Button_Beginner_Subject;
        private System.Windows.Forms.Button Button_Beginner_Email;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button_Improver_Address;
        private System.Windows.Forms.Button Button_Improver_Subject;
        private System.Windows.Forms.Button Button_Improver_Email;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Button_Intermediate_Address;
        private System.Windows.Forms.Button Button_Intermediate_Subject;
        private System.Windows.Forms.Button Button_Intermediate_Email;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Button_Advanced_Address;
        private System.Windows.Forms.Button Button_Advanced_Subject;
        private System.Windows.Forms.Button Button_Advanced_Email;
    }
}

