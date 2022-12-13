
namespace AES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateKeyIV = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.RichTextBox();
            this.AESOutput = new System.Windows.Forms.RichTextBox();
            this.KeyText = new System.Windows.Forms.RichTextBox();
            this.IVText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateKeyIV
            // 
            this.GenerateKeyIV.Location = new System.Drawing.Point(306, 12);
            this.GenerateKeyIV.Name = "GenerateKeyIV";
            this.GenerateKeyIV.Size = new System.Drawing.Size(170, 37);
            this.GenerateKeyIV.TabIndex = 0;
            this.GenerateKeyIV.Text = "Wygeneruj Key i IV";
            this.GenerateKeyIV.UseVisualStyleBackColor = true;
            this.GenerateKeyIV.Click += new System.EventHandler(this.GenerateKeyIV_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(363, 289);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 1;
            this.EncryptButton.Text = "Szyfruj";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(363, 415);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Odszyfruj";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(128, 212);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(540, 71);
            this.UserInput.TabIndex = 3;
            this.UserInput.Text = "";
            // 
            // AESOutput
            // 
            this.AESOutput.Location = new System.Drawing.Point(128, 341);
            this.AESOutput.Name = "AESOutput";
            this.AESOutput.Size = new System.Drawing.Size(540, 68);
            this.AESOutput.TabIndex = 4;
            this.AESOutput.Text = "";
            // 
            // KeyText
            // 
            this.KeyText.Location = new System.Drawing.Point(128, 93);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(222, 79);
            this.KeyText.TabIndex = 5;
            this.KeyText.Text = "";
            // 
            // IVText
            // 
            this.IVText.Location = new System.Drawing.Point(429, 93);
            this.IVText.Name = "IVText";
            this.IVText.Size = new System.Drawing.Size(239, 79);
            this.IVText.TabIndex = 6;
            this.IVText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(306, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wprowadź poniżej tekst do zaszyfrowania:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(128, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(432, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "IV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(248, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opcjonalnie: wprowadź w polu powyżej tekst do odszyfrowania:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IVText);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.AESOutput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.GenerateKeyIV);
            this.Name = "Form1";
            this.Text = "AESzyfrator v0.0.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateKeyIV;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.RichTextBox UserInput;
        private System.Windows.Forms.RichTextBox AESOutput;
        private System.Windows.Forms.RichTextBox KeyText;
        private System.Windows.Forms.RichTextBox IVText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

