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
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
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
            this.bt2.Location = new System.Drawing.Point(869, 12);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(86, 81);
            this.bt2.TabIndex = 3;
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Image = global::WindowsFormsApplication3.Properties.Resources.Untitled1;
            this.bt5.Location = new System.Drawing.Point(314, 160);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(324, 213);
            this.bt5.TabIndex = 2;
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt1
            // 
            this.bt1.Image = global::WindowsFormsApplication3.Properties.Resources.maybay_jpg;
            this.bt1.Location = new System.Drawing.Point(12, 470);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(86, 81);
            this.bt1.TabIndex = 1;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptb1
            // 
            this.ptb1.Image = global::WindowsFormsApplication3.Properties.Resources.Untitled3;
            this.ptb1.Location = new System.Drawing.Point(12, 12);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(943, 539);
            this.ptb1.TabIndex = 0;
            this.ptb1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 549);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.ptb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
    }
}

