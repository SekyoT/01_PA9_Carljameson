namespace _01_Carljameson_PA9
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
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_us = new System.Windows.Forms.RadioButton();
            this.rb_yen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Converted = new System.Windows.Forms.TextBox();
            this.bttn_convert = new System.Windows.Forms.Button();
            this.bttn_clear = new System.Windows.Forms.Button();
            this.rb_ringgit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(124, 44);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(169, 20);
            this.txt_Amount.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Currency : ";
            // 
            // rb_us
            // 
            this.rb_us.AutoSize = true;
            this.rb_us.Location = new System.Drawing.Point(131, 96);
            this.rb_us.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_us.Name = "rb_us";
            this.rb_us.Size = new System.Drawing.Size(75, 17);
            this.rb_us.TabIndex = 4;
            this.rb_us.TabStop = true;
            this.rb_us.Text = "US Dollars";
            this.rb_us.UseVisualStyleBackColor = true;
            // 
            // rb_yen
            // 
            this.rb_yen.AutoSize = true;
            this.rb_yen.Location = new System.Drawing.Point(131, 132);
            this.rb_yen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_yen.Name = "rb_yen";
            this.rb_yen.Size = new System.Drawing.Size(93, 17);
            this.rb_yen.TabIndex = 5;
            this.rb_yen.TabStop = true;
            this.rb_yen.Text = "Japanese Yen";
            this.rb_yen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Converted Amount";
            // 
            // txt_Converted
            // 
            this.txt_Converted.Location = new System.Drawing.Point(124, 202);
            this.txt_Converted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Converted.Name = "txt_Converted";
            this.txt_Converted.ReadOnly = true;
            this.txt_Converted.Size = new System.Drawing.Size(169, 20);
            this.txt_Converted.TabIndex = 7;
            // 
            // bttn_convert
            // 
            this.bttn_convert.Location = new System.Drawing.Point(390, 122);
            this.bttn_convert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_convert.Name = "bttn_convert";
            this.bttn_convert.Size = new System.Drawing.Size(97, 27);
            this.bttn_convert.TabIndex = 8;
            this.bttn_convert.Text = "Convert";
            this.bttn_convert.UseVisualStyleBackColor = true;
            this.bttn_convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_clear
            // 
            this.bttn_clear.Location = new System.Drawing.Point(390, 161);
            this.bttn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttn_clear.Name = "bttn_clear";
            this.bttn_clear.Size = new System.Drawing.Size(97, 28);
            this.bttn_clear.TabIndex = 9;
            this.bttn_clear.Text = "Clear";
            this.bttn_clear.UseVisualStyleBackColor = true;
            this.bttn_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // rb_ringgit
            // 
            this.rb_ringgit.AutoSize = true;
            this.rb_ringgit.Location = new System.Drawing.Point(131, 167);
            this.rb_ringgit.Name = "rb_ringgit";
            this.rb_ringgit.Size = new System.Drawing.Size(108, 17);
            this.rb_ringgit.TabIndex = 10;
            this.rb_ringgit.TabStop = true;
            this.rb_ringgit.Text = "Malaysian Ringgit";
            this.rb_ringgit.UseVisualStyleBackColor = true;
            this.rb_ringgit.CheckedChanged += new System.EventHandler(this.rb_Ringgit_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 344);
            this.Controls.Add(this.rb_ringgit);
            this.Controls.Add(this.bttn_clear);
            this.Controls.Add(this.bttn_convert);
            this.Controls.Add(this.txt_Converted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_yen);
            this.Controls.Add(this.rb_us);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Amount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_us;
        private System.Windows.Forms.RadioButton rb_yen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Converted;
        private System.Windows.Forms.Button bttn_convert;
        private System.Windows.Forms.Button bttn_clear;
        private System.Windows.Forms.RadioButton rb_ringgit;
    }
}

