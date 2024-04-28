namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bird = new System.Windows.Forms.PictureBox();
            this.boru_alt = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.boru_ust = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_ust)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(34, 235);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(74, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // boru_alt
            // 
            this.boru_alt.Image = ((System.Drawing.Image)(resources.GetObject("boru_alt.Image")));
            this.boru_alt.Location = new System.Drawing.Point(452, 332);
            this.boru_alt.Name = "boru_alt";
            this.boru_alt.Size = new System.Drawing.Size(90, 180);
            this.boru_alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru_alt.TabIndex = 1;
            this.boru_alt.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = global::FlappyBird.Properties.Resources.zemin;
            this.zemin.Location = new System.Drawing.Point(-1, 512);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(796, 100);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 0;
            this.zemin.TabStop = false;
            // 
            // boru_ust
            // 
            this.boru_ust.Image = ((System.Drawing.Image)(resources.GetObject("boru_ust.Image")));
            this.boru_ust.Location = new System.Drawing.Point(570, -1);
            this.boru_ust.Name = "boru_ust";
            this.boru_ust.Size = new System.Drawing.Size(90, 130);
            this.boru_ust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru_ust.TabIndex = 3;
            this.boru_ust.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "SKOR: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(794, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boru_ust);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.boru_alt);
            this.Controls.Add(this.zemin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_ust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox boru_alt;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox boru_ust;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

