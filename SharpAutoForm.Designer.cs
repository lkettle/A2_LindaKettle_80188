namespace A2_LindaKettle_80188
{
    partial class SharpAutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpAutoForm));
            this.gbx_exterior_finish = new System.Windows.Forms.GroupBox();
            this.rbn_custom_detail = new System.Windows.Forms.RadioButton();
            this.rbn_pearlized = new System.Windows.Forms.RadioButton();
            this.rbn_standard = new System.Windows.Forms.RadioButton();
            this.gbx_add_ons = new System.Windows.Forms.GroupBox();
            this.cbx_GIS = new System.Windows.Forms.CheckBox();
            this.cbx_leather = new System.Windows.Forms.CheckBox();
            this.cbx_stereo = new System.Windows.Forms.CheckBox();
            this.lbl_base_price = new System.Windows.Forms.Label();
            this.txt_base_price = new System.Windows.Forms.TextBox();
            this.txt_addons = new System.Windows.Forms.TextBox();
            this.lbl_options = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_sales_tax = new System.Windows.Forms.TextBox();
            this.lbl_sales_tax = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_tradein = new System.Windows.Forms.TextBox();
            this.lbl_tradein = new System.Windows.Forms.Label();
            this.txt_amountDue = new System.Windows.Forms.TextBox();
            this.lbl_amount_due = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.menu_FEH = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_exterior_finish.SuspendLayout();
            this.gbx_add_ons.SuspendLayout();
            this.menu_FEH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_exterior_finish
            // 
            this.gbx_exterior_finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbx_exterior_finish.BackColor = System.Drawing.Color.Transparent;
            this.gbx_exterior_finish.Controls.Add(this.rbn_custom_detail);
            this.gbx_exterior_finish.Controls.Add(this.rbn_pearlized);
            this.gbx_exterior_finish.Controls.Add(this.rbn_standard);
            this.gbx_exterior_finish.ForeColor = System.Drawing.Color.Gold;
            this.gbx_exterior_finish.Location = new System.Drawing.Point(13, 375);
            this.gbx_exterior_finish.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_exterior_finish.Name = "gbx_exterior_finish";
            this.gbx_exterior_finish.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_exterior_finish.Size = new System.Drawing.Size(280, 170);
            this.gbx_exterior_finish.TabIndex = 1;
            this.gbx_exterior_finish.TabStop = false;
            this.gbx_exterior_finish.Text = "Exterior Finish";
            // 
            // rbn_custom_detail
            // 
            this.rbn_custom_detail.AutoSize = true;
            this.rbn_custom_detail.BackColor = System.Drawing.Color.Transparent;
            this.rbn_custom_detail.Location = new System.Drawing.Point(21, 130);
            this.rbn_custom_detail.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_custom_detail.Name = "rbn_custom_detail";
            this.rbn_custom_detail.Size = new System.Drawing.Size(200, 25);
            this.rbn_custom_detail.TabIndex = 3;
            this.rbn_custom_detail.TabStop = true;
            this.rbn_custom_detail.Text = "Customized Detailing";
            this.rbn_custom_detail.UseVisualStyleBackColor = false;
            this.rbn_custom_detail.CheckedChanged += new System.EventHandler(this.rbn_custom_detail_CheckedChanged);
            // 
            // rbn_pearlized
            // 
            this.rbn_pearlized.AutoSize = true;
            this.rbn_pearlized.BackColor = System.Drawing.Color.Transparent;
            this.rbn_pearlized.Location = new System.Drawing.Point(21, 90);
            this.rbn_pearlized.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_pearlized.Name = "rbn_pearlized";
            this.rbn_pearlized.Size = new System.Drawing.Size(105, 25);
            this.rbn_pearlized.TabIndex = 2;
            this.rbn_pearlized.TabStop = true;
            this.rbn_pearlized.Text = "Pearlized";
            this.rbn_pearlized.UseVisualStyleBackColor = false;
            this.rbn_pearlized.CheckedChanged += new System.EventHandler(this.rbn_pearlized_CheckedChanged);
            // 
            // rbn_standard
            // 
            this.rbn_standard.AutoSize = true;
            this.rbn_standard.BackColor = System.Drawing.Color.Transparent;
            this.rbn_standard.Checked = true;
            this.rbn_standard.Location = new System.Drawing.Point(21, 46);
            this.rbn_standard.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_standard.Name = "rbn_standard";
            this.rbn_standard.Size = new System.Drawing.Size(107, 25);
            this.rbn_standard.TabIndex = 1;
            this.rbn_standard.TabStop = true;
            this.rbn_standard.Text = "Standard";
            this.rbn_standard.UseVisualStyleBackColor = false;
            this.rbn_standard.CheckedChanged += new System.EventHandler(this.rbn_standard_CheckedChanged);
            // 
            // gbx_add_ons
            // 
            this.gbx_add_ons.BackColor = System.Drawing.Color.Transparent;
            this.gbx_add_ons.Controls.Add(this.cbx_GIS);
            this.gbx_add_ons.Controls.Add(this.cbx_leather);
            this.gbx_add_ons.Controls.Add(this.cbx_stereo);
            this.gbx_add_ons.ForeColor = System.Drawing.Color.Gold;
            this.gbx_add_ons.Location = new System.Drawing.Point(301, 375);
            this.gbx_add_ons.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_add_ons.Name = "gbx_add_ons";
            this.gbx_add_ons.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_add_ons.Size = new System.Drawing.Size(325, 170);
            this.gbx_add_ons.TabIndex = 2;
            this.gbx_add_ons.TabStop = false;
            this.gbx_add_ons.Text = "Additional";
            // 
            // cbx_GIS
            // 
            this.cbx_GIS.AutoSize = true;
            this.cbx_GIS.BackColor = System.Drawing.Color.Transparent;
            this.cbx_GIS.Location = new System.Drawing.Point(21, 136);
            this.cbx_GIS.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_GIS.Name = "cbx_GIS";
            this.cbx_GIS.Size = new System.Drawing.Size(286, 25);
            this.cbx_GIS.TabIndex = 6;
            this.cbx_GIS.Text = "Computerized Navigation (GIS)";
            this.cbx_GIS.UseVisualStyleBackColor = false;
            this.cbx_GIS.CheckedChanged += new System.EventHandler(this.cbx_GIS_CheckedChanged);
            // 
            // cbx_leather
            // 
            this.cbx_leather.AutoSize = true;
            this.cbx_leather.BackColor = System.Drawing.Color.Transparent;
            this.cbx_leather.Location = new System.Drawing.Point(21, 91);
            this.cbx_leather.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_leather.Name = "cbx_leather";
            this.cbx_leather.Size = new System.Drawing.Size(155, 25);
            this.cbx_leather.TabIndex = 5;
            this.cbx_leather.Text = "Leather Interior";
            this.cbx_leather.UseVisualStyleBackColor = false;
            this.cbx_leather.CheckedChanged += new System.EventHandler(this.cbx_leather_CheckedChanged);
            // 
            // cbx_stereo
            // 
            this.cbx_stereo.AutoSize = true;
            this.cbx_stereo.BackColor = System.Drawing.Color.Transparent;
            this.cbx_stereo.ForeColor = System.Drawing.Color.Gold;
            this.cbx_stereo.Location = new System.Drawing.Point(21, 47);
            this.cbx_stereo.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_stereo.Name = "cbx_stereo";
            this.cbx_stereo.Size = new System.Drawing.Size(143, 25);
            this.cbx_stereo.TabIndex = 4;
            this.cbx_stereo.Text = "Stereo System";
            this.cbx_stereo.UseVisualStyleBackColor = false;
            this.cbx_stereo.CheckedChanged += new System.EventHandler(this.cbx_stereo_CheckedChanged);
            // 
            // lbl_base_price
            // 
            this.lbl_base_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_base_price.AutoSize = true;
            this.lbl_base_price.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_base_price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_base_price.Location = new System.Drawing.Point(462, 41);
            this.lbl_base_price.Name = "lbl_base_price";
            this.lbl_base_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_base_price.Size = new System.Drawing.Size(102, 21);
            this.lbl_base_price.TabIndex = 3;
            this.lbl_base_price.Text = "Base Price :";
            this.lbl_base_price.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_base_price
            // 
            this.txt_base_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_base_price.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_base_price.Location = new System.Drawing.Point(664, 35);
            this.txt_base_price.Name = "txt_base_price";
            this.txt_base_price.Size = new System.Drawing.Size(206, 27);
            this.txt_base_price.TabIndex = 0;
            this.txt_base_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_base_price.Click += new System.EventHandler(this.txt_base_price_Click);
            this.txt_base_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_base_price_KeyDown);
            this.txt_base_price.Leave += new System.EventHandler(this.txt_base_price_Leave);
            // 
            // txt_addons
            // 
            this.txt_addons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addons.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_addons.Location = new System.Drawing.Point(664, 63);
            this.txt_addons.Name = "txt_addons";
            this.txt_addons.Size = new System.Drawing.Size(206, 27);
            this.txt_addons.TabIndex = 11;
            this.txt_addons.TabStop = false;
            this.txt_addons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_options
            // 
            this.lbl_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_options.AutoSize = true;
            this.lbl_options.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_options.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_options.Location = new System.Drawing.Point(462, 69);
            this.lbl_options.Name = "lbl_options";
            this.lbl_options.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_options.Size = new System.Drawing.Size(172, 21);
            this.lbl_options.TabIndex = 5;
            this.lbl_options.Text = "Additional Options :";
            this.lbl_options.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_subtotal.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_subtotal.Location = new System.Drawing.Point(664, 91);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(206, 27);
            this.txt_subtotal.TabIndex = 12;
            this.txt_subtotal.TabStop = false;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_subtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_subtotal.Location = new System.Drawing.Point(462, 97);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_subtotal.Size = new System.Drawing.Size(89, 21);
            this.lbl_subtotal.TabIndex = 7;
            this.lbl_subtotal.Text = "Subtotal :";
            this.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_sales_tax
            // 
            this.txt_sales_tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sales_tax.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_sales_tax.Location = new System.Drawing.Point(664, 119);
            this.txt_sales_tax.Name = "txt_sales_tax";
            this.txt_sales_tax.ReadOnly = true;
            this.txt_sales_tax.Size = new System.Drawing.Size(206, 27);
            this.txt_sales_tax.TabIndex = 13;
            this.txt_sales_tax.TabStop = false;
            this.txt_sales_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_sales_tax
            // 
            this.lbl_sales_tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sales_tax.AutoSize = true;
            this.lbl_sales_tax.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_sales_tax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sales_tax.Location = new System.Drawing.Point(462, 125);
            this.lbl_sales_tax.Name = "lbl_sales_tax";
            this.lbl_sales_tax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sales_tax.Size = new System.Drawing.Size(140, 21);
            this.lbl_sales_tax.TabIndex = 9;
            this.lbl_sales_tax.Text = "Sales Tax (13%) :";
            this.lbl_sales_tax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_total.Location = new System.Drawing.Point(664, 147);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(206, 27);
            this.txt_total.TabIndex = 14;
            this.txt_total.TabStop = false;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_total.Location = new System.Drawing.Point(462, 153);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_total.Size = new System.Drawing.Size(62, 21);
            this.lbl_total.TabIndex = 11;
            this.lbl_total.Text = "Total :";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_tradein
            // 
            this.txt_tradein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tradein.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txt_tradein.Location = new System.Drawing.Point(664, 175);
            this.txt_tradein.Name = "txt_tradein";
            this.txt_tradein.Size = new System.Drawing.Size(206, 27);
            this.txt_tradein.TabIndex = 7;
            this.txt_tradein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_tradein.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tradein_KeyDown);
            this.txt_tradein.Leave += new System.EventHandler(this.txt_tradein_Leave);
            // 
            // lbl_tradein
            // 
            this.lbl_tradein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tradein.AutoSize = true;
            this.lbl_tradein.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_tradein.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tradein.Location = new System.Drawing.Point(462, 181);
            this.lbl_tradein.Name = "lbl_tradein";
            this.lbl_tradein.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tradein.Size = new System.Drawing.Size(176, 21);
            this.lbl_tradein.TabIndex = 13;
            this.lbl_tradein.Text = "Trade-in Allowance :";
            this.lbl_tradein.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_amountDue
            // 
            this.txt_amountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amountDue.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_amountDue.Location = new System.Drawing.Point(664, 203);
            this.txt_amountDue.Name = "txt_amountDue";
            this.txt_amountDue.ReadOnly = true;
            this.txt_amountDue.Size = new System.Drawing.Size(206, 27);
            this.txt_amountDue.TabIndex = 15;
            this.txt_amountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_amount_due
            // 
            this.lbl_amount_due.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_amount_due.AutoSize = true;
            this.lbl_amount_due.BackColor = System.Drawing.Color.PowderBlue;
            this.lbl_amount_due.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_amount_due.Location = new System.Drawing.Point(462, 209);
            this.lbl_amount_due.Name = "lbl_amount_due";
            this.lbl_amount_due.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_amount_due.Size = new System.Drawing.Size(123, 21);
            this.lbl_amount_due.TabIndex = 15;
            this.lbl_amount_due.Text = "Amount Due :";
            this.lbl_amount_due.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Calculate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calculate.ForeColor = System.Drawing.Color.Gold;
            this.btn_Calculate.Location = new System.Drawing.Point(664, 385);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(206, 39);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.ForeColor = System.Drawing.Color.Gold;
            this.btn_Clear.Location = new System.Drawing.Point(664, 441);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(206, 39);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.ForeColor = System.Drawing.Color.Gold;
            this.btn_Exit.Location = new System.Drawing.Point(664, 497);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(206, 39);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // menu_FEH
            // 
            this.menu_FEH.BackColor = System.Drawing.Color.Transparent;
            this.menu_FEH.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_FEH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_FEH.Location = new System.Drawing.Point(0, 0);
            this.menu_FEH.Name = "menu_FEH";
            this.menu_FEH.Size = new System.Drawing.Size(882, 28);
            this.menu_FEH.TabIndex = 21;
            this.menu_FEH.Text = "menu_FEH";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.fontToolStripMenuItem.Text = "Fon&t";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.colorToolStripMenuItem.Text = "C&olor";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_amountDue);
            this.Controls.Add(this.lbl_amount_due);
            this.Controls.Add(this.txt_tradein);
            this.Controls.Add(this.lbl_tradein);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_sales_tax);
            this.Controls.Add(this.lbl_sales_tax);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.txt_addons);
            this.Controls.Add(this.lbl_options);
            this.Controls.Add(this.txt_base_price);
            this.Controls.Add(this.lbl_base_price);
            this.Controls.Add(this.gbx_add_ons);
            this.Controls.Add(this.gbx_exterior_finish);
            this.Controls.Add(this.menu_FEH);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SharpAutoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Auto Center";
            this.Load += new System.EventHandler(this.SharpAutoForm_Load);
            this.gbx_exterior_finish.ResumeLayout(false);
            this.gbx_exterior_finish.PerformLayout();
            this.gbx_add_ons.ResumeLayout(false);
            this.gbx_add_ons.PerformLayout();
            this.menu_FEH.ResumeLayout(false);
            this.menu_FEH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_exterior_finish;
        private System.Windows.Forms.RadioButton rbn_custom_detail;
        private System.Windows.Forms.RadioButton rbn_pearlized;
        private System.Windows.Forms.RadioButton rbn_standard;
        private System.Windows.Forms.GroupBox gbx_add_ons;
        private System.Windows.Forms.CheckBox cbx_GIS;
        private System.Windows.Forms.CheckBox cbx_leather;
        private System.Windows.Forms.CheckBox cbx_stereo;
        private System.Windows.Forms.Label lbl_base_price;
        private System.Windows.Forms.TextBox txt_base_price;
        private System.Windows.Forms.TextBox txt_addons;
        private System.Windows.Forms.Label lbl_options;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_sales_tax;
        private System.Windows.Forms.Label lbl_sales_tax;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_tradein;
        private System.Windows.Forms.Label lbl_tradein;
        private System.Windows.Forms.TextBox txt_amountDue;
        private System.Windows.Forms.Label lbl_amount_due;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.MenuStrip menu_FEH;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

