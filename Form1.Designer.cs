namespace Lab3
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
            this.OG = new Emgu.CV.UI.ImageBox();
            this.Load = new System.Windows.Forms.Button();
            this.TextFromImg = new System.Windows.Forms.ListBox();
            this.Res = new Emgu.CV.UI.ImageBox();
            this.FindText = new System.Windows.Forms.Button();
            this.Language = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.OG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Res)).BeginInit();
            this.SuspendLayout();
            // 
            // OG
            // 
            this.OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OG.Location = new System.Drawing.Point(13, 12);
            this.OG.Name = "OG";
            this.OG.Size = new System.Drawing.Size(444, 256);
            this.OG.TabIndex = 2;
            this.OG.TabStop = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(483, 20);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(150, 45);
            this.Load.TabIndex = 4;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // TextFromImg
            // 
            this.TextFromImg.FormattingEnabled = true;
            this.TextFromImg.HorizontalScrollbar = true;
            this.TextFromImg.ItemHeight = 16;
            this.TextFromImg.Location = new System.Drawing.Point(483, 163);
            this.TextFromImg.Name = "TextFromImg";
            this.TextFromImg.Size = new System.Drawing.Size(325, 308);
            this.TextFromImg.TabIndex = 5;
            // 
            // Res
            // 
            this.Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Res.Location = new System.Drawing.Point(13, 294);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(444, 256);
            this.Res.TabIndex = 6;
            this.Res.TabStop = false;
            // 
            // FindText
            // 
            this.FindText.Location = new System.Drawing.Point(570, 96);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(150, 45);
            this.FindText.TabIndex = 7;
            this.FindText.Text = "Find Text";
            this.FindText.UseVisualStyleBackColor = true;
            this.FindText.Click += new System.EventHandler(this.FindText_Click);
            // 
            // Language
            // 
            this.Language.FormattingEnabled = true;
            this.Language.Items.AddRange(new object[] {
            "Eng",
            "Rus"});
            this.Language.Location = new System.Drawing.Point(687, 31);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(121, 24);
            this.Language.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 583);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.FindText);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.TextFromImg);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.OG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Res)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox OG;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.ListBox TextFromImg;
        private Emgu.CV.UI.ImageBox Res;
        private System.Windows.Forms.Button FindText;
        private System.Windows.Forms.ComboBox Language;
    }
}

