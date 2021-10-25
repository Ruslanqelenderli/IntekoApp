
namespace Proj.Inteko.MyForms.ProductForms
{
    partial class AddProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.dgv_AllProduct = new System.Windows.Forms.DataGridView();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.txb_CompanyName = new System.Windows.Forms.TextBox();
            this.lbl_VoenPassword = new System.Windows.Forms.Label();
            this.txb_VoenPassword = new System.Windows.Forms.TextBox();
            this.lbl_District = new System.Windows.Forms.Label();
            this.txb_District = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.lbl_ApproximateLocation = new System.Windows.Forms.Label();
            this.txb_ApproximateLocation = new System.Windows.Forms.TextBox();
            this.lbl_CashireModel = new System.Windows.Forms.Label();
            this.lbl_EmployeeWhoSells = new System.Windows.Forms.Label();
            this.txb_EmployeeWhoSells = new System.Windows.Forms.TextBox();
            this.lbl_TypeOfPayment = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.lbl_ServicePrice = new System.Windows.Forms.Label();
            this.txb_ServicePrice = new System.Windows.Forms.TextBox();
            this.lbl_EmployeeWhoConnects = new System.Windows.Forms.Label();
            this.txb_EmployeeWhoConnects = new System.Windows.Forms.TextBox();
            this.lbl_SellesPayment = new System.Windows.Forms.Label();
            this.txb_SellesPayment = new System.Windows.Forms.TextBox();
            this.lbl_WrittenByOrxan = new System.Windows.Forms.Label();
            this.txb_WrittenByOrxan = new System.Windows.Forms.TextBox();
            this.dt_RegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_RegistrationDate = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Phone = new System.Windows.Forms.Button();
            this.rb_Paid = new System.Windows.Forms.RadioButton();
            this.lbl_InitialPayment = new System.Windows.Forms.Label();
            this.rb_NotPaid = new System.Windows.Forms.RadioButton();
            this.rtxb_Info = new System.Windows.Forms.RichTextBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_OfficeMncPercent = new System.Windows.Forms.Label();
            this.txb_OfficeMncPercent = new System.Windows.Forms.TextBox();
            this.cmb_TypeOfPayment = new System.Windows.Forms.ComboBox();
            this.btn_AddNewCompany = new System.Windows.Forms.Button();
            this.cmb_CashireModel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(60, 35);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(25, 17);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Ad";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(63, 64);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(123, 20);
            this.txb_Name.TabIndex = 1;
            // 
            // dgv_AllProduct
            // 
            this.dgv_AllProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AllProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AllProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_AllProduct.Location = new System.Drawing.Point(630, 46);
            this.dgv_AllProduct.Name = "dgv_AllProduct";
            this.dgv_AllProduct.Size = new System.Drawing.Size(724, 436);
            this.dgv_AllProduct.TabIndex = 2;
            this.dgv_AllProduct.TabStop = false;
            this.dgv_AllProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllProduct_CellClick);
            this.dgv_AllProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllProduct_CellContentClick);
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.Location = new System.Drawing.Point(60, 112);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(77, 17);
            this.lbl_CompanyName.TabIndex = 0;
            this.lbl_CompanyName.Text = "Obyekt Adı";
            // 
            // txb_CompanyName
            // 
            this.txb_CompanyName.Location = new System.Drawing.Point(63, 141);
            this.txb_CompanyName.Name = "txb_CompanyName";
            this.txb_CompanyName.Size = new System.Drawing.Size(123, 20);
            this.txb_CompanyName.TabIndex = 3;
            // 
            // lbl_VoenPassword
            // 
            this.lbl_VoenPassword.AutoSize = true;
            this.lbl_VoenPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VoenPassword.Location = new System.Drawing.Point(60, 176);
            this.lbl_VoenPassword.Name = "lbl_VoenPassword";
            this.lbl_VoenPassword.Size = new System.Drawing.Size(71, 17);
            this.lbl_VoenPassword.TabIndex = 0;
            this.lbl_VoenPassword.Text = "Vöen-Kod";
            // 
            // txb_VoenPassword
            // 
            this.txb_VoenPassword.Location = new System.Drawing.Point(63, 205);
            this.txb_VoenPassword.Name = "txb_VoenPassword";
            this.txb_VoenPassword.Size = new System.Drawing.Size(123, 20);
            this.txb_VoenPassword.TabIndex = 4;
            // 
            // lbl_District
            // 
            this.lbl_District.AutoSize = true;
            this.lbl_District.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_District.Location = new System.Drawing.Point(60, 247);
            this.lbl_District.Name = "lbl_District";
            this.lbl_District.Size = new System.Drawing.Size(49, 17);
            this.lbl_District.TabIndex = 0;
            this.lbl_District.Text = "Rayon";
            // 
            // txb_District
            // 
            this.txb_District.Location = new System.Drawing.Point(63, 276);
            this.txb_District.Name = "txb_District";
            this.txb_District.Size = new System.Drawing.Size(123, 20);
            this.txb_District.TabIndex = 5;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(60, 319);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(49, 17);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Ünvan";
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(63, 348);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(123, 20);
            this.txb_Address.TabIndex = 6;
            // 
            // lbl_ApproximateLocation
            // 
            this.lbl_ApproximateLocation.AutoSize = true;
            this.lbl_ApproximateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApproximateLocation.Location = new System.Drawing.Point(250, 35);
            this.lbl_ApproximateLocation.Name = "lbl_ApproximateLocation";
            this.lbl_ApproximateLocation.Size = new System.Drawing.Size(115, 17);
            this.lbl_ApproximateLocation.TabIndex = 0;
            this.lbl_ApproximateLocation.Text = "Təqribi Yerləşmə";
            // 
            // txb_ApproximateLocation
            // 
            this.txb_ApproximateLocation.Location = new System.Drawing.Point(253, 64);
            this.txb_ApproximateLocation.Name = "txb_ApproximateLocation";
            this.txb_ApproximateLocation.Size = new System.Drawing.Size(123, 20);
            this.txb_ApproximateLocation.TabIndex = 7;
            // 
            // lbl_CashireModel
            // 
            this.lbl_CashireModel.AutoSize = true;
            this.lbl_CashireModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CashireModel.Location = new System.Drawing.Point(250, 105);
            this.lbl_CashireModel.Name = "lbl_CashireModel";
            this.lbl_CashireModel.Size = new System.Drawing.Size(92, 17);
            this.lbl_CashireModel.TabIndex = 0;
            this.lbl_CashireModel.Text = "Kassa Modeli";
            // 
            // lbl_EmployeeWhoSells
            // 
            this.lbl_EmployeeWhoSells.AutoSize = true;
            this.lbl_EmployeeWhoSells.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeWhoSells.Location = new System.Drawing.Point(250, 240);
            this.lbl_EmployeeWhoSells.Name = "lbl_EmployeeWhoSells";
            this.lbl_EmployeeWhoSells.Size = new System.Drawing.Size(69, 17);
            this.lbl_EmployeeWhoSells.TabIndex = 0;
            this.lbl_EmployeeWhoSells.Text = "Satan İşçi";
            // 
            // txb_EmployeeWhoSells
            // 
            this.txb_EmployeeWhoSells.Location = new System.Drawing.Point(253, 269);
            this.txb_EmployeeWhoSells.Name = "txb_EmployeeWhoSells";
            this.txb_EmployeeWhoSells.Size = new System.Drawing.Size(123, 20);
            this.txb_EmployeeWhoSells.TabIndex = 11;
            this.txb_EmployeeWhoSells.TextChanged += new System.EventHandler(this.txb_EmployeeWhoSells_TextChanged);
            // 
            // lbl_TypeOfPayment
            // 
            this.lbl_TypeOfPayment.AutoSize = true;
            this.lbl_TypeOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TypeOfPayment.Location = new System.Drawing.Point(250, 311);
            this.lbl_TypeOfPayment.Name = "lbl_TypeOfPayment";
            this.lbl_TypeOfPayment.Size = new System.Drawing.Size(101, 17);
            this.lbl_TypeOfPayment.TabIndex = 0;
            this.lbl_TypeOfPayment.Text = "Ödənişin Növü";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(250, 383);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(108, 17);
            this.lbl_Price.TabIndex = 0;
            this.lbl_Price.Text = "Yazılma Qiyməti";
            // 
            // txb_Price
            // 
            this.txb_Price.Location = new System.Drawing.Point(251, 415);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(123, 20);
            this.txb_Price.TabIndex = 13;
            // 
            // lbl_ServicePrice
            // 
            this.lbl_ServicePrice.AutoSize = true;
            this.lbl_ServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServicePrice.Location = new System.Drawing.Point(432, 35);
            this.lbl_ServicePrice.Name = "lbl_ServicePrice";
            this.lbl_ServicePrice.Size = new System.Drawing.Size(97, 17);
            this.lbl_ServicePrice.TabIndex = 0;
            this.lbl_ServicePrice.Text = "Servis Xidməti";
            // 
            // txb_ServicePrice
            // 
            this.txb_ServicePrice.Location = new System.Drawing.Point(435, 64);
            this.txb_ServicePrice.Name = "txb_ServicePrice";
            this.txb_ServicePrice.Size = new System.Drawing.Size(123, 20);
            this.txb_ServicePrice.TabIndex = 14;
            // 
            // lbl_EmployeeWhoConnects
            // 
            this.lbl_EmployeeWhoConnects.AutoSize = true;
            this.lbl_EmployeeWhoConnects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeWhoConnects.Location = new System.Drawing.Point(250, 176);
            this.lbl_EmployeeWhoConnects.Name = "lbl_EmployeeWhoConnects";
            this.lbl_EmployeeWhoConnects.Size = new System.Drawing.Size(74, 17);
            this.lbl_EmployeeWhoConnects.TabIndex = 0;
            this.lbl_EmployeeWhoConnects.Text = "Qoşan İşçi";
            // 
            // txb_EmployeeWhoConnects
            // 
            this.txb_EmployeeWhoConnects.Location = new System.Drawing.Point(253, 205);
            this.txb_EmployeeWhoConnects.Name = "txb_EmployeeWhoConnects";
            this.txb_EmployeeWhoConnects.Size = new System.Drawing.Size(123, 20);
            this.txb_EmployeeWhoConnects.TabIndex = 10;
            // 
            // lbl_SellesPayment
            // 
            this.lbl_SellesPayment.AutoSize = true;
            this.lbl_SellesPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SellesPayment.Location = new System.Drawing.Point(432, 105);
            this.lbl_SellesPayment.Name = "lbl_SellesPayment";
            this.lbl_SellesPayment.Size = new System.Drawing.Size(124, 17);
            this.lbl_SellesPayment.TabIndex = 0;
            this.lbl_SellesPayment.Text = "Satanın Ödənişi %";
            // 
            // txb_SellesPayment
            // 
            this.txb_SellesPayment.Location = new System.Drawing.Point(435, 134);
            this.txb_SellesPayment.Name = "txb_SellesPayment";
            this.txb_SellesPayment.Size = new System.Drawing.Size(123, 20);
            this.txb_SellesPayment.TabIndex = 15;
            // 
            // lbl_WrittenByOrxan
            // 
            this.lbl_WrittenByOrxan.AutoSize = true;
            this.lbl_WrittenByOrxan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WrittenByOrxan.Location = new System.Drawing.Point(432, 176);
            this.lbl_WrittenByOrxan.Name = "lbl_WrittenByOrxan";
            this.lbl_WrittenByOrxan.Size = new System.Drawing.Size(111, 17);
            this.lbl_WrittenByOrxan.TabIndex = 0;
            this.lbl_WrittenByOrxan.Text = "Yazanın Ödənişi";
            // 
            // txb_WrittenByOrxan
            // 
            this.txb_WrittenByOrxan.Location = new System.Drawing.Point(435, 205);
            this.txb_WrittenByOrxan.Name = "txb_WrittenByOrxan";
            this.txb_WrittenByOrxan.Size = new System.Drawing.Size(123, 20);
            this.txb_WrittenByOrxan.TabIndex = 16;
            // 
            // dt_RegistrationDate
            // 
            this.dt_RegistrationDate.Location = new System.Drawing.Point(63, 415);
            this.dt_RegistrationDate.Name = "dt_RegistrationDate";
            this.dt_RegistrationDate.Size = new System.Drawing.Size(123, 20);
            this.dt_RegistrationDate.TabIndex = 18;
            // 
            // lbl_RegistrationDate
            // 
            this.lbl_RegistrationDate.AutoSize = true;
            this.lbl_RegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistrationDate.Location = new System.Drawing.Point(60, 386);
            this.lbl_RegistrationDate.Name = "lbl_RegistrationDate";
            this.lbl_RegistrationDate.Size = new System.Drawing.Size(109, 17);
            this.lbl_RegistrationDate.TabIndex = 0;
            this.lbl_RegistrationDate.Text = "Qeydiyyat Tarixi";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Add.Location = new System.Drawing.Point(218, 597);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(183, 61);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Əlavə Et";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Phone
            // 
            this.btn_Phone.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Phone.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Phone.Location = new System.Drawing.Point(630, 498);
            this.btn_Phone.Name = "btn_Phone";
            this.btn_Phone.Size = new System.Drawing.Size(202, 54);
            this.btn_Phone.TabIndex = 23;
            this.btn_Phone.Text = "Telefon";
            this.btn_Phone.UseVisualStyleBackColor = false;
            this.btn_Phone.Click += new System.EventHandler(this.btn_Phone_Click);
            // 
            // rb_Paid
            // 
            this.rb_Paid.AutoSize = true;
            this.rb_Paid.Location = new System.Drawing.Point(466, 363);
            this.rb_Paid.Name = "rb_Paid";
            this.rb_Paid.Size = new System.Drawing.Size(63, 17);
            this.rb_Paid.TabIndex = 20;
            this.rb_Paid.TabStop = true;
            this.rb_Paid.Text = "Ödənildi";
            this.rb_Paid.UseVisualStyleBackColor = true;
            // 
            // lbl_InitialPayment
            // 
            this.lbl_InitialPayment.AutoSize = true;
            this.lbl_InitialPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InitialPayment.Location = new System.Drawing.Point(454, 338);
            this.lbl_InitialPayment.Name = "lbl_InitialPayment";
            this.lbl_InitialPayment.Size = new System.Drawing.Size(53, 17);
            this.lbl_InitialPayment.TabIndex = 0;
            this.lbl_InitialPayment.Text = "Ödəniş";
            // 
            // rb_NotPaid
            // 
            this.rb_NotPaid.AutoSize = true;
            this.rb_NotPaid.Location = new System.Drawing.Point(466, 386);
            this.rb_NotPaid.Name = "rb_NotPaid";
            this.rb_NotPaid.Size = new System.Drawing.Size(77, 17);
            this.rb_NotPaid.TabIndex = 21;
            this.rb_NotPaid.TabStop = true;
            this.rb_NotPaid.Text = "Ödənilmədi";
            this.rb_NotPaid.UseVisualStyleBackColor = true;
            // 
            // rtxb_Info
            // 
            this.rtxb_Info.Location = new System.Drawing.Point(63, 479);
            this.rtxb_Info.Name = "rtxb_Info";
            this.rtxb_Info.Size = new System.Drawing.Size(320, 77);
            this.rtxb_Info.TabIndex = 19;
            this.rtxb_Info.Text = "";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.Location = new System.Drawing.Point(60, 454);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(61, 17);
            this.lbl_Info.TabIndex = 0;
            this.lbl_Info.Text = "Məlumat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1211, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 63);
            this.button1.TabIndex = 24;
            this.button1.Text = "Geri Qayıdın";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_OfficeMncPercent
            // 
            this.lbl_OfficeMncPercent.AutoSize = true;
            this.lbl_OfficeMncPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfficeMncPercent.Location = new System.Drawing.Point(432, 240);
            this.lbl_OfficeMncPercent.Name = "lbl_OfficeMncPercent";
            this.lbl_OfficeMncPercent.Size = new System.Drawing.Size(79, 17);
            this.lbl_OfficeMncPercent.TabIndex = 0;
            this.lbl_OfficeMncPercent.Text = "Ofis Mnc %";
            // 
            // txb_OfficeMncPercent
            // 
            this.txb_OfficeMncPercent.Location = new System.Drawing.Point(435, 269);
            this.txb_OfficeMncPercent.Name = "txb_OfficeMncPercent";
            this.txb_OfficeMncPercent.Size = new System.Drawing.Size(123, 20);
            this.txb_OfficeMncPercent.TabIndex = 17;
            // 
            // cmb_TypeOfPayment
            // 
            this.cmb_TypeOfPayment.FormattingEnabled = true;
            this.cmb_TypeOfPayment.Location = new System.Drawing.Point(253, 339);
            this.cmb_TypeOfPayment.Name = "cmb_TypeOfPayment";
            this.cmb_TypeOfPayment.Size = new System.Drawing.Size(123, 21);
            this.cmb_TypeOfPayment.TabIndex = 12;
            this.cmb_TypeOfPayment.SelectedIndexChanged += new System.EventHandler(this.cmb_TypeOfPayment_SelectedIndexChanged);
            // 
            // btn_AddNewCompany
            // 
            this.btn_AddNewCompany.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_AddNewCompany.Location = new System.Drawing.Point(838, 498);
            this.btn_AddNewCompany.Name = "btn_AddNewCompany";
            this.btn_AddNewCompany.Size = new System.Drawing.Size(202, 54);
            this.btn_AddNewCompany.TabIndex = 25;
            this.btn_AddNewCompany.Text = "Yeni Müəssisə";
            this.btn_AddNewCompany.UseVisualStyleBackColor = false;
            this.btn_AddNewCompany.Click += new System.EventHandler(this.btn_AddNewCompany_Click);
            // 
            // cmb_CashireModel
            // 
            this.cmb_CashireModel.FormattingEnabled = true;
            this.cmb_CashireModel.Location = new System.Drawing.Point(253, 134);
            this.cmb_CashireModel.Name = "cmb_CashireModel";
            this.cmb_CashireModel.Size = new System.Drawing.Size(121, 21);
            this.cmb_CashireModel.TabIndex = 26;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 692);
            this.Controls.Add(this.cmb_CashireModel);
            this.Controls.Add(this.btn_AddNewCompany);
            this.Controls.Add(this.cmb_TypeOfPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxb_Info);
            this.Controls.Add(this.rb_NotPaid);
            this.Controls.Add(this.rb_Paid);
            this.Controls.Add(this.btn_Phone);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dt_RegistrationDate);
            this.Controls.Add(this.dgv_AllProduct);
            this.Controls.Add(this.txb_ServicePrice);
            this.Controls.Add(this.txb_ApproximateLocation);
            this.Controls.Add(this.lbl_ServicePrice);
            this.Controls.Add(this.lbl_ApproximateLocation);
            this.Controls.Add(this.txb_Price);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txb_District);
            this.Controls.Add(this.lbl_TypeOfPayment);
            this.Controls.Add(this.lbl_District);
            this.Controls.Add(this.txb_EmployeeWhoConnects);
            this.Controls.Add(this.txb_EmployeeWhoSells);
            this.Controls.Add(this.lbl_EmployeeWhoConnects);
            this.Controls.Add(this.txb_VoenPassword);
            this.Controls.Add(this.lbl_EmployeeWhoSells);
            this.Controls.Add(this.lbl_VoenPassword);
            this.Controls.Add(this.txb_OfficeMncPercent);
            this.Controls.Add(this.txb_CompanyName);
            this.Controls.Add(this.lbl_InitialPayment);
            this.Controls.Add(this.lbl_OfficeMncPercent);
            this.Controls.Add(this.lbl_RegistrationDate);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.txb_WrittenByOrxan);
            this.Controls.Add(this.lbl_WrittenByOrxan);
            this.Controls.Add(this.txb_SellesPayment);
            this.Controls.Add(this.lbl_CashireModel);
            this.Controls.Add(this.lbl_SellesPayment);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müəssisə";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.DataGridView dgv_AllProduct;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.TextBox txb_CompanyName;
        private System.Windows.Forms.Label lbl_VoenPassword;
        private System.Windows.Forms.TextBox txb_VoenPassword;
        private System.Windows.Forms.Label lbl_District;
        private System.Windows.Forms.TextBox txb_District;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Label lbl_ApproximateLocation;
        private System.Windows.Forms.TextBox txb_ApproximateLocation;
        private System.Windows.Forms.Label lbl_CashireModel;
        private System.Windows.Forms.Label lbl_EmployeeWhoSells;
        private System.Windows.Forms.TextBox txb_EmployeeWhoSells;
        private System.Windows.Forms.Label lbl_TypeOfPayment;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Label lbl_ServicePrice;
        private System.Windows.Forms.TextBox txb_ServicePrice;
        private System.Windows.Forms.Label lbl_EmployeeWhoConnects;
        private System.Windows.Forms.TextBox txb_EmployeeWhoConnects;
        private System.Windows.Forms.Label lbl_SellesPayment;
        private System.Windows.Forms.TextBox txb_SellesPayment;
        private System.Windows.Forms.Label lbl_WrittenByOrxan;
        private System.Windows.Forms.TextBox txb_WrittenByOrxan;
        private System.Windows.Forms.DateTimePicker dt_RegistrationDate;
        private System.Windows.Forms.Label lbl_RegistrationDate;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Phone;
        private System.Windows.Forms.RadioButton rb_Paid;
        private System.Windows.Forms.Label lbl_InitialPayment;
        private System.Windows.Forms.RadioButton rb_NotPaid;
        private System.Windows.Forms.RichTextBox rtxb_Info;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_OfficeMncPercent;
        private System.Windows.Forms.TextBox txb_OfficeMncPercent;
        private System.Windows.Forms.ComboBox cmb_TypeOfPayment;
        private System.Windows.Forms.Button btn_AddNewCompany;
        private System.Windows.Forms.ComboBox cmb_CashireModel;
    }
}