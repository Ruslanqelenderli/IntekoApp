
namespace Proj.Inteko.MyForms.ReportForms
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.btn_ExpenceType = new System.Windows.Forms.Button();
            this.btn_Expense = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ExpenceType
            // 
            this.btn_ExpenceType.Location = new System.Drawing.Point(108, 103);
            this.btn_ExpenceType.Name = "btn_ExpenceType";
            this.btn_ExpenceType.Size = new System.Drawing.Size(170, 81);
            this.btn_ExpenceType.TabIndex = 1;
            this.btn_ExpenceType.Text = "Xərcin növü";
            this.btn_ExpenceType.UseVisualStyleBackColor = true;
            this.btn_ExpenceType.Click += new System.EventHandler(this.btn_ExpenceType_Click);
            // 
            // btn_Expense
            // 
            this.btn_Expense.Location = new System.Drawing.Point(352, 103);
            this.btn_Expense.Name = "btn_Expense";
            this.btn_Expense.Size = new System.Drawing.Size(170, 81);
            this.btn_Expense.TabIndex = 2;
            this.btn_Expense.Text = "Xərclər";
            this.btn_Expense.UseVisualStyleBackColor = true;
            this.btn_Expense.Click += new System.EventHandler(this.btn_Expense_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(441, 250);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 34);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Əvvələ qayıt";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 308);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Expense);
            this.Controls.Add(this.btn_ExpenceType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesabat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ExpenceType;
        private System.Windows.Forms.Button btn_Expense;
        private System.Windows.Forms.Button btn_Exit;
    }
}