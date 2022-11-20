
namespace MiniMart
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inpProUIS = new MaterialSkin.Controls.MaterialTextBox();
            this.inpProSalePrice = new MaterialSkin.Controls.MaterialTextBox();
            this.inpProPurPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbProType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.inpProName = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnProDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnProUpdate = new MaterialSkin.Controls.MaterialButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.tabIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(5, 119);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1490, 708);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "chart.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1482, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "price-tag.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1482, 658);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Sale";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.dgvPro);
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.ImageKey = "cubes (1).png";
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage3.Size = new System.Drawing.Size(1482, 658);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product";
            // 
            // dgvPro
            // 
            this.dgvPro.AllowUserToAddRows = false;
            this.dgvPro.AllowUserToDeleteRows = false;
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPro.Location = new System.Drawing.Point(544, 5);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.ReadOnly = true;
            this.dgvPro.RowHeadersWidth = 51;
            this.dgvPro.RowTemplate.Height = 29;
            this.dgvPro.Size = new System.Drawing.Size(933, 648);
            this.dgvPro.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(539, 648);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.materialTextBox21, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialButton4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(505, 56);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Find product by ID, Name, Type";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(3, 3);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(413, 48);
            this.materialTextBox21.TabIndex = 8;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(423, 6);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(78, 36);
            this.materialButton4.TabIndex = 9;
            this.materialButton4.Text = "Search";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.inpProUIS, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.inpProSalePrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.inpProPurPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbbProType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inpProName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 349);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // inpProUIS
            // 
            this.inpProUIS.AnimateReadOnly = false;
            this.inpProUIS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpProUIS.Depth = 0;
            this.inpProUIS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inpProUIS.Enabled = false;
            this.inpProUIS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inpProUIS.LeadingIcon = null;
            this.inpProUIS.Location = new System.Drawing.Point(132, 288);
            this.inpProUIS.MaxLength = 50;
            this.inpProUIS.MouseState = MaterialSkin.MouseState.OUT;
            this.inpProUIS.Multiline = false;
            this.inpProUIS.Name = "inpProUIS";
            this.inpProUIS.Size = new System.Drawing.Size(362, 50);
            this.inpProUIS.TabIndex = 14;
            this.inpProUIS.Text = "";
            this.inpProUIS.TrailingIcon = null;
            // 
            // inpProSalePrice
            // 
            this.inpProSalePrice.AnimateReadOnly = false;
            this.inpProSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpProSalePrice.Depth = 0;
            this.inpProSalePrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inpProSalePrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inpProSalePrice.LeadingIcon = null;
            this.inpProSalePrice.Location = new System.Drawing.Point(132, 219);
            this.inpProSalePrice.MaxLength = 50;
            this.inpProSalePrice.MouseState = MaterialSkin.MouseState.OUT;
            this.inpProSalePrice.Multiline = false;
            this.inpProSalePrice.Name = "inpProSalePrice";
            this.inpProSalePrice.Size = new System.Drawing.Size(362, 50);
            this.inpProSalePrice.TabIndex = 13;
            this.inpProSalePrice.Text = "";
            this.inpProSalePrice.TrailingIcon = null;
            // 
            // inpProPurPrice
            // 
            this.inpProPurPrice.AnimateReadOnly = false;
            this.inpProPurPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpProPurPrice.Depth = 0;
            this.inpProPurPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inpProPurPrice.Enabled = false;
            this.inpProPurPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inpProPurPrice.LeadingIcon = null;
            this.inpProPurPrice.Location = new System.Drawing.Point(132, 153);
            this.inpProPurPrice.MaxLength = 50;
            this.inpProPurPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.inpProPurPrice.Multiline = false;
            this.inpProPurPrice.Name = "inpProPurPrice";
            this.inpProPurPrice.Size = new System.Drawing.Size(362, 50);
            this.inpProPurPrice.TabIndex = 12;
            this.inpProPurPrice.Text = "";
            this.inpProPurPrice.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(11, 312);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(115, 19);
            this.materialLabel9.TabIndex = 10;
            this.materialLabel9.Text = "Unit In Stock";
            // 
            // cbbProType
            // 
            this.cbbProType.AutoResize = false;
            this.cbbProType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbProType.Depth = 0;
            this.cbbProType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbbProType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbProType.DropDownHeight = 174;
            this.cbbProType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProType.DropDownWidth = 121;
            this.cbbProType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbProType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbProType.FormattingEnabled = true;
            this.cbbProType.IntegralHeight = false;
            this.cbbProType.ItemHeight = 43;
            this.cbbProType.Location = new System.Drawing.Point(132, 88);
            this.cbbProType.MaxDropDownItems = 4;
            this.cbbProType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbProType.Name = "cbbProType";
            this.cbbProType.Size = new System.Drawing.Size(362, 49);
            this.cbbProType.StartIndex = 0;
            this.cbbProType.TabIndex = 15;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(11, 243);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(115, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Sale Price";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(11, 177);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(115, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Purchased Price";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(11, 111);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Type";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(11, 45);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Name";
            // 
            // inpProName
            // 
            this.inpProName.AnimateReadOnly = false;
            this.inpProName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpProName.Depth = 0;
            this.inpProName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inpProName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inpProName.LeadingIcon = null;
            this.inpProName.Location = new System.Drawing.Point(132, 21);
            this.inpProName.MaxLength = 50;
            this.inpProName.MouseState = MaterialSkin.MouseState.OUT;
            this.inpProName.Multiline = false;
            this.inpProName.Name = "inpProName";
            this.inpProName.Size = new System.Drawing.Size(362, 50);
            this.inpProName.TabIndex = 2;
            this.inpProName.Text = "";
            this.inpProName.TrailingIcon = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnProAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnProDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnProUpdate, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 420);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 54);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnProAdd
            // 
            this.btnProAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProAdd.Depth = 0;
            this.btnProAdd.HighEmphasis = true;
            this.btnProAdd.Icon = null;
            this.btnProAdd.Location = new System.Drawing.Point(4, 9);
            this.btnProAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProAdd.Size = new System.Drawing.Size(160, 36);
            this.btnProAdd.TabIndex = 5;
            this.btnProAdd.Text = "Add";
            this.btnProAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProAdd.UseAccentColor = false;
            this.btnProAdd.UseVisualStyleBackColor = true;
            this.btnProAdd.Click += new System.EventHandler(this.btnProAdd_Click);
            // 
            // btnProDelete
            // 
            this.btnProDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProDelete.Depth = 0;
            this.btnProDelete.HighEmphasis = true;
            this.btnProDelete.Icon = null;
            this.btnProDelete.Location = new System.Drawing.Point(340, 9);
            this.btnProDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProDelete.Size = new System.Drawing.Size(161, 36);
            this.btnProDelete.TabIndex = 7;
            this.btnProDelete.Text = "Delete";
            this.btnProDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProDelete.UseAccentColor = false;
            this.btnProDelete.UseVisualStyleBackColor = true;
            this.btnProDelete.Click += new System.EventHandler(this.btnProDelete_Click);
            // 
            // btnProUpdate
            // 
            this.btnProUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProUpdate.Depth = 0;
            this.btnProUpdate.HighEmphasis = true;
            this.btnProUpdate.Icon = null;
            this.btnProUpdate.Location = new System.Drawing.Point(172, 9);
            this.btnProUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProUpdate.Name = "btnProUpdate";
            this.btnProUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProUpdate.Size = new System.Drawing.Size(160, 36);
            this.btnProUpdate.TabIndex = 6;
            this.btnProUpdate.Text = "Update";
            this.btnProUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProUpdate.UseAccentColor = false;
            this.btnProUpdate.UseVisualStyleBackColor = true;
            this.btnProUpdate.Click += new System.EventHandler(this.btnProUpdate_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage4.ImageKey = "parcel.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1482, 658);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Supplier";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage5.ImageKey = "shopping-cart.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 46);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage5.Size = new System.Drawing.Size(1482, 658);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Purchase Order";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "id-card (2).png";
            this.tabPage6.Location = new System.Drawing.Point(4, 46);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1482, 658);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Staff";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabIconList
            // 
            this.tabIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.tabIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabIconList.ImageStream")));
            this.tabIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.tabIconList.Images.SetKeyName(1, "product.png");
            this.tabIconList.Images.SetKeyName(2, "boxes.png");
            this.tabIconList.Images.SetKeyName(3, "cubes.png");
            this.tabIconList.Images.SetKeyName(4, "price-tag.png");
            this.tabIconList.Images.SetKeyName(5, "supplier.png");
            this.tabIconList.Images.SetKeyName(6, "supply-chain.png");
            this.tabIconList.Images.SetKeyName(7, "id-card.png");
            this.tabIconList.Images.SetKeyName(8, "id-card (1).png");
            this.tabIconList.Images.SetKeyName(9, "identity.png");
            this.tabIconList.Images.SetKeyName(10, "box-solid.png");
            this.tabIconList.Images.SetKeyName(11, "id-card (2).png");
            this.tabIconList.Images.SetKeyName(12, "logistics-delivery.png");
            this.tabIconList.Images.SetKeyName(13, "shopping-cart.png");
            this.tabIconList.Images.SetKeyName(14, "parcel.png");
            this.tabIconList.Images.SetKeyName(15, "cubes (1).png");
            this.tabIconList.Images.SetKeyName(16, "bar-chart.png");
            this.tabIconList.Images.SetKeyName(17, "chart.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 832);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5, 119, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convenience Store";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList tabIconList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox inpProName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox inpProUIS;
        private MaterialSkin.Controls.MaterialTextBox inpProSalePrice;
        private MaterialSkin.Controls.MaterialTextBox inpProPurPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cbbProType;
        private MaterialSkin.Controls.MaterialButton btnProUpdate;
        private MaterialSkin.Controls.MaterialButton btnProAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btnProDelete;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}

