namespace M11_ProjectGame
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.tick_game = new System.Windows.Forms.Timer(this.components);
            this.pnl_Screen = new System.Windows.Forms.Panel();
            this.p2_Head = new System.Windows.Forms.PictureBox();
            this.p1_Head = new System.Windows.Forms.PictureBox();
            this.lbl_p2score = new System.Windows.Forms.Label();
            this.lbl_p1score = new System.Windows.Forms.Label();
            this.pb_p2HP = new System.Windows.Forms.ProgressBar();
            this.pb_p1HP = new System.Windows.Forms.ProgressBar();
            this.lbl_fps = new System.Windows.Forms.Label();
            this.p2_Bullet = new System.Windows.Forms.PictureBox();
            this.p1_Bullet = new System.Windows.Forms.PictureBox();
            this.obj_ground3 = new System.Windows.Forms.PictureBox();
            this.obj_ground2 = new System.Windows.Forms.PictureBox();
            this.obj_ground4 = new System.Windows.Forms.PictureBox();
            this.obj_ground1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.pnl_Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Location = new System.Drawing.Point(11, 705);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(50, 50);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.Tag = "p1";
            // 
            // tick_game
            // 
            this.tick_game.Tick += new System.EventHandler(this.tick_game_Tick);
            // 
            // pnl_Screen
            // 
            this.pnl_Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Screen.Controls.Add(this.p2_Head);
            this.pnl_Screen.Controls.Add(this.p1_Head);
            this.pnl_Screen.Controls.Add(this.lbl_p2score);
            this.pnl_Screen.Controls.Add(this.lbl_p1score);
            this.pnl_Screen.Controls.Add(this.pb_p2HP);
            this.pnl_Screen.Controls.Add(this.pb_p1HP);
            this.pnl_Screen.Controls.Add(this.lbl_fps);
            this.pnl_Screen.Controls.Add(this.p2_Bullet);
            this.pnl_Screen.Controls.Add(this.p1_Bullet);
            this.pnl_Screen.Controls.Add(this.obj_ground3);
            this.pnl_Screen.Controls.Add(this.obj_ground2);
            this.pnl_Screen.Controls.Add(this.obj_ground4);
            this.pnl_Screen.Controls.Add(this.obj_ground1);
            this.pnl_Screen.Controls.Add(this.p1);
            this.pnl_Screen.Controls.Add(this.p2);
            this.pnl_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Screen.Location = new System.Drawing.Point(0, 0);
            this.pnl_Screen.Name = "pnl_Screen";
            this.pnl_Screen.Size = new System.Drawing.Size(1024, 768);
            this.pnl_Screen.TabIndex = 1;
            // 
            // p2_Head
            // 
            this.p2_Head.Image = global::M11_ProjectGame.Properties.Resources.p2;
            this.p2_Head.Location = new System.Drawing.Point(974, 683);
            this.p2_Head.Name = "p2_Head";
            this.p2_Head.Size = new System.Drawing.Size(25, 25);
            this.p2_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2_Head.TabIndex = 7;
            this.p2_Head.TabStop = false;
            // 
            // p1_Head
            // 
            this.p1_Head.Image = global::M11_ProjectGame.Properties.Resources.p1;
            this.p1_Head.Location = new System.Drawing.Point(23, 683);
            this.p1_Head.Name = "p1_Head";
            this.p1_Head.Size = new System.Drawing.Size(25, 25);
            this.p1_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1_Head.TabIndex = 7;
            this.p1_Head.TabStop = false;
            // 
            // lbl_p2score
            // 
            this.lbl_p2score.AutoSize = true;
            this.lbl_p2score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p2score.Font = new System.Drawing.Font("Arista", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2score.Location = new System.Drawing.Point(941, 41);
            this.lbl_p2score.Name = "lbl_p2score";
            this.lbl_p2score.Size = new System.Drawing.Size(70, 17);
            this.lbl_p2score.TabIndex = 6;
            this.lbl_p2score.Text = "Score: 0";
            // 
            // lbl_p1score
            // 
            this.lbl_p1score.AutoSize = true;
            this.lbl_p1score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p1score.Font = new System.Drawing.Font("Arista", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1score.Location = new System.Drawing.Point(7, 41);
            this.lbl_p1score.Name = "lbl_p1score";
            this.lbl_p1score.Size = new System.Drawing.Size(70, 17);
            this.lbl_p1score.TabIndex = 6;
            this.lbl_p1score.Text = "Score: 0";
            // 
            // pb_p2HP
            // 
            this.pb_p2HP.Location = new System.Drawing.Point(932, 3);
            this.pb_p2HP.Name = "pb_p2HP";
            this.pb_p2HP.Size = new System.Drawing.Size(79, 23);
            this.pb_p2HP.TabIndex = 5;
            this.pb_p2HP.Tag = "hp";
            this.pb_p2HP.Value = 100;
            // 
            // pb_p1HP
            // 
            this.pb_p1HP.BackColor = System.Drawing.Color.Red;
            this.pb_p1HP.ForeColor = System.Drawing.Color.Red;
            this.pb_p1HP.Location = new System.Drawing.Point(11, 3);
            this.pb_p1HP.Name = "pb_p1HP";
            this.pb_p1HP.Size = new System.Drawing.Size(79, 23);
            this.pb_p1HP.TabIndex = 5;
            this.pb_p1HP.Tag = "hp";
            this.pb_p1HP.Value = 100;
            // 
            // lbl_fps
            // 
            this.lbl_fps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fps.AutoSize = true;
            this.lbl_fps.Font = new System.Drawing.Font("Arista", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fps.Location = new System.Drawing.Point(491, 9);
            this.lbl_fps.Name = "lbl_fps";
            this.lbl_fps.Size = new System.Drawing.Size(49, 17);
            this.lbl_fps.TabIndex = 3;
            this.lbl_fps.Text = "FPS:0";
            // 
            // p2_Bullet
            // 
            this.p2_Bullet.BackColor = System.Drawing.Color.Silver;
            this.p2_Bullet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2_Bullet.Location = new System.Drawing.Point(932, 28);
            this.p2_Bullet.Name = "p2_Bullet";
            this.p2_Bullet.Size = new System.Drawing.Size(79, 10);
            this.p2_Bullet.TabIndex = 2;
            this.p2_Bullet.TabStop = false;
            // 
            // p1_Bullet
            // 
            this.p1_Bullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.p1_Bullet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1_Bullet.Location = new System.Drawing.Point(11, 28);
            this.p1_Bullet.Name = "p1_Bullet";
            this.p1_Bullet.Size = new System.Drawing.Size(79, 10);
            this.p1_Bullet.TabIndex = 2;
            this.p1_Bullet.TabStop = false;
            // 
            // obj_ground3
            // 
            this.obj_ground3.BackColor = System.Drawing.Color.Lime;
            this.obj_ground3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obj_ground3.Location = new System.Drawing.Point(921, 446);
            this.obj_ground3.Name = "obj_ground3";
            this.obj_ground3.Size = new System.Drawing.Size(102, 50);
            this.obj_ground3.TabIndex = 4;
            this.obj_ground3.TabStop = false;
            this.obj_ground3.Tag = "obj";
            // 
            // obj_ground2
            // 
            this.obj_ground2.BackColor = System.Drawing.Color.Lime;
            this.obj_ground2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obj_ground2.Location = new System.Drawing.Point(-1, 446);
            this.obj_ground2.Name = "obj_ground2";
            this.obj_ground2.Size = new System.Drawing.Size(102, 50);
            this.obj_ground2.TabIndex = 4;
            this.obj_ground2.TabStop = false;
            this.obj_ground2.Tag = "obj";
            // 
            // obj_ground4
            // 
            this.obj_ground4.BackColor = System.Drawing.Color.Lime;
            this.obj_ground4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obj_ground4.Location = new System.Drawing.Point(213, 286);
            this.obj_ground4.Name = "obj_ground4";
            this.obj_ground4.Size = new System.Drawing.Size(601, 50);
            this.obj_ground4.TabIndex = 4;
            this.obj_ground4.TabStop = false;
            this.obj_ground4.Tag = "obj";
            // 
            // obj_ground1
            // 
            this.obj_ground1.BackColor = System.Drawing.Color.Lime;
            this.obj_ground1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obj_ground1.Location = new System.Drawing.Point(213, 581);
            this.obj_ground1.Name = "obj_ground1";
            this.obj_ground1.Size = new System.Drawing.Size(601, 50);
            this.obj_ground1.TabIndex = 4;
            this.obj_ground1.TabStop = false;
            this.obj_ground1.Tag = "obj";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Silver;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2.Location = new System.Drawing.Point(962, 706);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(50, 50);
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            this.p2.Tag = "p2";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pnl_Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.pnl_Screen.ResumeLayout(false);
            this.pnl_Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obj_ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Timer tick_game;
        private System.Windows.Forms.Panel pnl_Screen;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1_Bullet;
        private System.Windows.Forms.PictureBox p2_Bullet;
        private System.Windows.Forms.Label lbl_fps;
        private System.Windows.Forms.PictureBox obj_ground1;
        private System.Windows.Forms.PictureBox obj_ground3;
        private System.Windows.Forms.PictureBox obj_ground2;
        private System.Windows.Forms.PictureBox obj_ground4;
        private System.Windows.Forms.ProgressBar pb_p2HP;
        private System.Windows.Forms.ProgressBar pb_p1HP;
        private System.Windows.Forms.Label lbl_p2score;
        private System.Windows.Forms.Label lbl_p1score;
        private System.Windows.Forms.PictureBox p2_Head;
        private System.Windows.Forms.PictureBox p1_Head;
    }
}

