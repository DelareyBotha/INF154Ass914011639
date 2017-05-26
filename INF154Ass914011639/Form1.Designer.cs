namespace INF154Ass914011639
{
    partial class INF154Ass9
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnMarsSpeak = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.msStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdInput = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.msStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(11, 41);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(400, 338);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbInput_KeyPress);
            // 
            // btnMarsSpeak
            // 
            this.btnMarsSpeak.Location = new System.Drawing.Point(161, 385);
            this.btnMarsSpeak.Name = "btnMarsSpeak";
            this.btnMarsSpeak.Size = new System.Drawing.Size(82, 23);
            this.btnMarsSpeak.TabIndex = 2;
            this.btnMarsSpeak.Text = "MarsSpeak";
            this.btnMarsSpeak.UseVisualStyleBackColor = true;
            this.btnMarsSpeak.Click += new System.EventHandler(this.btnMarsSpeak_Click);
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Location = new System.Drawing.Point(306, 385);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(75, 23);
            this.btnPalindrome.TabIndex = 3;
            this.btnPalindrome.Text = "Palindrome";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            this.btnPalindrome.Click += new System.EventHandler(this.btnPalindrome_Click);
            // 
            // msStrip
            // 
            this.msStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msStrip.Location = new System.Drawing.Point(0, 0);
            this.msStrip.Name = "msStrip";
            this.msStrip.Size = new System.Drawing.Size(435, 24);
            this.msStrip.TabIndex = 4;
            this.msStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Tools";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // ofdInput
            // 
            this.ofdInput.FileName = "openFileDialog1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(23, 385);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // INF154Ass9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 431);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.btnMarsSpeak);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.msStrip);
            this.MainMenuStrip = this.msStrip;
            this.Name = "INF154Ass9";
            this.Text = "INF154Ass9";
            this.msStrip.ResumeLayout(false);
            this.msStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnMarsSpeak;
        private System.Windows.Forms.Button btnPalindrome;
        private System.Windows.Forms.MenuStrip msStrip;
        private System.Windows.Forms.OpenFileDialog ofdInput;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button btnLoad;
    }
}

