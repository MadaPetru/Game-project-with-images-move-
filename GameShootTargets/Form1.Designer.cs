namespace GameShootTargets
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctTun = new System.Windows.Forms.PictureBox();
            this.pctJokerGalati = new System.Windows.Forms.PictureBox();
            this.pctBatman = new System.Windows.Forms.PictureBox();
            this.timerTun = new System.Windows.Forms.Timer(this.components);
            this.timerBatman = new System.Windows.Forms.Timer(this.components);
            this.timerJokerDeGalati = new System.Windows.Forms.Timer(this.components);
            this.btnShoot = new System.Windows.Forms.Button();
            this.txtPunctaj = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtScorMaxim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctTun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJokerGalati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBatman)).BeginInit();
            this.SuspendLayout();
            // 
            // pctTun
            // 
            this.pctTun.Image = ((System.Drawing.Image)(resources.GetObject("pctTun.Image")));
            this.pctTun.Location = new System.Drawing.Point(1049, 0);
            this.pctTun.Name = "pctTun";
            this.pctTun.Size = new System.Drawing.Size(214, 56);
            this.pctTun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTun.TabIndex = 0;
            this.pctTun.TabStop = false;
            this.pctTun.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctJokerGalati
            // 
            this.pctJokerGalati.Image = ((System.Drawing.Image)(resources.GetObject("pctJokerGalati.Image")));
            this.pctJokerGalati.Location = new System.Drawing.Point(1, 0);
            this.pctJokerGalati.Name = "pctJokerGalati";
            this.pctJokerGalati.Size = new System.Drawing.Size(150, 135);
            this.pctJokerGalati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctJokerGalati.TabIndex = 1;
            this.pctJokerGalati.TabStop = false;
            this.pctJokerGalati.Click += new System.EventHandler(this.pctJokerGalati_Click);
            // 
            // pctBatman
            // 
            this.pctBatman.Image = ((System.Drawing.Image)(resources.GetObject("pctBatman.Image")));
            this.pctBatman.Location = new System.Drawing.Point(1, 448);
            this.pctBatman.Name = "pctBatman";
            this.pctBatman.Size = new System.Drawing.Size(150, 135);
            this.pctBatman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBatman.TabIndex = 2;
            this.pctBatman.TabStop = false;
            this.pctBatman.Click += new System.EventHandler(this.pctBatman_Click);
            // 
            // timerTun
            // 
            this.timerTun.Interval = 1;
            this.timerTun.Tick += new System.EventHandler(this.timerTun_Tick);
            // 
            // timerBatman
            // 
            this.timerBatman.Interval = 1;
            this.timerBatman.Tick += new System.EventHandler(this.timerBatman_Tick);
            // 
            // timerJokerDeGalati
            // 
            this.timerJokerDeGalati.Interval = 1;
            this.timerJokerDeGalati.Tick += new System.EventHandler(this.timerJokerDeGalati_Tick);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(1104, 523);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(159, 60);
            this.btnShoot.TabIndex = 3;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // txtPunctaj
            // 
            this.txtPunctaj.BackColor = System.Drawing.SystemColors.Info;
            this.txtPunctaj.Location = new System.Drawing.Point(998, 523);
            this.txtPunctaj.Multiline = true;
            this.txtPunctaj.Name = "txtPunctaj";
            this.txtPunctaj.ReadOnly = true;
            this.txtPunctaj.Size = new System.Drawing.Size(100, 22);
            this.txtPunctaj.TabIndex = 4;
            this.txtPunctaj.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(816, 523);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 60);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(651, 523);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(159, 60);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Pauza";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtScorMaxim
            // 
            this.txtScorMaxim.BackColor = System.Drawing.SystemColors.Info;
            this.txtScorMaxim.Location = new System.Drawing.Point(998, 552);
            this.txtScorMaxim.Name = "txtScorMaxim";
            this.txtScorMaxim.ReadOnly = true;
            this.txtScorMaxim.Size = new System.Drawing.Size(100, 22);
            this.txtScorMaxim.TabIndex = 7;
            this.txtScorMaxim.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 586);
            this.Controls.Add(this.txtScorMaxim);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPunctaj);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.pctBatman);
            this.Controls.Add(this.pctJokerGalati);
            this.Controls.Add(this.pctTun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctTun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJokerGalati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBatman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctTun;
        private System.Windows.Forms.PictureBox pctJokerGalati;
        private System.Windows.Forms.PictureBox pctBatman;
        private System.Windows.Forms.Timer timerTun;
        private System.Windows.Forms.Timer timerBatman;
        private System.Windows.Forms.Timer timerJokerDeGalati;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.TextBox txtPunctaj;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtScorMaxim;
    }
}

