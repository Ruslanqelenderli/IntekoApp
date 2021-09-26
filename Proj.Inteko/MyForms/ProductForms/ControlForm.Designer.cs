
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
            this.rdb_InitialPayment = new System.Windows.Forms.RadioButton();
            this.btn_Approval = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exxeləIxracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceləIxracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Control)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Control
            // 
            this.dgv_Control.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Control.Location = new System.Drawing.Point(12, 34);
            this.dgv_Control.Name = "dgv_Control";
            this.dgv_Control.Size = new System.Drawing.Size(1181, 536);
            this.dgv_Control.TabIndex = 0;
            this.dgv_Control.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Control_CellClick);
            // 
            // btn_AllProduct
            // 
            this.btn_AllProduct.Location = new System.Drawing.Point(1210, 43);
            this.btn_AllProduct.Name = "btn_AllProduct";
            this.btn_AllProduct.Size = new System.Drawing.Size(120, 71);
            this.btn_AllProduct.TabIndex = 1;
            this.btn_AllProduct.Text = "Bütün Müəssisələr";
            this.btn_AllProduct.UseVisualStyleBackColor = true;
            this.btn_AllProduct.Click += new System.EventHandler(this.btn_AllProduct_Click);
            // 
            // btn_ItsTime
            // 
            this.btn_ItsTime.Location = new System.Drawing.Point(1210, 120);
            this.btn_ItsTime.Name = "btn_ItsTime";
            this.btn_ItsTime.Size = new System.Drawing.Size(120, 71);
            this.btn_ItsTime.TabIndex = 1;
            this.btn_ItsTime.Text = "Ödəniş Vaxtı";
            this.btn_ItsTime.UseVisualStyleBackColor = true;
            this.btn_ItsTime.Click += new System.EventHandler(this.btn_ItsTime_Click);
            // 
            // btn_Sent
            // 
            this.btn_Sent.Location = new System.Drawing.Point(1210, 197);
            this.btn_Sent.Name = "btn_Sent";
            this.btn_Sent.Size = new System.Drawing.Size(120, 71);
            this.btn_Sent.TabIndex = 1;
            this.btn_Sent.Text = "Göndərilənlər";
            this.btn_Sent.UseVisualStyleBackColor = true;
            this.btn_Sent.Click += new System.EventHandler(this.btn_Sent_Click);
            // 
            // btn_Paid
            // 
            this.btn_Paid.Location = new System.Drawing.Point(1210, 274);
            this.btn_Paid.Name = "btn_Paid";
            this.btn_Paid.Size = new System.Drawing.Size(120, 71);
            this.btn_Paid.TabIndex = 1;
            this.btn_Paid.Text = "Ödənilənlər";
            this.btn_Paid.UseVisualStyleBackColor = true;
            this.btn_Paid.Click += new System.EventHandler(this.btn_Paid_Click);
            // 
            // btn_WasSent
            // 
            this.btn_WasSent.Location = new System.Drawing.Point(173, 576);
            this.btn_WasSent.Name = "btn_WasSent";
            this.btn_WasSent.Size = new System.Drawing.Size(155, 66);
            this.btn_WasSent.TabIndex = 2;
            this.btn_WasSent.Text = "Göndərildi";
            this.btn_WasSent.UseVisualStyleBackColor = true;
            this.btn_WasSent.Click += new System.EventHandler(this.btn_WasSent_Click);
            // 
            // btn_WasPaid
            // 
            this.btn_WasPaid.Location = new System.Drawing.Point(173, 576);
            this.btn_WasPaid.Name = "btn_WasPaid";
            this.btn_WasPaid.Size = new System.Drawing.Size(155, 66);
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
            this.btn_Contact.Size = new System.Drawing.Size(155, 66);
            this.btn_Contact.TabIndex = 2;
            this.btn_Contact.Text = "Əlaqə";
            this.btn_Contact.UseVisualStyleBackColor = true;
            this.btn_Contact.Click += new System.EventHandler(this.btn_Contact_Click);
            // 
            // rdb_InitialPayment
            // 
            this.rdb_InitialPayment.AutoSize = true;
            this.rdb_InitialPayment.Location = new System.Drawing.Point(1222, 455);
            this.rdb_InitialPayment.Name = "rdb_InitialPayment";
            this.rdb_InitialPayment.Size = new System.Drawing.Size(85, 17);
            this.rdb_InitialPayment.TabIndex = 3;
            this.rdb_InitialPayment.TabStop = true;
            this.rdb_InitialPayment.Text = "Ödəniş edildi";
            this.rdb_InitialPayment.UseVisualStyleBackColor = true;
            // 
            // btn_Approval
            // 
            this.btn_Approval.Location = new System.Drawing.Point(1210, 478);
            this.btn_Approval.Name = "btn_Approval";
            this.btn_Approval.Size = new System.Drawing.Size(109, 23);
            this.btn_Approval.TabIndex = 4;
            this.btn_Approval.Text = "Təstiqlə";
            this.btn_Approval.UseVisualStyleBackColor = true;
            this.btn_Approval.Click += new System.EventHandler(this.btn_Approval_Click);
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
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 645);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Approval);
            this.Controls.Add(this.rdb_InitialPayment);
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
            this.Text = "ControlForm";
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
        private System.Windows.Forms.RadioButton rdb_InitialPayment;
        private System.Windows.Forms.Button btn_Approval;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exxeləIxracToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceləIxracToolStripMenuItem;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
    }
}