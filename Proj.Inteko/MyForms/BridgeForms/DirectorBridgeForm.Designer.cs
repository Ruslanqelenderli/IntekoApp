
namespace Proj.Inteko.MyForms.BridgeForms
{
    partial class DirectorBridgeForm
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
            this.btn_Control = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_EmployeeInfo = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Control
            // 
            this.btn_Control.Location = new System.Drawing.Point(12, 47);
            this.btn_Control.Name = "btn_Control";
            this.btn_Control.Size = new System.Drawing.Size(158, 66);
            this.btn_Control.TabIndex = 0;
            this.btn_Control.Text = "Nəzarət";
            this.btn_Control.UseVisualStyleBackColor = true;
            this.btn_Control.Click += new System.EventHandler(this.btn_Control_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(186, 47);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(158, 66);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Müəssisə Əlavə Et";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_AddUpdate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 66);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 66);
            this.button4.TabIndex = 0;
            this.button4.Text = "İşçi Məlumatları";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_Log
            // 
            this.btn_Log.Location = new System.Drawing.Point(350, 47);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(158, 66);
            this.btn_Log.TabIndex = 0;
            this.btn_Log.Text = "Sistemə Nəzarət";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_EmployeeInfo
            // 
            this.btn_EmployeeInfo.Location = new System.Drawing.Point(514, 47);
            this.btn_EmployeeInfo.Name = "btn_EmployeeInfo";
            this.btn_EmployeeInfo.Size = new System.Drawing.Size(158, 66);
            this.btn_EmployeeInfo.TabIndex = 0;
            this.btn_EmployeeInfo.Text = "İşçi Məlumatları";
            this.btn_EmployeeInfo.UseVisualStyleBackColor = true;
            this.btn_EmployeeInfo.Click += new System.EventHandler(this.btn_EmployeeInfo_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(605, 150);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 28);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Çıxış";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // DirectorBridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 190);
            this.Controls.Add(this.btn_EmployeeInfo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectorBridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectorBridgeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Control;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.Button btn_EmployeeInfo;
        private System.Windows.Forms.Button btn_Exit;
    }
}