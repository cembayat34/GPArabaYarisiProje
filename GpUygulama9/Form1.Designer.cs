
namespace GpUygulama9
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
            this.btnArac1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnArac2 = new System.Windows.Forms.Button();
            this.btnArac3 = new System.Windows.Forms.Button();
            this.btnArac4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericHiz = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHiz)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArac1
            // 
            this.btnArac1.BackColor = System.Drawing.SystemColors.Control;
            this.btnArac1.ImageIndex = 4;
            this.btnArac1.ImageList = this.ımageList1;
            this.btnArac1.Location = new System.Drawing.Point(12, 115);
            this.btnArac1.Name = "btnArac1";
            this.btnArac1.Size = new System.Drawing.Size(90, 38);
            this.btnArac1.TabIndex = 0;
            this.btnArac1.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kirmiziArac1.jpg");
            this.ımageList1.Images.SetKeyName(1, "maviArac.jpg");
            this.ımageList1.Images.SetKeyName(2, "turuncuArac.jpg");
            this.ımageList1.Images.SetKeyName(3, "yesilArac.jpg");
            this.ımageList1.Images.SetKeyName(4, "car.png");
            this.ımageList1.Images.SetKeyName(5, "checkered-flag.png");
            // 
            // btnArac2
            // 
            this.btnArac2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnArac2.ImageIndex = 4;
            this.btnArac2.ImageList = this.ımageList1;
            this.btnArac2.Location = new System.Drawing.Point(12, 169);
            this.btnArac2.Name = "btnArac2";
            this.btnArac2.Size = new System.Drawing.Size(90, 38);
            this.btnArac2.TabIndex = 1;
            this.btnArac2.UseVisualStyleBackColor = false;
            // 
            // btnArac3
            // 
            this.btnArac3.ImageIndex = 4;
            this.btnArac3.ImageList = this.ımageList1;
            this.btnArac3.Location = new System.Drawing.Point(12, 255);
            this.btnArac3.Name = "btnArac3";
            this.btnArac3.Size = new System.Drawing.Size(90, 38);
            this.btnArac3.TabIndex = 2;
            this.btnArac3.UseVisualStyleBackColor = true;
            // 
            // btnArac4
            // 
            this.btnArac4.ImageIndex = 4;
            this.btnArac4.ImageList = this.ımageList1;
            this.btnArac4.Location = new System.Drawing.Point(12, 309);
            this.btnArac4.Name = "btnArac4";
            this.btnArac4.Size = new System.Drawing.Size(90, 38);
            this.btnArac4.TabIndex = 3;
            this.btnArac4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericHiz);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 98);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(838, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hiz";
            // 
            // numericHiz
            // 
            this.numericHiz.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericHiz.Location = new System.Drawing.Point(724, 28);
            this.numericHiz.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericHiz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHiz.Name = "numericHiz";
            this.numericHiz.Size = new System.Drawing.Size(108, 40);
            this.numericHiz.TabIndex = 1;
            this.numericHiz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHiz.ValueChanged += new System.EventHandler(this.numericHiz_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(11, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yarisi Baslat";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 100);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(347, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araba Yarisi";
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 271);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(1013, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 271);
            this.panel4.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 465);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnArac4);
            this.Controls.Add(this.btnArac3);
            this.Controls.Add(this.btnArac2);
            this.Controls.Add(this.btnArac1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHiz)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArac1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnArac2;
        private System.Windows.Forms.Button btnArac3;
        private System.Windows.Forms.Button btnArac4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericHiz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

