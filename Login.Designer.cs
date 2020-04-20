namespace PadaviyaShop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrintSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(129, 275);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 32);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password :";
            // 
            // txtUserID
            // 
            this.txtUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserID.BackColor = System.Drawing.Color.White;
            this.txtUserID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserID.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserID.HintText = "";
            this.txtUserID.isPassword = false;
            this.txtUserID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUserID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUserID.LineThickness = 3;
            this.txtUserID.Location = new System.Drawing.Point(129, 220);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.MaxLength = 32767;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(221, 32);
            this.txtUserID.TabIndex = 22;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "User ID  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PadaviyaShop.Properties.Resources.Crystal_Clear_app_Login_Manager_2;
            this.pictureBox1.Location = new System.Drawing.Point(114, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 176);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrintSave
            // 
            this.btnPrintSave.Active = false;
            this.btnPrintSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintSave.BorderRadius = 0;
            this.btnPrintSave.ButtonText = "Login";
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
            this.btnPrintSave.Location = new System.Drawing.Point(257, 327);
            this.btnPrintSave.Name = "btnPrintSave";
            this.btnPrintSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrintSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintSave.selected = false;
            this.btnPrintSave.Size = new System.Drawing.Size(93, 36);
            this.btnPrintSave.TabIndex = 27;
            this.btnPrintSave.Text = "Login";
            this.btnPrintSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSave.Textcolor = System.Drawing.Color.White;
            this.btnPrintSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSave.Click += new System.EventHandler(this.btnPrintSave_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Image = global::PadaviyaShop.Properties.Resources.Minus_Math__32px;
            this.btnMinimize.Location = new System.Drawing.Point(314, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 29);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = global::PadaviyaShop.Properties.Resources.Cancel_32px;
            this.btnClose.Location = new System.Drawing.Point(347, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(394, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrintSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserID;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}