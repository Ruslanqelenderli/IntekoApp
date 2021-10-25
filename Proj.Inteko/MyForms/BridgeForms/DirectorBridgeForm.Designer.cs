
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorBridgeForm));
            this.btn_Control = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Regulations = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_EmployeeInfo = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Control
            // 
            this.btn_Control.Location = new System.Drawing.Point(12, 47);
            this.btn_Control.Name = "btn_Control";
            this.btn_Control.Size = new System.Drawing.Size(158, 66);
            this.btn_Control.TabIndex = 1;
            this.btn_Control.Text = "Nəzarət";
            this.btn_Control.UseVisualStyleBackColor = true;
            this.btn_Control.Click += new System.EventHandler(this.btn_Control_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(176, 47);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(158, 66);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Müəssisə Əlavə Et";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_AddUpdate_Click);
            // 
            // btn_Regulations
            // 
            this.btn_Regulations.Location = new System.Drawing.Point(340, 119);
            this.btn_Regulations.Name = "btn_Regulations";
            this.btn_Regulations.Size = new System.Drawing.Size(158, 66);
            this.btn_Regulations.TabIndex = 6;
            this.btn_Regulations.Text = "Əlavə tənzimləmələr";
            this.btn_Regulations.UseVisualStyleBackColor = true;
            this.btn_Regulations.Click += new System.EventHandler(this.btn_Regulations_Click);
            // 
            // btn_Log
            // 
            this.btn_Log.Location = new System.Drawing.Point(176, 119);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(158, 66);
            this.btn_Log.TabIndex = 3;
            this.btn_Log.Text = "Sistemə Nəzarət";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_EmployeeInfo
            // 
            this.btn_EmployeeInfo.Location = new System.Drawing.Point(12, 119);
            this.btn_EmployeeInfo.Name = "btn_EmployeeInfo";
            this.btn_EmployeeInfo.Size = new System.Drawing.Size(158, 66);
            this.btn_EmployeeInfo.TabIndex = 4;
            this.btn_EmployeeInfo.Text = "İşçi Məlumatları";
            this.btn_EmployeeInfo.UseVisualStyleBackColor = true;
            this.btn_EmployeeInfo.Click += new System.EventHandler(this.btn_EmployeeInfo_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(418, 227);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 28);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Çıxış";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(340, 47);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(158, 66);
            this.btn_Report.TabIndex = 5;
            this.btn_Report.Text = "Hesabat";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // DirectorBridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(521, 275);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_EmployeeInfo);
            this.Controls.Add(this.btn_Regulations);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectorBridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Control;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Regulations;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.Button btn_EmployeeInfo;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Report;
    }
}