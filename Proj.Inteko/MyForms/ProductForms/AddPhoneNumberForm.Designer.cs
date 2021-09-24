
namespace Proj.Inteko.MyForms.ProductForms
{
    partial class AddPhoneNumberForm
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
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.btn_AddNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(135, 50);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Name.TabIndex = 1;
            // 
            // btn_AddNumber
            // 
            this.btn_AddNumber.Location = new System.Drawing.Point(150, 243);
            this.btn_AddNumber.Name = "btn_AddNumber";
            this.btn_AddNumber.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNumber.TabIndex = 2;
            this.btn_AddNumber.Text = "Əlavə et";
            this.btn_AddNumber.UseVisualStyleBackColor = true;
            this.btn_AddNumber.Click += new System.EventHandler(this.btn_AddNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // txb_Surname
            // 
            this.txb_Surname.Location = new System.Drawing.Point(135, 100);
            this.txb_Surname.Name = "txb_Surname";
            this.txb_Surname.Size = new System.Drawing.Size(100, 20);
            this.txb_Surname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vəzifə";
            // 
            // txb_Position
            // 
            this.txb_Position.Location = new System.Drawing.Point(135, 151);
            this.txb_Position.Name = "txb_Position";
            this.txb_Position.Size = new System.Drawing.Size(100, 20);
            this.txb_Position.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nömrə";
            // 
            // txb_Number
            // 
            this.txb_Number.Location = new System.Drawing.Point(135, 205);
            this.txb_Number.Name = "txb_Number";
            this.txb_Number.Size = new System.Drawing.Size(100, 20);
            this.txb_Number.TabIndex = 1;
            // 
            // AddPhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 400);
            this.Controls.Add(this.btn_AddNumber);
            this.Controls.Add(this.txb_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPhoneNumberForm";
            this.Text = "AddPhoneNumberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Button btn_AddNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Number;
    }
}