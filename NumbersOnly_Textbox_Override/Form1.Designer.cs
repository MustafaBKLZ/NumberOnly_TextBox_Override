namespace NumbersOnly_Textbox_Override
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
            this.textBoxNumbersOnly2 = new NumbersOnly_Textbox_Override.TextBoxNumbersOnly();
            this.textBoxNumbersOnly1 = new NumbersOnly_Textbox_Override.TextBoxNumbersOnly();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumbersOnly2
            // 
            this.textBoxNumbersOnly2.Location = new System.Drawing.Point(61, 122);
            this.textBoxNumbersOnly2.Multiline = true;
            this.textBoxNumbersOnly2.Name = "textBoxNumbersOnly2";
            this.textBoxNumbersOnly2.NumbersOnly = false;
            this.textBoxNumbersOnly2.Size = new System.Drawing.Size(175, 80);
            this.textBoxNumbersOnly2.TabIndex = 1;
            this.textBoxNumbersOnly2.Text = "0";
            // 
            // textBoxNumbersOnly1
            // 
            this.textBoxNumbersOnly1.Location = new System.Drawing.Point(61, 96);
            this.textBoxNumbersOnly1.Name = "textBoxNumbersOnly1";
            this.textBoxNumbersOnly1.NumbersOnly = true;
            this.textBoxNumbersOnly1.Size = new System.Drawing.Size(175, 20);
            this.textBoxNumbersOnly1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumbersOnly2);
            this.Controls.Add(this.textBoxNumbersOnly1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxNumbersOnly textBoxNumbersOnly1;
        private TextBoxNumbersOnly textBoxNumbersOnly2;
        private System.Windows.Forms.Button button1;
    }
}

