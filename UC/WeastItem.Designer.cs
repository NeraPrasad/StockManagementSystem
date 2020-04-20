namespace PadaviyaShop
{
    partial class WeastItem
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
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.DateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DateForm = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSerchCode = new System.Windows.Forms.Button();
            this.txtItemCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNoItems = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWholeTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDateSearch.FlatAppearance.BorderSize = 0;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.White;
            this.btnDateSearch.Location = new System.Drawing.Point(596, 103);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(77, 30);
            this.btnDateSearch.TabIndex = 59;
            this.btnDateSearch.Text = "Search";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // DateTo
            // 
            this.DateTo.BackColor = System.Drawing.Color.SeaGreen;
            this.DateTo.BorderRadius = 0;
            this.DateTo.ForeColor = System.Drawing.Color.White;
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTo.FormatCustom = null;
            this.DateTo.Location = new System.Drawing.Point(635, 67);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(215, 30);
            this.DateTo.TabIndex = 58;
            this.DateTo.Value = new System.DateTime(2020, 4, 7, 20, 10, 32, 38);
            // 
            // DateForm
            // 
            this.DateForm.BackColor = System.Drawing.Color.SeaGreen;
            this.DateForm.BorderRadius = 0;
            this.DateForm.ForeColor = System.Drawing.Color.White;
            this.DateForm.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateForm.FormatCustom = null;
            this.DateForm.Location = new System.Drawing.Point(414, 67);
            this.DateForm.Name = "DateForm";
            this.DateForm.Size = new System.Drawing.Size(215, 30);
            this.DateForm.TabIndex = 57;
            this.DateForm.Value = new System.DateTime(2020, 4, 7, 20, 10, 32, 38);
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 135);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(737, 354);
            this.dgvReport.TabIndex = 56;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PadaviyaShop.Properties.Resources.Refresh;
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(369, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(28, 29);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSerchCode
            // 
            this.btnSerchCode.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSerchCode.FlatAppearance.BorderSize = 0;
            this.btnSerchCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerchCode.ForeColor = System.Drawing.Color.White;
            this.btnSerchCode.Location = new System.Drawing.Point(286, 78);
            this.btnSerchCode.Name = "btnSerchCode";
            this.btnSerchCode.Size = new System.Drawing.Size(77, 21);
            this.btnSerchCode.TabIndex = 54;
            this.btnSerchCode.Text = "Search";
            this.btnSerchCode.UseVisualStyleBackColor = false;
            this.btnSerchCode.Click += new System.EventHandler(this.btnSerchCode_Click);
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
            this.txtItemCode.Location = new System.Drawing.Point(94, 79);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(185, 21);
            this.txtItemCode.TabIndex = 53;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Item Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "Weast Item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblNoItems);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblWholeTotal);
            this.panel2.Location = new System.Drawing.Point(755, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 354);
            this.panel2.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Items";
            // 
            // lblNoItems
            // 
            this.lblNoItems.AutoSize = true;
            this.lblNoItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoItems.ForeColor = System.Drawing.Color.Black;
            this.lblNoItems.Location = new System.Drawing.Point(7, 193);
            this.lblNoItems.Name = "lblNoItems";
            this.lblNoItems.Size = new System.Drawing.Size(25, 31);
            this.lblNoItems.TabIndex = 39;
            this.lblNoItems.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Whole Price Total";
            // 
            // lblWholeTotal
            // 
            this.lblWholeTotal.AutoSize = true;
            this.lblWholeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWholeTotal.ForeColor = System.Drawing.Color.Black;
            this.lblWholeTotal.Location = new System.Drawing.Point(7, 58);
            this.lblWholeTotal.Name = "lblWholeTotal";
            this.lblWholeTotal.Size = new System.Drawing.Size(25, 31);
            this.lblWholeTotal.TabIndex = 35;
            this.lblWholeTotal.Text = "*";
            // 
            // WeastItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDateSearch);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateForm);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSerchCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "WeastItem";
            this.Size = new System.Drawing.Size(1040, 650);
            this.Load += new System.EventHandler(this.WeastItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDateSearch;
        private Bunifu.Framework.UI.BunifuDatepicker DateTo;
        private Bunifu.Framework.UI.BunifuDatepicker DateForm;
        private System.Windows.Forms.DataGridView dgvReport;
        private Bunifu.Framework.UI.BunifuImageButton btnRefresh;
        private System.Windows.Forms.Button btnSerchCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNoItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWholeTotal;
    }
}
