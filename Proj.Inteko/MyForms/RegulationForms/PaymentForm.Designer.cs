
namespace Proj.Inteko.MyForms.RegulationForms
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.dgv_Payment = new System.Windows.Forms.DataGridView();
            this.txb_UpdateName = new System.Windows.Forms.TextBox();
            this.txb_AddName = new System.Windows.Forms.TextBox();
            this.lbl_UpdateName = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_AddName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(468, 265);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.Text = "Əvvələ qayıt";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(37, 250);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Düzəliş et";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(228, 184);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 24;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // dgv_Payment
            // 
            this.dgv_Payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payment.Location = new System.Drawing.Point(228, 27);
            this.dgv_Payment.Name = "dgv_Payment";
            this.dgv_Payment.Size = new System.Drawing.Size(315, 150);
            this.dgv_Payment.TabIndex = 22;
            this.dgv_Payment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Payment_CellClick);
            // 
            // txb_UpdateName
            // 
            this.txb_UpdateName.Location = new System.Drawing.Point(25, 206);
            this.txb_UpdateName.Name = "txb_UpdateName";
            this.txb_UpdateName.Size = new System.Drawing.Size(100, 20);
            this.txb_UpdateName.TabIndex = 23;
            // 
            // txb_AddName
            // 
            this.txb_AddName.Location = new System.Drawing.Point(25, 60);
            this.txb_AddName.Name = "txb_AddName";
            this.txb_AddName.Size = new System.Drawing.Size(100, 20);
            this.txb_AddName.TabIndex = 21;
            // 
            // lbl_UpdateName
            // 
            this.lbl_UpdateName.AutoSize = true;
            this.lbl_UpdateName.Location = new System.Drawing.Point(22, 184);
            this.lbl_UpdateName.Name = "lbl_UpdateName";
            this.lbl_UpdateName.Size = new System.Drawing.Size(20, 13);
            this.lbl_UpdateName.TabIndex = 18;
            this.lbl_UpdateName.Text = "Ad";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(37, 103);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Əlavə et";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_AddName
            // 
            this.lbl_AddName.AutoSize = true;
            this.lbl_AddName.Location = new System.Drawing.Point(22, 27);
            this.lbl_AddName.Name = "lbl_AddName";
            this.lbl_AddName.Size = new System.Drawing.Size(20, 13);
            this.lbl_AddName.TabIndex = 19;
            this.lbl_AddName.Text = "Ad";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 297);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dgv_Payment);
            this.Controls.Add(this.txb_UpdateName);
            this.Controls.Add(this.txb_AddName);
            this.Controls.Add(this.lbl_UpdateName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_AddName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödəniş növü";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.DataGridView dgv_Payment;
        private System.Windows.Forms.TextBox txb_UpdateName;
        private System.Windows.Forms.TextBox txb_AddName;
        private System.Windows.Forms.Label lbl_UpdateName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_AddName;
    }
}