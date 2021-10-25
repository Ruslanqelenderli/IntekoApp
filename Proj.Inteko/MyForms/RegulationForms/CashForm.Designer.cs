
namespace Proj.Inteko.MyForms.RegulationForms
{
    partial class CashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.dgv_Cash = new System.Windows.Forms.DataGridView();
            this.txb_UpdateName = new System.Windows.Forms.TextBox();
            this.txb_AddName = new System.Windows.Forms.TextBox();
            this.lbl_UpdateName = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_AddName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cash)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(472, 263);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 17;
            this.btn_Exit.Text = "Əvvələ qayıt";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(41, 248);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Düzəliş et";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(232, 182);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 15;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // dgv_Cash
            // 
            this.dgv_Cash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cash.Location = new System.Drawing.Point(232, 25);
            this.dgv_Cash.Name = "dgv_Cash";
            this.dgv_Cash.Size = new System.Drawing.Size(315, 150);
            this.dgv_Cash.TabIndex = 13;
            this.dgv_Cash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cash_CellClick);
            // 
            // txb_UpdateName
            // 
            this.txb_UpdateName.Location = new System.Drawing.Point(29, 204);
            this.txb_UpdateName.Name = "txb_UpdateName";
            this.txb_UpdateName.Size = new System.Drawing.Size(100, 20);
            this.txb_UpdateName.TabIndex = 14;
            // 
            // txb_AddName
            // 
            this.txb_AddName.Location = new System.Drawing.Point(29, 58);
            this.txb_AddName.Name = "txb_AddName";
            this.txb_AddName.Size = new System.Drawing.Size(100, 20);
            this.txb_AddName.TabIndex = 12;
            // 
            // lbl_UpdateName
            // 
            this.lbl_UpdateName.AutoSize = true;
            this.lbl_UpdateName.Location = new System.Drawing.Point(26, 182);
            this.lbl_UpdateName.Name = "lbl_UpdateName";
            this.lbl_UpdateName.Size = new System.Drawing.Size(20, 13);
            this.lbl_UpdateName.TabIndex = 8;
            this.lbl_UpdateName.Text = "Ad";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(41, 101);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Əlavə et";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_AddName
            // 
            this.lbl_AddName.AutoSize = true;
            this.lbl_AddName.Location = new System.Drawing.Point(26, 25);
            this.lbl_AddName.Name = "lbl_AddName";
            this.lbl_AddName.Size = new System.Drawing.Size(20, 13);
            this.lbl_AddName.TabIndex = 10;
            this.lbl_AddName.Text = "Ad";
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(571, 298);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dgv_Cash);
            this.Controls.Add(this.txb_UpdateName);
            this.Controls.Add(this.txb_AddName);
            this.Controls.Add(this.lbl_UpdateName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_AddName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kassalar";
            this.Load += new System.EventHandler(this.CashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.DataGridView dgv_Cash;
        private System.Windows.Forms.TextBox txb_UpdateName;
        private System.Windows.Forms.TextBox txb_AddName;
        private System.Windows.Forms.Label lbl_UpdateName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_AddName;
    }
}