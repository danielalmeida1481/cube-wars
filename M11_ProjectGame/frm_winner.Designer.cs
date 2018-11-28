namespace M11_ProjectGame
{
    partial class frm_winner
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
            this.pnl_Screen = new System.Windows.Forms.Panel();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.btn_retry = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.pic_Body = new System.Windows.Forms.PictureBox();
            this.pic_Head = new System.Windows.Forms.PictureBox();
            this.pnl_Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Screen
            // 
            this.pnl_Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Screen.Controls.Add(this.pic_Body);
            this.pnl_Screen.Controls.Add(this.pic_Head);
            this.pnl_Screen.Controls.Add(this.btn_mainmenu);
            this.pnl_Screen.Controls.Add(this.btn_retry);
            this.pnl_Screen.Controls.Add(this.lbl_message);
            this.pnl_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Screen.Location = new System.Drawing.Point(0, 0);
            this.pnl_Screen.Name = "pnl_Screen";
            this.pnl_Screen.Size = new System.Drawing.Size(284, 262);
            this.pnl_Screen.TabIndex = 0;
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_mainmenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainmenu.Font = new System.Drawing.Font("Arista", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.ForeColor = System.Drawing.Color.Black;
            this.btn_mainmenu.Location = new System.Drawing.Point(145, 230);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(88, 27);
            this.btn_mainmenu.TabIndex = 2;
            this.btn_mainmenu.Text = "Main Menu";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // btn_retry
            // 
            this.btn_retry.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_retry.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btn_retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retry.Font = new System.Drawing.Font("Arista", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retry.ForeColor = System.Drawing.Color.Black;
            this.btn_retry.Location = new System.Drawing.Point(51, 230);
            this.btn_retry.Name = "btn_retry";
            this.btn_retry.Size = new System.Drawing.Size(88, 27);
            this.btn_retry.TabIndex = 1;
            this.btn_retry.Text = "Retry";
            this.btn_retry.UseVisualStyleBackColor = false;
            this.btn_retry.Click += new System.EventHandler(this.btn_retry_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Arista", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(103, 119);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(76, 17);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "MESSAGE";
            // 
            // pic_Body
            // 
            this.pic_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Body.BackColor = System.Drawing.Color.Transparent;
            this.pic_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Body.Location = new System.Drawing.Point(116, 42);
            this.pic_Body.Name = "pic_Body";
            this.pic_Body.Size = new System.Drawing.Size(50, 50);
            this.pic_Body.TabIndex = 3;
            this.pic_Body.TabStop = false;
            // 
            // pic_Head
            // 
            this.pic_Head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Head.BackColor = System.Drawing.Color.Transparent;
            this.pic_Head.Location = new System.Drawing.Point(129, 20);
            this.pic_Head.Name = "pic_Head";
            this.pic_Head.Size = new System.Drawing.Size(25, 25);
            this.pic_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Head.TabIndex = 4;
            this.pic_Head.TabStop = false;
            // 
            // frm_winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnl_Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_winner_Load);
            this.pnl_Screen.ResumeLayout(false);
            this.pnl_Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Screen;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_retry;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.PictureBox pic_Body;
        private System.Windows.Forms.PictureBox pic_Head;
    }
}