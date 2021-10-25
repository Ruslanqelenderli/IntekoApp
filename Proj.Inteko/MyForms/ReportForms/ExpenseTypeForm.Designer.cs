
namespace Proj.Inteko.MyForms.ReportForms
{
    partial class ExpenseTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.dgv_ExpenseTypes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_UpdateType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpenseTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Növ";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(41, 113);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Əlavə et";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(29, 70);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Name.TabIndex = 2;
            // 
            // dgv_ExpenseTypes
            // 
            this.dgv_ExpenseTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ExpenseTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ExpenseTypes.Location = new System.Drawing.Point(232, 37);
            this.dgv_ExpenseTypes.Name = "dgv_ExpenseTypes";
            this.dgv_ExpenseTypes.Size = new System.Drawing.Size(263, 150);
            this.dgv_ExpenseTypes.TabIndex = 3;
            this.dgv_ExpenseTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ExpenseTypes_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Növ";
            // 
            // txb_UpdateType
            // 
            this.txb_UpdateType.Location = new System.Drawing.Point(29, 216);
            this.txb_UpdateType.Name = "txb_UpdateType";
            this.txb_UpdateType.Size = new System.Drawing.Size(100, 20);
            this.txb_UpdateType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Növ";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(232, 194);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(41, 260);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Düzəliş et";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(513, 276);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Əvvələ qayıt";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ExpenseTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 311);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dgv_ExpenseTypes);
            this.Controls.Add(this.txb_UpdateType);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExpenseTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xərclərin növləri";
            this.Load += new System.EventHandler(this.ExpenseTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpenseTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.DataGridView dgv_ExpenseTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_UpdateType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Exit;
    }
}