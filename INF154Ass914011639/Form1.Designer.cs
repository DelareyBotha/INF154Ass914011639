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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMarsSpeak = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 338);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 356);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMarsSpeak
            // 
            this.btnMarsSpeak.Location = new System.Drawing.Point(166, 356);
            this.btnMarsSpeak.Name = "btnMarsSpeak";
            this.btnMarsSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnMarsSpeak.TabIndex = 2;
            this.btnMarsSpeak.Text = "Pig latin";
            this.btnMarsSpeak.UseVisualStyleBackColor = true;
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Location = new System.Drawing.Point(337, 356);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(75, 23);
            this.btnPalindrome.TabIndex = 3;
            this.btnPalindrome.Text = "Palindrome";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            // 
            // INF154Ass9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 404);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.btnMarsSpeak);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.richTextBox1);
            this.Name = "INF154Ass9";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMarsSpeak;
        private System.Windows.Forms.Button btnPalindrome;
    }
}

