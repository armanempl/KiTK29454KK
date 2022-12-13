
namespace Base64Converter
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.UserText = new System.Windows.Forms.RichTextBox();
            this.SaveFile = new System.Windows.Forms.Button();
            this.Base64Output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.CovertB64Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(353, 164);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(91, 23);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Konwertuj";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(167, 36);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(466, 96);
            this.UserText.TabIndex = 1;
            this.UserText.Text = "";
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(473, 346);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(116, 23);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "Zapisz do pliku...";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Base64Output
            // 
            this.Base64Output.Location = new System.Drawing.Point(167, 193);
            this.Base64Output.Name = "Base64Output";
            this.Base64Output.Size = new System.Drawing.Size(466, 96);
            this.Base64Output.TabIndex = 5;
            this.Base64Output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wpisz do pola tekstowego poniżej tekst, który ma zostać przekonwertowany:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(184, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wciśnij przycisk \"Konwertuj\", aby przekonwertować wprowadzony tekst do Base64";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(125, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opcjonalnie: Wybierz przycisk \"Zapisz do pliku...\", aby zapisać przekonwertowany " +
    "tekst do pliku tekstowego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(184, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "LUB wciśnij przycisk \"Konwertuj\" poniżej, aby przekonwertować ciąg Base64";
            // 
            // CovertB64Button
            // 
            this.CovertB64Button.Location = new System.Drawing.Point(195, 346);
            this.CovertB64Button.Name = "CovertB64Button";
            this.CovertB64Button.Size = new System.Drawing.Size(75, 23);
            this.CovertB64Button.TabIndex = 10;
            this.CovertB64Button.Text = "Konwertuj";
            this.CovertB64Button.UseVisualStyleBackColor = true;
            this.CovertB64Button.Click += new System.EventHandler(this.CovertB64Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CovertB64Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Base64Output);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.RichTextBox UserText;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.RichTextBox Base64Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CovertB64Button;
    }
}

