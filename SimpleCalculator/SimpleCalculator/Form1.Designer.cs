﻿namespace SimpleCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.MoDbutton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.negativeButton = new System.Windows.Forms.Button();
            this.calcResult = new System.Windows.Forms.TextBox();
            this.resultDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 25);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(255, 236);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 38);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(255, 192);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 38);
            this.subButton.TabIndex = 4;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // multiButton
            // 
            this.multiButton.Location = new System.Drawing.Point(255, 148);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(75, 38);
            this.multiButton.TabIndex = 5;
            this.multiButton.Text = "*";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Location = new System.Drawing.Point(255, 104);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(75, 38);
            this.DivButton.TabIndex = 6;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.Div_button_Click);
            // 
            // MoDbutton
            // 
            this.MoDbutton.Location = new System.Drawing.Point(174, 104);
            this.MoDbutton.Name = "MoDbutton";
            this.MoDbutton.Size = new System.Drawing.Size(75, 38);
            this.MoDbutton.TabIndex = 7;
            this.MoDbutton.Text = "%";
            this.MoDbutton.UseVisualStyleBackColor = true;
            this.MoDbutton.Click += new System.EventHandler(this.Mod_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(255, 280);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "=";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Is_button_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 104);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 38);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "AC";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(174, 75);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // negativeButton
            // 
            this.negativeButton.Location = new System.Drawing.Point(93, 104);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(75, 38);
            this.negativeButton.TabIndex = 11;
            this.negativeButton.Text = "+/-";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.minusChange_Click);
            // 
            // calcResult
            // 
            this.calcResult.Location = new System.Drawing.Point(348, 31);
            this.calcResult.Multiline = true;
            this.calcResult.Name = "calcResult";
            this.calcResult.ReadOnly = true;
            this.calcResult.Size = new System.Drawing.Size(290, 243);
            this.calcResult.TabIndex = 12;
            this.calcResult.TextChanged += new System.EventHandler(this.calcResult_TextChanged);
            // 
            // resultDelete
            // 
            this.resultDelete.Location = new System.Drawing.Point(349, 280);
            this.resultDelete.Name = "resultDelete";
            this.resultDelete.Size = new System.Drawing.Size(289, 38);
            this.resultDelete.TabIndex = 13;
            this.resultDelete.Text = "내역 삭제";
            this.resultDelete.UseVisualStyleBackColor = true;
            this.resultDelete.Click += new System.EventHandler(this.resultDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 16;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 18;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 38);
            this.button7.TabIndex = 19;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 38);
            this.button8.TabIndex = 20;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(93, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 38);
            this.button9.TabIndex = 21;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(174, 148);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 38);
            this.button10.TabIndex = 22;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 280);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(156, 38);
            this.button11.TabIndex = 23;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(174, 280);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 38);
            this.button12.TabIndex = 24;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 330);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultDelete);
            this.Controls.Add(this.calcResult);
            this.Controls.Add(this.negativeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.MoDbutton);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button MoDbutton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.TextBox calcResult;
        private System.Windows.Forms.Button resultDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

