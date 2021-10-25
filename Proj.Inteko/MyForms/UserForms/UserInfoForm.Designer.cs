
namespace Proj.Inteko.MyForms.UserForms
{
    partial class UserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_UserList
            // 
            this.dgv_UserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserList.Location = new System.Drawing.Point(12, 2);
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.Size = new System.Drawing.Size(506, 399);
            this.dgv_UserList.TabIndex = 0;
            this.dgv_UserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UserList_CellClick);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(12, 407);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(114, 30);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(403, 407);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 30);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Əvvələ qayıt";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(529, 445);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dgv_UserList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstifadəçilər";
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_UserList;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Exit;
    }
}