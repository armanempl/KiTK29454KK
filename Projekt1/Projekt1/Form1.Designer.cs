
namespace Projekt1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PubFileSelect = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.PubFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.PubKeyPath = new System.Windows.Forms.TextBox();
            this.PrivKeyPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PubKeySelect = new System.Windows.Forms.Button();
            this.PrivKeySelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PrivFilePath = new System.Windows.Forms.TextBox();
            this.PrivFileSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // PubFileSelect
            // 
            this.PubFileSelect.AllowDrop = true;
            this.PubFileSelect.Location = new System.Drawing.Point(132, 117);
            this.PubFileSelect.Name = "PubFileSelect";
            this.PubFileSelect.Size = new System.Drawing.Size(108, 23);
            this.PubFileSelect.TabIndex = 0;
            this.PubFileSelect.Text = "Wybierz plik...";
            this.PubFileSelect.UseVisualStyleBackColor = true;
            this.PubFileSelect.Click += new System.EventHandler(this.PubFileSelect_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(128, 245);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Szyfruj";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(593, 244);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 2;
            this.buttonDecrypt.Text = "Odszyfruj";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.button3_Click);
            // 
            // PubFilePath
            // 
            this.PubFilePath.Location = new System.Drawing.Point(83, 88);
            this.PubFilePath.Name = "PubFilePath";
            this.PubFilePath.Size = new System.Drawing.Size(204, 23);
            this.PubFilePath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wybierz plik do zaszyfrowania lub odszyfrowania z wykorzystaniem szyfrowania RSA:" +
    "";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.MaximumSize = new System.Drawing.Size(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 2);
            this.label4.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 47);
            this.button4.TabIndex = 10;
            this.button4.Text = "Wygeneruj klucz publiczny";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(556, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 47);
            this.button5.TabIndex = 11;
            this.button5.Text = "Wygeneruj klucz prywatny";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(331, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PubKeyPath
            // 
            this.PubKeyPath.Location = new System.Drawing.Point(83, 172);
            this.PubKeyPath.Name = "PubKeyPath";
            this.PubKeyPath.Size = new System.Drawing.Size(204, 23);
            this.PubKeyPath.TabIndex = 13;
            // 
            // PrivKeyPath
            // 
            this.PrivKeyPath.Location = new System.Drawing.Point(494, 171);
            this.PrivKeyPath.Name = "PrivKeyPath";
            this.PrivKeyPath.Size = new System.Drawing.Size(202, 23);
            this.PrivKeyPath.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(83, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wskaż lokalizację klucza publicznego:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(494, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wskaż lokalizację klucza prywatnego:";
            // 
            // PubKeySelect
            // 
            this.PubKeySelect.Location = new System.Drawing.Point(119, 201);
            this.PubKeySelect.Name = "PubKeySelect";
            this.PubKeySelect.Size = new System.Drawing.Size(136, 23);
            this.PubKeySelect.TabIndex = 17;
            this.PubKeySelect.Text = "Wybierz plik...";
            this.PubKeySelect.UseVisualStyleBackColor = true;
            this.PubKeySelect.Click += new System.EventHandler(this.PubKeyPath_Click);
            // 
            // PrivKeySelect
            // 
            this.PrivKeySelect.Location = new System.Drawing.Point(529, 200);
            this.PrivKeySelect.Name = "PrivKeySelect";
            this.PrivKeySelect.Size = new System.Drawing.Size(130, 23);
            this.PrivKeySelect.TabIndex = 18;
            this.PrivKeySelect.Text = "Wybierz plik...";
            this.PrivKeySelect.UseVisualStyleBackColor = true;
            this.PrivKeySelect.Click += new System.EventHandler(this.PrivKeyPath_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.MaximumSize = new System.Drawing.Size(0, 2);
            this.label5.MinimumSize = new System.Drawing.Size(0, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 2);
            this.label5.TabIndex = 19;
            // 
            // PrivFilePath
            // 
            this.PrivFilePath.Location = new System.Drawing.Point(492, 88);
            this.PrivFilePath.Name = "PrivFilePath";
            this.PrivFilePath.Size = new System.Drawing.Size(204, 23);
            this.PrivFilePath.TabIndex = 20;
            // 
            // PrivFileSelect
            // 
            this.PrivFileSelect.AllowDrop = true;
            this.PrivFileSelect.Location = new System.Drawing.Point(529, 117);
            this.PrivFileSelect.Name = "PrivFileSelect";
            this.PrivFileSelect.Size = new System.Drawing.Size(108, 23);
            this.PrivFileSelect.TabIndex = 21;
            this.PrivFileSelect.Text = "Wybierz plik...";
            this.PrivFileSelect.UseVisualStyleBackColor = true;
            this.PrivFileSelect.Click += new System.EventHandler(this.PrivFileSelect_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.MaximumSize = new System.Drawing.Size(0, 2);
            this.label6.MinimumSize = new System.Drawing.Size(0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 2);
            this.label6.TabIndex = 22;
            this.label6.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrivFileSelect);
            this.Controls.Add(this.PrivFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrivKeySelect);
            this.Controls.Add(this.PubKeySelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrivKeyPath);
            this.Controls.Add(this.PubKeyPath);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PubFilePath);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.PubFileSelect);
            this.Name = "Form1";
            this.Text = "deSZYfrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        protected System.Windows.Forms.Button PubFileSelect;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox PubFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TextBox PubKeyPath;
        private System.Windows.Forms.TextBox PrivKeyPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PubKeySelect;
        private System.Windows.Forms.Button PrivKeySelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrivFilePath;
        protected System.Windows.Forms.Button PrivFileSelect;
        private System.Windows.Forms.Label label6;
    }
}

