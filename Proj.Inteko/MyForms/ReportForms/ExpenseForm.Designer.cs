
namespace Proj.Inteko.MyForms.ReportForms
{
    partial class ExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
            this.dgv_Expenses = new System.Windows.Forms.DataGridView();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxb_Info = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_CreateDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Expenses
            // 
            this.dgv_Expenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expenses.Location = new System.Drawing.Point(217, 31);
            this.dgv_Expenses.Name = "dgv_Expenses";
            this.dgv_Expenses.Size = new System.Drawing.Size(875, 360);
            this.dgv_Expenses.TabIndex = 0;
            this.dgv_Expenses.TabStop = false;
            this.dgv_Expenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Expenses_CellClick);
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(23, 31);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(27, 13);
            this.lbl_Type.TabIndex = 1;
            this.lbl_Type.Text = "Növ";
            // 
            // txb_Price
            // 
            this.txb_Price.Location = new System.Drawing.Point(26, 97);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(121, 20);
            this.txb_Price.TabIndex = 2;
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(26, 47);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(121, 21);
            this.cmb_Type.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qiymət";
            // 
            // rtxb_Info
            // 
            this.rtxb_Info.Location = new System.Drawing.Point(26, 147);
            this.rtxb_Info.Name = "rtxb_Info";
            this.rtxb_Info.Size = new System.Drawing.Size(121, 96);
            this.rtxb_Info.TabIndex = 3;
            this.rtxb_Info.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Məlumat";
            // 
            // dt_CreateDate
            // 
            this.dt_CreateDate.Location = new System.Drawing.Point(26, 283);
            this.dt_CreateDate.Name = "dt_CreateDate";
            this.dt_CreateDate.Size = new System.Drawing.Size(121, 20);
            this.dt_CreateDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarix";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(46, 328);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Əlavə et";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Location = new System.Drawing.Point(217, 398);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(139, 20);
            this.dt_StartDate.TabIndex = 6;
            this.dt_StartDate.Value = new System.DateTime(2021, 10, 1, 12, 0, 0, 0);
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Location = new System.Drawing.Point(362, 398);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(139, 20);
            this.dt_EndDate.TabIndex = 7;
            this.dt_EndDate.Value = new System.DateTime(2021, 10, 1, 12, 0, 0, 0);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(507, 397);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 21);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Axtar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(936, 398);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Düzəliş et";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(1017, 398);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 14;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(998, 535);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(105, 26);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Əvvələ qayıt";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(948, 2);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(144, 23);
            this.btn_GetAll.TabIndex = 16;
            this.btn_GetAll.Text = "Bütün Xərclər";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1115, 573);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_CreateDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxb_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.txb_Price);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.dgv_Expenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xərclər";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpenseForm_FormClosed);
            this.Load += new System.EventHandler(this.ExpenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Expenses;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxb_Info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_CreateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_GetAll;
    }
}