
namespace W13_Praktikum_Catherine_Lim_0706022110002
{
    partial class FormPemain
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
            this.button_First = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_PlayerID = new System.Windows.Forms.TextBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_PlayerName = new System.Windows.Forms.TextBox();
            this.comboBox_Team = new System.Windows.Forms.ComboBox();
            this.numericUpDown_TeamNumber = new System.Windows.Forms.NumericUpDown();
            this.label_NotAvailable = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Nationality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(112, 42);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(66, 50);
            this.button_First.TabIndex = 0;
            this.button_First.Text = "<<";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(112, 354);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(147, 30);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Prev
            // 
            this.button_Prev.Location = new System.Drawing.Point(193, 42);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(66, 50);
            this.button_Prev.TabIndex = 0;
            this.button_Prev.Text = "<";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(265, 42);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(66, 50);
            this.button_Next.TabIndex = 0;
            this.button_Next.Text = ">";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(347, 42);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(66, 50);
            this.button_Last.TabIndex = 0;
            this.button_Last.Text = ">>";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Team Number";
            // 
            // textBox_PlayerID
            // 
            this.textBox_PlayerID.Location = new System.Drawing.Point(202, 119);
            this.textBox_PlayerID.Name = "textBox_PlayerID";
            this.textBox_PlayerID.Size = new System.Drawing.Size(121, 26);
            this.textBox_PlayerID.TabIndex = 3;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(202, 193);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(266, 26);
            this.dateTimePicker_BirthDate.TabIndex = 4;
            // 
            // textBox_PlayerName
            // 
            this.textBox_PlayerName.Location = new System.Drawing.Point(202, 157);
            this.textBox_PlayerName.Name = "textBox_PlayerName";
            this.textBox_PlayerName.Size = new System.Drawing.Size(266, 26);
            this.textBox_PlayerName.TabIndex = 5;
            // 
            // comboBox_Team
            // 
            this.comboBox_Team.FormattingEnabled = true;
            this.comboBox_Team.Location = new System.Drawing.Point(202, 262);
            this.comboBox_Team.Name = "comboBox_Team";
            this.comboBox_Team.Size = new System.Drawing.Size(172, 28);
            this.comboBox_Team.TabIndex = 7;
            this.comboBox_Team.SelectedIndexChanged += new System.EventHandler(this.comboBox_Team_SelectedIndexChanged);
            // 
            // numericUpDown_TeamNumber
            // 
            this.numericUpDown_TeamNumber.Location = new System.Drawing.Point(202, 298);
            this.numericUpDown_TeamNumber.Name = "numericUpDown_TeamNumber";
            this.numericUpDown_TeamNumber.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown_TeamNumber.TabIndex = 8;
            this.numericUpDown_TeamNumber.ValueChanged += new System.EventHandler(this.numericUpDown_TeamNumber_ValueChanged);
            // 
            // label_NotAvailable
            // 
            this.label_NotAvailable.AutoSize = true;
            this.label_NotAvailable.Location = new System.Drawing.Point(345, 300);
            this.label_NotAvailable.Name = "label_NotAvailable";
            this.label_NotAvailable.Size = new System.Drawing.Size(29, 20);
            this.label_NotAvailable.TabIndex = 9;
            this.label_NotAvailable.Text = "[...]";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(265, 354);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(148, 30);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_Nationality
            // 
            this.comboBox_Nationality.FormattingEnabled = true;
            this.comboBox_Nationality.Location = new System.Drawing.Point(202, 227);
            this.comboBox_Nationality.Name = "comboBox_Nationality";
            this.comboBox_Nationality.Size = new System.Drawing.Size(172, 28);
            this.comboBox_Nationality.TabIndex = 10;
            this.comboBox_Nationality.SelectedIndexChanged += new System.EventHandler(this.comboBox_Nationality_SelectedIndexChanged);
            // 
            // FormPemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 419);
            this.Controls.Add(this.comboBox_Nationality);
            this.Controls.Add(this.label_NotAvailable);
            this.Controls.Add(this.numericUpDown_TeamNumber);
            this.Controls.Add(this.comboBox_Team);
            this.Controls.Add(this.textBox_PlayerName);
            this.Controls.Add(this.dateTimePicker_BirthDate);
            this.Controls.Add(this.textBox_PlayerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Prev);
            this.Controls.Add(this.button_First);
            this.Name = "FormPemain";
            this.Text = "Form Pemain";
            this.Load += new System.EventHandler(this.FormPemain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_PlayerID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.TextBox textBox_PlayerName;
        private System.Windows.Forms.ComboBox comboBox_Team;
        private System.Windows.Forms.NumericUpDown numericUpDown_TeamNumber;
        private System.Windows.Forms.Label label_NotAvailable;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_Nationality;
    }
}

