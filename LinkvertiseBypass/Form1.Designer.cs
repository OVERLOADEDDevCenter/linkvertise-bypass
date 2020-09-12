namespace LinkvertiseBypass
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetURL = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Wait = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PasteURL = new System.Windows.Forms.Button();
            this.CopyURL = new System.Windows.Forms.Button();
            this.loadingGIF = new System.Windows.Forms.PictureBox();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetURL
            // 
            this.GetURL.BackColor = System.Drawing.Color.Transparent;
            this.GetURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GetURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetURL.FlatAppearance.BorderSize = 0;
            this.GetURL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GetURL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GetURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetURL.ForeColor = System.Drawing.Color.White;
            this.GetURL.Location = new System.Drawing.Point(280, 243);
            this.GetURL.Name = "GetURL";
            this.GetURL.Size = new System.Drawing.Size(173, 54);
            this.GetURL.TabIndex = 0;
            this.GetURL.Text = "SEARCH";
            this.GetURL.UseVisualStyleBackColor = false;
            this.GetURL.Click += new System.EventHandler(this.GetURL_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.Location = new System.Drawing.Point(32, 72);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(421, 31);
            this.Input.TabIndex = 1;
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Output.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Output.Location = new System.Drawing.Point(88, 285);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(42, 25);
            this.Output.TabIndex = 2;
            this.Output.Visible = false;
            // 
            // Wait
            // 
            this.Wait.Enabled = false;
            this.Wait.Location = new System.Drawing.Point(66, 285);
            this.Wait.MarqueeAnimationSpeed = 0;
            this.Wait.Name = "Wait";
            this.Wait.Size = new System.Drawing.Size(16, 36);
            this.Wait.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Wait.TabIndex = 5;
            this.Wait.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(274, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Made by OVERLOADED#4246";
            // 
            // PasteURL
            // 
            this.PasteURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PasteURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasteURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasteURL.FlatAppearance.BorderSize = 0;
            this.PasteURL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PasteURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteURL.ForeColor = System.Drawing.Color.White;
            this.PasteURL.Location = new System.Drawing.Point(12, 72);
            this.PasteURL.Name = "PasteURL";
            this.PasteURL.Size = new System.Drawing.Size(441, 31);
            this.PasteURL.TabIndex = 7;
            this.PasteURL.Text = "PASTE";
            this.PasteURL.UseVisualStyleBackColor = false;
            this.PasteURL.Click += new System.EventHandler(this.PasteURL_Click);
            // 
            // CopyURL
            // 
            this.CopyURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CopyURL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CopyURL.BackgroundImage")));
            this.CopyURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyURL.FlatAppearance.BorderSize = 0;
            this.CopyURL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CopyURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyURL.ForeColor = System.Drawing.Color.White;
            this.CopyURL.Location = new System.Drawing.Point(408, 129);
            this.CopyURL.Name = "CopyURL";
            this.CopyURL.Size = new System.Drawing.Size(45, 42);
            this.CopyURL.TabIndex = 8;
            this.CopyURL.UseVisualStyleBackColor = false;
            this.CopyURL.Click += new System.EventHandler(this.CopyURL_Click);
            // 
            // loadingGIF
            // 
            this.loadingGIF.Image = ((System.Drawing.Image)(resources.GetObject("loadingGIF.Image")));
            this.loadingGIF.Location = new System.Drawing.Point(7, 243);
            this.loadingGIF.Name = "loadingGIF";
            this.loadingGIF.Size = new System.Drawing.Size(56, 54);
            this.loadingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingGIF.TabIndex = 9;
            this.loadingGIF.TabStop = false;
            this.loadingGIF.Visible = false;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ResultBox.DetectUrls = false;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResultBox.Location = new System.Drawing.Point(12, 129);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ResultBox.ShortcutsEnabled = false;
            this.ResultBox.Size = new System.Drawing.Size(441, 108);
            this.ResultBox.TabIndex = 10;
            this.ResultBox.Text = "";
            this.ResultBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ResultBox_LinkClicked);
            this.ResultBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultBox_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 30F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(305, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bypass";
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open.BackgroundImage")));
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(364, 129);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(45, 42);
            this.Open.TabIndex = 13;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(13, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 42);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(13, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 13);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(465, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CopyURL);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingGIF);
            this.Controls.Add(this.PasteURL);
            this.Controls.Add(this.Wait);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.GetURL);
            this.Controls.Add(this.ResultBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LinkvertiseBypass";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.loadingGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetURL;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.ProgressBar Wait;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PasteURL;
        private System.Windows.Forms.Button CopyURL;
        private System.Windows.Forms.PictureBox loadingGIF;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

