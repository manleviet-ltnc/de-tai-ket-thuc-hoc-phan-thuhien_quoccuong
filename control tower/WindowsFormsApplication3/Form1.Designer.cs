namespace WindowsFormsApplication3
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
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBatDau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt4
            // 
            this.bt4.Image = global::WindowsFormsApplication3.Properties.Resources.Untitled4;
            this.bt4.Location = new System.Drawing.Point(491, 254);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(119, 99);
            this.bt4.TabIndex = 5;
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Image = global::WindowsFormsApplication3.Properties.Resources.Untitled5;
            this.bt3.Location = new System.Drawing.Point(331, 178);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(76, 45);
            this.bt3.TabIndex = 4;
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Image = global::WindowsFormsApplication3.Properties.Resources.Untitled6;
            this.bt2.Location = new System.Drawing.Point(680, 80);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(138, 105);
            this.bt2.TabIndex = 3;
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Image = global::WindowsFormsApplication3.Properties.Resources.Untitled1;
            this.bt5.Location = new System.Drawing.Point(314, 160);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(320, 213);
            this.bt5.TabIndex = 2;
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Image = global::WindowsFormsApplication3.Properties.Resources.maybay_jpg;
            this.bt1.Location = new System.Drawing.Point(12, 213);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(86, 81);
            this.bt1.TabIndex = 1;
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // ptb1
            // 
            this.ptb1.Image = global::WindowsFormsApplication3.Properties.Resources.Untitled3;
            this.ptb1.Location = new System.Drawing.Point(0, -1);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(956, 539);
            this.ptb1.TabIndex = 0;
            this.ptb1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusScore});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(851, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Score";
            // 
            // toolStripStatusScore
            // 
            this.toolStripStatusScore.Name = "toolStripStatusScore";
            this.toolStripStatusScore.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusScore.Text = "0";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(389, 65);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(198, 50);
            this.btnBatDau.TabIndex = 8;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 502);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.ptb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusScore;
        private System.Windows.Forms.Button btnBatDau;
    }
}

