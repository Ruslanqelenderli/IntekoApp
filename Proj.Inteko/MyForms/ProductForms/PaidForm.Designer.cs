
namespace Proj.Inteko.MyForms.ProductForms
{
    partial class PaidForm
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
            this.lbl_PriceDeptHeader = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.btn_AddPriceDebt = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_DebtQuantity = new System.Windows.Forms.Label();
            this.brn_Exit = new System.Windows.Forms.Button();
            this.dgv_Payments = new System.Windows.Forms.DataGridView();
            this.btn_Paid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PriceDeptHeader
            // 
            this.lbl_PriceDeptHeader.AutoSize = true;
            this.lbl_PriceDeptHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PriceDeptHeader.Location = new System.Drawing.Point(411, 38);
            this.lbl_PriceDeptHeader.Name = "lbl_PriceDeptHeader";
            this.lbl_PriceDeptHeader.Size = new System.Drawing.Size(86, 13);
            this.lbl_PriceDeptHeader.TabIndex = 0;
            this.lbl_PriceDeptHeader.Text = "Yazılma borcu";
            // 
            // txb_Price
            // 
            this.txb_Price.Location = new System.Drawing.Point(414, 96);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(100, 20);
            this.txb_Price.TabIndex = 1;
            // 
            // btn_AddPriceDebt
            // 
            this.btn_AddPriceDebt.Location = new System.Drawing.Point(423, 132);
            this.btn_AddPriceDebt.Name = "btn_AddPriceDebt";
            this.btn_AddPriceDebt.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPriceDebt.TabIndex = 2;
            this.btn_AddPriceDebt.Text = "Daxil et";
            this.btn_AddPriceDebt.UseVisualStyleBackColor = true;
            this.btn_AddPriceDebt.Click += new System.EventHandler(this.btn_AddPriceDebt_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(407, 71);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(86, 13);
            this.lbl_Price.TabIndex = 0;
            this.lbl_Price.Text = "Ödənilən məbləğ";
            // 
            // lbl_DebtQuantity
            // 
            this.lbl_DebtQuantity.AutoSize = true;
            this.lbl_DebtQuantity.Location = new System.Drawing.Point(503, 38);
            this.lbl_DebtQuantity.Name = "lbl_DebtQuantity";
            this.lbl_DebtQuantity.Size = new System.Drawing.Size(35, 13);
            this.lbl_DebtQuantity.TabIndex = 3;
            this.lbl_DebtQuantity.Text = "label1";
            // 
            // brn_Exit
            // 
            this.brn_Exit.Location = new System.Drawing.Point(506, 227);
            this.brn_Exit.Name = "brn_Exit";
            this.brn_Exit.Size = new System.Drawing.Size(75, 23);
            this.brn_Exit.TabIndex = 8;
            this.brn_Exit.Text = "Əvvələ qayıt";
            this.brn_Exit.UseVisualStyleBackColor = true;
            this.brn_Exit.Click += new System.EventHandler(this.brn_Exit_Click);
            // 
            // dgv_Payments
            // 
            this.dgv_Payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payments.Location = new System.Drawing.Point(13, 13);
            this.dgv_Payments.Name = "dgv_Payments";
            this.dgv_Payments.Size = new System.Drawing.Size(243, 170);
            this.dgv_Payments.TabIndex = 9;
            // 
            // btn_Paid
            // 
            this.btn_Paid.Location = new System.Drawing.Point(102, 190);
            this.btn_Paid.Name = "btn_Paid";
            this.btn_Paid.Size = new System.Drawing.Size(75, 23);
            this.btn_Paid.TabIndex = 10;
            this.btn_Paid.Text = "Ödənildi";
            this.btn_Paid.UseVisualStyleBackColor = true;
            this.btn_Paid.Click += new System.EventHandler(this.btn_Paid_Click);
            // 
            // PaidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 262);
            this.Controls.Add(this.btn_Paid);
            this.Controls.Add(this.dgv_Payments);
            this.Controls.Add(this.brn_Exit);
            this.Controls.Add(this.lbl_DebtQuantity);
            this.Controls.Add(this.btn_AddPriceDebt);
            this.Controls.Add(this.txb_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_PriceDeptHeader);
            this.Name = "PaidForm";
            this.Text = "Ödəniş";
            this.Load += new System.EventHandler(this.PaidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PriceDeptHeader;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Button btn_AddPriceDebt;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_DebtQuantity;
        private System.Windows.Forms.Button brn_Exit;
        private System.Windows.Forms.DataGridView dgv_Payments;
        private System.Windows.Forms.Button btn_Paid;
    }
}