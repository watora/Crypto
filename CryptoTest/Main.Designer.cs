namespace CryptoTest
{
    partial class Main
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
            this.GenerateKeyPair = new System.Windows.Forms.Button();
            this.privateKeyText = new System.Windows.Forms.RichTextBox();
            this.publicKeyText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataText = new System.Windows.Forms.RichTextBox();
            this.ContentText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateKeyPair
            // 
            this.GenerateKeyPair.Location = new System.Drawing.Point(660, 32);
            this.GenerateKeyPair.Name = "GenerateKeyPair";
            this.GenerateKeyPair.Size = new System.Drawing.Size(113, 51);
            this.GenerateKeyPair.TabIndex = 0;
            this.GenerateKeyPair.Text = "生成密钥对";
            this.GenerateKeyPair.UseVisualStyleBackColor = true;
            this.GenerateKeyPair.Click += new System.EventHandler(this.GenerateKeyPair_Click);
            // 
            // privateKeyText
            // 
            this.privateKeyText.Location = new System.Drawing.Point(80, 32);
            this.privateKeyText.Name = "privateKeyText";
            this.privateKeyText.Size = new System.Drawing.Size(550, 80);
            this.privateKeyText.TabIndex = 1;
            this.privateKeyText.Text = "";
            // 
            // publicKeyText
            // 
            this.publicKeyText.Location = new System.Drawing.Point(80, 138);
            this.publicKeyText.Name = "publicKeyText";
            this.publicKeyText.Size = new System.Drawing.Size(550, 80);
            this.publicKeyText.TabIndex = 2;
            this.publicKeyText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "私钥";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "公钥";
            // 
            // DataText
            // 
            this.DataText.Location = new System.Drawing.Point(80, 238);
            this.DataText.Name = "DataText";
            this.DataText.Size = new System.Drawing.Size(550, 80);
            this.DataText.TabIndex = 5;
            this.DataText.Text = "";
            // 
            // ContentText
            // 
            this.ContentText.Location = new System.Drawing.Point(80, 343);
            this.ContentText.Name = "ContentText";
            this.ContentText.Size = new System.Drawing.Size(550, 80);
            this.ContentText.TabIndex = 6;
            this.ContentText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "原文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "密文";
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(660, 238);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(113, 51);
            this.Encrypt.TabIndex = 9;
            this.Encrypt.Text = "加密";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(660, 343);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(113, 51);
            this.Decrypt.TabIndex = 10;
            this.Decrypt.Text = "解密";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 477);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContentText);
            this.Controls.Add(this.DataText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publicKeyText);
            this.Controls.Add(this.privateKeyText);
            this.Controls.Add(this.GenerateKeyPair);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateKeyPair;
        private System.Windows.Forms.RichTextBox privateKeyText;
        private System.Windows.Forms.RichTextBox publicKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox DataText;
        private System.Windows.Forms.RichTextBox ContentText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
    }
}
