
namespace CodeAssesmentApp
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
            this.ReverseButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CharacterCountLabel = new System.Windows.Forms.Label();
            this.ReversedNameLabel = new System.Windows.Forms.Label();
            this.ReversedName = new System.Windows.Forms.Label();
            this.CharacterCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(38, 130);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(75, 23);
            this.ReverseButton.TabIndex = 0;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(37, 39);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 23);
            this.textBox2.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(38, 83);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // CharacterCountLabel
            // 
            this.CharacterCountLabel.AutoSize = true;
            this.CharacterCountLabel.Location = new System.Drawing.Point(38, 189);
            this.CharacterCountLabel.Name = "CharacterCountLabel";
            this.CharacterCountLabel.Size = new System.Drawing.Size(100, 15);
            this.CharacterCountLabel.TabIndex = 7;
            this.CharacterCountLabel.Text = "Character Count: ";
            // 
            // ReversedNameLabel
            // 
            this.ReversedNameLabel.AutoSize = true;
            this.ReversedNameLabel.Location = new System.Drawing.Point(38, 165);
            this.ReversedNameLabel.Name = "ReversedNameLabel";
            this.ReversedNameLabel.Size = new System.Drawing.Size(95, 15);
            this.ReversedNameLabel.TabIndex = 8;
            this.ReversedNameLabel.Text = "Reversed Name: ";
            // 
            // ReversedName
            // 
            this.ReversedName.AutoSize = true;
            this.ReversedName.Location = new System.Drawing.Point(131, 165);
            this.ReversedName.Name = "ReversedName";
            this.ReversedName.Size = new System.Drawing.Size(0, 15);
            this.ReversedName.TabIndex = 9;
            this.ReversedName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CharacterCount
            // 
            this.CharacterCount.AutoSize = true;
            this.CharacterCount.Location = new System.Drawing.Point(131, 189);
            this.CharacterCount.Name = "CharacterCount";
            this.CharacterCount.Size = new System.Drawing.Size(0, 15);
            this.CharacterCount.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 305);
            this.Controls.Add(this.CharacterCount);
            this.Controls.Add(this.ReversedName);
            this.Controls.Add(this.ReversedNameLabel);
            this.Controls.Add(this.CharacterCountLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.ReverseButton);
            this.Name = "Form1";
            this.Text = "Name Reversal App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label CharacterCountLabel;
        private System.Windows.Forms.Label ReversedNameLabel;
        private System.Windows.Forms.Label ReversedName;
        private System.Windows.Forms.Label CharacterCount;
    }
}

