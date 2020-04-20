namespace PadaviyaShop.UC
{
    partial class load
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load));
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtItemName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuntity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listBoxItemName = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNoItems = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblWholePrice = new System.Windows.Forms.Label();
            this.lblTotalWhole = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purches Item";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(676, 193);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(74, 27);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemName.HintForeColor = System.Drawing.Color.Empty;
            this.txtItemName.HintText = "";
            this.txtItemName.isPassword = false;
            this.txtItemName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtItemName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtItemName.LineThickness = 3;
            this.txtItemName.Location = new System.Drawing.Point(94, 84);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(134, 21);
            this.txtItemName.TabIndex = 17;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            this.txtItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(254, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Item Code :";
            // 
            // txtItemCode
            // 
            this.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemCode.BackColor = System.Drawing.Color.White;
            this.txtItemCode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemCode.HintForeColor = System.Drawing.Color.Empty;
            this.txtItemCode.HintText = "";
            this.txtItemCode.isPassword = false;
            this.txtItemCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtItemCode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtItemCode.LineThickness = 3;
            this.txtItemCode.Location = new System.Drawing.Point(340, 83);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(140, 21);
            this.txtItemCode.TabIndex = 20;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemCode.Enter += new System.EventHandler(this.txtItemName_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Item Name :";
            // 
            // txtQuntity
            // 
            this.txtQuntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuntity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuntity.BackColor = System.Drawing.Color.White;
            this.txtQuntity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuntity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuntity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQuntity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuntity.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuntity.HintText = "";
            this.txtQuntity.isPassword = false;
            this.txtQuntity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuntity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtQuntity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuntity.LineThickness = 3;
            this.txtQuntity.Location = new System.Drawing.Point(594, 117);
            this.txtQuntity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuntity.MaxLength = 32767;
            this.txtQuntity.Name = "txtQuntity";
            this.txtQuntity.Size = new System.Drawing.Size(155, 21);
            this.txtQuntity.TabIndex = 24;
            this.txtQuntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuntity.Leave += new System.EventHandler(this.txtQuntity_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(528, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Quntity  :";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(592, 83);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 21);
            this.txtPrice.TabIndex = 22;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(496, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Rental Price  :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(756, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 27);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintSave
            // 
            this.btnPrintSave.Active = false;
            this.btnPrintSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintSave.BorderRadius = 0;
            this.btnPrintSave.ButtonText = "Save";
            this.btnPrintSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintSave.Iconimage")));
            this.btnPrintSave.Iconimage_right = null;
            this.btnPrintSave.Iconimage_right_Selected = null;
            this.btnPrintSave.Iconimage_Selected = null;
            this.btnPrintSave.IconMarginLeft = 0;
            this.btnPrintSave.IconMarginRight = 0;
            this.btnPrintSave.IconRightVisible = true;
            this.btnPrintSave.IconRightZoom = 0D;
            this.btnPrintSave.IconVisible = true;
            this.btnPrintSave.IconZoom = 90D;
            this.btnPrintSave.IsTab = false;
            this.btnPrintSave.Location = new System.Drawing.Point(756, 452);
            this.btnPrintSave.Name = "btnPrintSave";
            this.btnPrintSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrintSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintSave.selected = false;
            this.btnPrintSave.Size = new System.Drawing.Size(99, 44);
            this.btnPrintSave.TabIndex = 26;
            this.btnPrintSave.Text = "Save";
            this.btnPrintSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSave.Textcolor = System.Drawing.Color.White;
            this.btnPrintSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSave.Click += new System.EventHandler(this.btnPrintSave_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotal.LineThickness = 3;
            this.txtTotal.Location = new System.Drawing.Point(595, 149);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(155, 21);
            this.txtTotal.TabIndex = 28;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(6, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 31);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "*";
            // 
            // listBoxItemName
            // 
            this.listBoxItemName.FormattingEnabled = true;
            this.listBoxItemName.Location = new System.Drawing.Point(94, 112);
            this.listBoxItemName.Name = "listBoxItemName";
            this.listBoxItemName.Size = new System.Drawing.Size(134, 95);
            this.listBoxItemName.TabIndex = 30;
            this.listBoxItemName.Visible = false;
            this.listBoxItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxItemCode_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(242, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Whole Price  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(542, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Grand Total";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::PadaviyaShop.Properties.Resources.Refresh;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(757, 195);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblNoItems);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(757, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 159);
            this.panel1.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Items";
            // 
            // lblNoItems
            // 
            this.lblNoItems.AutoSize = true;
            this.lblNoItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoItems.ForeColor = System.Drawing.Color.Black;
            this.lblNoItems.Location = new System.Drawing.Point(7, 84);
            this.lblNoItems.Name = "lblNoItems";
            this.lblNoItems.Size = new System.Drawing.Size(25, 31);
            this.lblNoItems.TabIndex = 35;
            this.lblNoItems.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(345, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "*********";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(234, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Stoke Quntity  :";
            // 
            // lblWholePrice
            // 
            this.lblWholePrice.AutoSize = true;
            this.lblWholePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWholePrice.ForeColor = System.Drawing.Color.White;
            this.lblWholePrice.Location = new System.Drawing.Point(344, 120);
            this.lblWholePrice.Name = "lblWholePrice";
            this.lblWholePrice.Size = new System.Drawing.Size(53, 17);
            this.lblWholePrice.TabIndex = 39;
            this.lblWholePrice.Text = "*********";
            // 
            // lblTotalWhole
            // 
            this.lblTotalWhole.AutoSize = true;
            this.lblTotalWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWhole.ForeColor = System.Drawing.Color.White;
            this.lblTotalWhole.Location = new System.Drawing.Point(345, 190);
            this.lblTotalWhole.Name = "lblTotalWhole";
            this.lblTotalWhole.Size = new System.Drawing.Size(53, 17);
            this.lblTotalWhole.TabIndex = 40;
            this.lblTotalWhole.Text = "*********";
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(13, 236);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(736, 260);
            this.dgvBill.TabIndex = 41;
            // 
            // load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.lblTotalWhole);
            this.Controls.Add(this.lblWholePrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxItemName);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrintSave);
            this.Controls.Add(this.txtQuntity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "load";
            this.Size = new System.Drawing.Size(1040, 650);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemName;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemCode;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuntity;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintSave;
        private System.Windows.Forms.Button btnDelete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox listBoxItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNoItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblWholePrice;
        private System.Windows.Forms.Label lblTotalWhole;
        private System.Windows.Forms.DataGridView dgvBill;
    }
}
