
namespace Proj.Inteko.MyForms.RegulationForms
{
    partial class RegulationBridgeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegulationBridgeForm));
            this.btn_Cash = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cash
            // 
            this.btn_Cash.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Cash.Location = new System.Drawing.Point(51, 60);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(113, 48);
            this.btn_Cash.TabIndex = 0;
            this.btn_Cash.Text = "Kassa modelləri";
            this.btn_Cash.UseVisualStyleBackColor = false;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Payment.Location = new System.Drawing.Point(185, 60);
            this.btn_Payment.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(113, 48);
            this.btn_Payment.TabIndex = 0;
            this.btn_Payment.Text = "Ödəniş növləri";
            this.btn_Payment.UseVisualStyleBackColor = false;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Exit.Location = new System.Drawing.Point(277, 146);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(76, 29);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Əvvələ qayıt";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // RegulationBridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 189);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_Cash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegulationBridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tənzimləmələr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_Exit;
    }
}