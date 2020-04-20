namespace PadaviyaShop.UC
{
    partial class Report
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
            this.btnSerchCode = new System.Windows.Forms.Button();
            this.txtItemCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.DateForm = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWholeTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGRandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerchCode
            // 
            this.btnSerchCode.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSerchCode.FlatAppearance.BorderSize = 0;
            this.btnSerchCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerchCode.ForeColor = System.Drawing.Color.White;
            this.btnSerchCode.Location = new System.Drawing.Point(289, 79);
            this.btnSerchCode.Name = "btnSerchCode";
            this.btnSerchCode.Size = new System.Drawing.Size(77, 21);
            this.btnSerchCode.TabIndex = 42;
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
            this.txtItemCode.Location = new System.Drawing.Point(97, 80);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(185, 21);
            this.txtItemCode.TabIndex = 41;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Item Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Report";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PadaviyaShop.Properties.Resources.Refresh;
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(372, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(28, 29);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(15, 136);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(737, 354);
            this.dgvReport.TabIndex = 45;
            // 
            // DateForm
            // 
            this.DateForm.BackColor = System.Drawing.Color.SeaGreen;
            this.DateForm.BorderRadius = 0;
            this.DateForm.ForeColor = System.Drawing.Color.White;
            this.DateForm.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateForm.FormatCustom = null;
            this.DateForm.Location = new System.Drawing.Point(417, 68);
            this.DateForm.Name = "DateForm";
            this.DateForm.Size = new System.Drawing.Size(215, 30);
            this.DateForm.TabIndex = 46;
            this.DateForm.Value = new System.DateTime(2020, 4, 7, 20, 10, 32, 38);
            // 
            // DateTo
            // 
            this.DateTo.BackColor = System.Drawing.Color.SeaGreen;
            this.DateTo.BorderRadius = 0;
            this.DateTo.ForeColor = System.Drawing.Color.White;
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTo.FormatCustom = null;
            this.DateTo.Location = new System.Drawing.Point(638, 68);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(215, 30);
            this.DateTo.TabIndex = 47;
            this.DateTo.Value = new System.DateTime(2020, 4, 7, 20, 10, 32, 38);
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDateSearch.FlatAppearance.BorderSize = 0;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.White;
            this.btnDateSearch.Location = new System.Drawing.Point(599, 104);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(77, 30);
            this.btnDateSearch.TabIndex = 48;
            this.btnDateSearch.Text = "Search";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalProfit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblWholeTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblGRandTotal);
            this.panel1.Location = new System.Drawing.Point(758, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 354);
            this.panel1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Total Profit ";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProfit.Location = new System.Drawing.Point(11, 274);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(20, 25);
            this.lblTotalProfit.TabIndex = 37;
            this.lblTotalProfit.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Whole Price Total";
            // 
            // lblWholeTotal
            // 
            this.lblWholeTotal.AutoSize = true;
            this.lblWholeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWholeTotal.ForeColor = System.Drawing.Color.Black;
            this.lblWholeTotal.Location = new System.Drawing.Point(10, 139);
            this.lblWholeTotal.Name = "lblWholeTotal";
            this.lblWholeTotal.Size = new System.Drawing.Size(20, 25);
            this.lblWholeTotal.TabIndex = 35;
            this.lblWholeTotal.Text = "*";
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
            // lblGRandTotal
            // 
            this.lblGRandTotal.AutoSize = true;
            this.lblGRandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGRandTotal.Location = new System.Drawing.Point(6, 13);
            this.lblGRandTotal.Name = "lblGRandTotal";
            this.lblGRandTotal.Size = new System.Drawing.Size(20, 25);
            this.lblGRandTotal.TabIndex = 29;
            this.lblGRandTotal.Text = "*";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDateSearch);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateForm);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSerchCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1040, 650);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerchCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvReport;
        private Bunifu.Framework.UI.BunifuDatepicker DateForm;
        private Bunifu.Framework.UI.BunifuDatepicker DateTo;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWholeTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGRandTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalProfit;
    }
}
