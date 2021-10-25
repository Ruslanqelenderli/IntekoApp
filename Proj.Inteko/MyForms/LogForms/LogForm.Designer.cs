
namespace Proj.Inteko.MyForms.LogForms
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.dgv_AllLog = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AllLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AllLog
            // 
            this.dgv_AllLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AllLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllLog.Location = new System.Drawing.Point(12, 12);
            this.dgv_AllLog.Name = "dgv_AllLog";
            this.dgv_AllLog.Size = new System.Drawing.Size(1214, 675);
            this.dgv_AllLog.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Ivory;
            this.btn_Back.Location = new System.Drawing.Point(1051, 693);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(267, 44);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Əvvələ qayıt";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Location = new System.Drawing.Point(12, 703);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dt_StartDate.TabIndex = 2;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Location = new System.Drawing.Point(218, 703);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dt_EndDate.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(439, 703);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 20);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Axtar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_AllLog
            // 
            this.btn_AllLog.Location = new System.Drawing.Point(1245, 12);
            this.btn_AllLog.Name = "btn_AllLog";
            this.btn_AllLog.Size = new System.Drawing.Size(87, 54);
            this.btn_AllLog.TabIndex = 4;
            this.btn_AllLog.Text = "Bütün qeydlər";
            this.btn_AllLog.UseVisualStyleBackColor = true;
            this.btn_AllLog.Click += new System.EventHandler(this.btn_AllLog_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.Controls.Add(this.btn_AllLog);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_AllLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemə nəzarət";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogForm_FormClosed);
            this.Load += new System.EventHandler(this.LogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AllLog;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_AllLog;
    }
}