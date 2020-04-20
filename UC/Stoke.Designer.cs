namespace PadaviyaShop.UC
{
    partial class Stoke
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtItemCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.dvgStokes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNoItems = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStokeTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStokes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(403, 79);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(77, 23);
            this.btnInsert.TabIndex = 31;
            this.btnInsert.Text = "Search";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.txtItemCode.Location = new System.Drawing.Point(98, 81);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(299, 21);
            this.txtItemCode.TabIndex = 30;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Item Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Stoke";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PadaviyaShop.Properties.Resources.Refresh;
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(486, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(28, 29);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dvgStokes
            // 
            this.dvgStokes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgStokes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStokes.Location = new System.Drawing.Point(15, 133);
            this.dvgStokes.Name = "dvgStokes";
            this.dvgStokes.Size = new System.Drawing.Size(737, 354);
            this.dvgStokes.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblNoItems);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblStokeTotal);
            this.panel2.Location = new System.Drawing.Point(758, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 354);
            this.panel2.TabIndex = 62;
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
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total Stoke Price";
            // 
            // lblStokeTotal
            // 
            this.lblStokeTotal.AutoSize = true;
            this.lblStokeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokeTotal.ForeColor = System.Drawing.Color.Black;
            this.lblStokeTotal.Location = new System.Drawing.Point(7, 58);
            this.lblStokeTotal.Name = "lblStokeTotal";
            this.lblStokeTotal.Size = new System.Drawing.Size(25, 31);
            this.lblStokeTotal.TabIndex = 35;
            this.lblStokeTotal.Text = "*";
            // 
            // Stoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dvgStokes);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Stoke";
            this.Size = new System.Drawing.Size(1040, 650);
            this.Load += new System.EventHandler(this.Stoke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStokes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnRefresh;
        private System.Windows.Forms.DataGridView dvgStokes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNoItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStokeTotal;
    }
}
