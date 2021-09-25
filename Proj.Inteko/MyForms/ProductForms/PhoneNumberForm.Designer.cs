
namespace Proj.Inteko.MyForms.ProductForms
{
    partial class PhoneNumberForm
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
            this.dgv_PhoneList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhoneList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhoneList
            // 
            this.dgv_PhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhoneList.Location = new System.Drawing.Point(0, -2);
            this.dgv_PhoneList.Name = "dgv_PhoneList";
            this.dgv_PhoneList.Size = new System.Drawing.Size(372, 342);
            this.dgv_PhoneList.TabIndex = 0;
            this.dgv_PhoneList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhoneList_CellContentClick);
            // 
            // PhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 337);
            this.Controls.Add(this.dgv_PhoneList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PhoneNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneNumberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhoneList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhoneList;
    }
}