
namespace Proj.Inteko.MyForms.ProductForms
{
    partial class ControlForm
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
            this.dgv_Control = new System.Windows.Forms.DataGridView();
            this.btn_AllProduct = new System.Windows.Forms.Button();
            this.btn_ItsTime = new System.Windows.Forms.Button();
            this.btn_Sent = new System.Windows.Forms.Button();
            this.btn_Paid = new System.Windows.Forms.Button();
            this.btn_WasSent = new System.Windows.Forms.Button();
            this.btn_WasPaid = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Contact = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exxeləIxracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceləIxracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lbl_Revenue = new System.Windows.Forms.Label();
            this.lbl_RevenuePrice = new System.Windows.Forms.Label();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_DeptProduct = new System.Windows.Forms.Button();
            this.btn_Details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Control)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Control
            // 
            this.dgv_Control.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Control.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Control.Location = new System.Drawing.Point(12, 34);
            this.dgv_Control.Name = "dgv_Control";
            this.dgv_Control.Size = new System.Drawing.Size(1239, 536);
            this.dgv_Control.TabIndex = 0;
            this.dgv_Control.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Control_CellClick);
            // 
            // btn_AllProduct
            // 
            this.btn_AllProduct.Location = new System.Drawing.Point(1257, 34);
            this.btn_AllProduct.Name = "btn_AllProduct";
            this.btn_AllProduct.Size = new System.Drawing.Size(73, 47);
            this.btn_AllProduct.TabIndex = 1;
            this.btn_AllProduct.Text = "Bütün Müəssisələr";
            this.btn_AllProduct.UseVisualStyleBackColor = true;
            this.btn_AllProduct.Click += new System.EventHandler(this.btn_AllProduct_Click);
            // 
            // btn_ItsTime
            // 
            this.btn_ItsTime.Location = new System.Drawing.Point(1257, 87);
            this.btn_ItsTime.Name = "btn_ItsTime";
            this.btn_ItsTime.Size = new System.Drawing.Size(73, 46);
            this.btn_ItsTime.TabIndex = 1;
            this.btn_ItsTime.Text = "Ödəniş Vaxtı";
            this.btn_ItsTime.UseVisualStyleBackColor = true;
            this.btn_ItsTime.Click += new System.EventHandler(this.btn_ItsTime_Click);
            // 
            // btn_Sent
            // 
            this.btn_Sent.Location = new System.Drawing.Point(1257, 139);
            this.btn_Sent.Name = "btn_Sent";
            this.btn_Sent.Size = new System.Drawing.Size(73, 47);
            this.btn_Sent.TabIndex = 1;
            this.btn_Sent.Text = "Qaimə Göndərilən";
            this.btn_Sent.UseVisualStyleBackColor = true;
            this.btn_Sent.Click += new System.EventHandler(this.btn_Sent_Click);
            // 
            // btn_Paid
            // 
            this.btn_Paid.Location = new System.Drawing.Point(1257, 192);
            this.btn_Paid.Name = "btn_Paid";
            this.btn_Paid.Size = new System.Drawing.Size(73, 65);
            this.btn_Paid.TabIndex = 1;
            this.btn_Paid.Text = "Service Haqqı Ödənilənlər";
            this.btn_Paid.UseVisualStyleBackColor = true;
            this.btn_Paid.Click += new System.EventHandler(this.btn_Paid_Click);
            // 
            // btn_WasSent
            // 
            this.btn_WasSent.Location = new System.Drawing.Point(128, 626);
            this.btn_WasSent.Name = "btn_WasSent";
            this.btn_WasSent.Size = new System.Drawing.Size(110, 44);
            this.btn_WasSent.TabIndex = 2;
            this.btn_WasSent.Text = "Göndərildi";
            this.btn_WasSent.UseVisualStyleBackColor = true;
            this.btn_WasSent.Click += new System.EventHandler(this.btn_WasSent_Click);
            // 
            // btn_WasPaid
            // 
            this.btn_WasPaid.Location = new System.Drawing.Point(12, 626);
            this.btn_WasPaid.Name = "btn_WasPaid";
            this.btn_WasPaid.Size = new System.Drawing.Size(110, 44);
            this.btn_WasPaid.TabIndex = 2;
            this.btn_WasPaid.Text = "Ödənildi";
            this.btn_WasPaid.UseVisualStyleBackColor = true;
            this.btn_WasPaid.Click += new System.EventHandler(this.btn_WasPaid_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1210, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "Əvvələ qayıt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Contact
            // 
            this.btn_Contact.Location = new System.Drawing.Point(12, 576);
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.Size = new System.Drawing.Size(110, 44);
            this.btn_Contact.TabIndex = 2;
            this.btn_Contact.Text = "Əlaqə";
            this.btn_Contact.UseVisualStyleBackColor = true;
            this.btn_Contact.Click += new System.EventHandler(this.btn_Contact_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exxeləIxracToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exxeləIxracToolStripMenuItem
            // 
            this.exxeləIxracToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exceləIxracToolStripMenuItem});
            this.exxeləIxracToolStripMenuItem.Name = "exxeləIxracToolStripMenuItem";
            this.exxeləIxracToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.exxeləIxracToolStripMenuItem.Text = "Əməliyyatlar";
            this.exxeləIxracToolStripMenuItem.Click += new System.EventHandler(this.exxeləIxracToolStripMenuItem_Click);
            // 
            // exceləIxracToolStripMenuItem
            // 
            this.exceləIxracToolStripMenuItem.Name = "exceləIxracToolStripMenuItem";
            this.exceləIxracToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exceləIxracToolStripMenuItem.Text = "Excelə ixrac";
            this.exceləIxracToolStripMenuItem.Click += new System.EventHandler(this.exceləIxracToolStripMenuItem_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(933, 590);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(96, 39);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Düzəliş et";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(1035, 590);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(96, 39);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // lbl_Revenue
            // 
            this.lbl_Revenue.AutoSize = true;
            this.lbl_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Revenue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Revenue.Location = new System.Drawing.Point(1257, 321);
            this.lbl_Revenue.Name = "lbl_Revenue";
            this.lbl_Revenue.Size = new System.Drawing.Size(73, 13);
            this.lbl_Revenue.TabIndex = 7;
            this.lbl_Revenue.Text = "Qaimə gəliri";
            this.lbl_Revenue.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_RevenuePrice
            // 
            this.lbl_RevenuePrice.AutoSize = true;
            this.lbl_RevenuePrice.Location = new System.Drawing.Point(1270, 346);
            this.lbl_RevenuePrice.Name = "lbl_RevenuePrice";
            this.lbl_RevenuePrice.Size = new System.Drawing.Size(35, 13);
            this.lbl_RevenuePrice.TabIndex = 7;
            this.lbl_RevenuePrice.Text = "label1";
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Location = new System.Drawing.Point(906, 12);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(123, 20);
            this.dt_StartDate.TabIndex = 8;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Location = new System.Drawing.Point(1035, 12);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(123, 20);
            this.dt_EndDate.TabIndex = 8;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1164, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_DeptProduct
            // 
            this.btn_DeptProduct.Location = new System.Drawing.Point(1257, 263);
            this.btn_DeptProduct.Name = "btn_DeptProduct";
            this.btn_DeptProduct.Size = new System.Drawing.Size(75, 55);
            this.btn_DeptProduct.TabIndex = 10;
            this.btn_DeptProduct.Text = "İlkin ödəniş tam ödənilməyənlər";
            this.btn_DeptProduct.UseVisualStyleBackColor = true;
            this.btn_DeptProduct.Click += new System.EventHandler(this.btn_DeptProduct_Click);
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(128, 576);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(110, 44);
            this.btn_Details.TabIndex = 11;
            this.btn_Details.Text = "Ətraflı";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 745);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.btn_DeptProduct);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.lbl_RevenuePrice);
            this.Controls.Add(this.lbl_Revenue);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Contact);
            this.Controls.Add(this.btn_WasPaid);
            this.Controls.Add(this.btn_WasSent);
            this.Controls.Add(this.btn_Paid);
            this.Controls.Add(this.btn_Sent);
            this.Controls.Add(this.btn_ItsTime);
            this.Controls.Add(this.btn_AllProduct);
            this.Controls.Add(this.dgv_Control);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nəzarət";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Control)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Control;
        private System.Windows.Forms.Button btn_AllProduct;
        private System.Windows.Forms.Button btn_ItsTime;
        private System.Windows.Forms.Button btn_Sent;
        private System.Windows.Forms.Button btn_Paid;
        private System.Windows.Forms.Button btn_WasSent;
        private System.Windows.Forms.Button btn_WasPaid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Contact;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exxeləIxracToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceləIxracToolStripMenuItem;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label lbl_Revenue;
        private System.Windows.Forms.Label lbl_RevenuePrice;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_DeptProduct;
        private System.Windows.Forms.Button btn_Details;
    }
}