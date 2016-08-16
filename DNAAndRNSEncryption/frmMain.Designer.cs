namespace DNAAndRNSEncryption
{
    partial class frmMain
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
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtPlainTextBit = new System.Windows.Forms.TextBox();
            this.txtDNASequnceString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNASequnceBinary = new System.Windows.Forms.TextBox();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.lblPlainTextbit = new System.Windows.Forms.Label();
            this.lblDNASequnce = new System.Windows.Forms.Label();
            this.lblDNASequnceBit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPlainTextMatrix = new System.Windows.Forms.Label();
            this.txtStep2 = new System.Windows.Forms.TextBox();
            this.lblPlainTextMatrix = new System.Windows.Forms.Label();
            this.lblPasswordMatrix = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStep1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHuffman = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResultString = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(428, 803);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PlainText:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plain Text Bit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNA Sequnce String:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(170, 6);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(628, 20);
            this.txtPlainText.TabIndex = 0;
            // 
            // txtPlainTextBit
            // 
            this.txtPlainTextBit.Location = new System.Drawing.Point(170, 75);
            this.txtPlainTextBit.Multiline = true;
            this.txtPlainTextBit.Name = "txtPlainTextBit";
            this.txtPlainTextBit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlainTextBit.Size = new System.Drawing.Size(628, 84);
            this.txtPlainTextBit.TabIndex = 2;
            // 
            // txtDNASequnceString
            // 
            this.txtDNASequnceString.Location = new System.Drawing.Point(170, 168);
            this.txtDNASequnceString.Multiline = true;
            this.txtDNASequnceString.Name = "txtDNASequnceString";
            this.txtDNASequnceString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDNASequnceString.Size = new System.Drawing.Size(628, 84);
            this.txtDNASequnceString.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DNA Sequnce Binary:";
            // 
            // txtDNASequnceBinary
            // 
            this.txtDNASequnceBinary.Location = new System.Drawing.Point(170, 348);
            this.txtDNASequnceBinary.Multiline = true;
            this.txtDNASequnceBinary.Name = "txtDNASequnceBinary";
            this.txtDNASequnceBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDNASequnceBinary.Size = new System.Drawing.Size(628, 84);
            this.txtDNASequnceBinary.TabIndex = 4;
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Location = new System.Drawing.Point(804, 9);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(10, 13);
            this.lblPlainText.TabIndex = 11;
            this.lblPlainText.Text = "-";
            // 
            // lblPlainTextbit
            // 
            this.lblPlainTextbit.AutoSize = true;
            this.lblPlainTextbit.Location = new System.Drawing.Point(804, 110);
            this.lblPlainTextbit.Name = "lblPlainTextbit";
            this.lblPlainTextbit.Size = new System.Drawing.Size(10, 13);
            this.lblPlainTextbit.TabIndex = 12;
            this.lblPlainTextbit.Text = "-";
            // 
            // lblDNASequnce
            // 
            this.lblDNASequnce.AutoSize = true;
            this.lblDNASequnce.Location = new System.Drawing.Point(804, 201);
            this.lblDNASequnce.Name = "lblDNASequnce";
            this.lblDNASequnce.Size = new System.Drawing.Size(10, 13);
            this.lblDNASequnce.TabIndex = 13;
            this.lblDNASequnce.Text = "-";
            // 
            // lblDNASequnceBit
            // 
            this.lblDNASequnceBit.AutoSize = true;
            this.lblDNASequnceBit.Location = new System.Drawing.Point(804, 289);
            this.lblDNASequnceBit.Name = "lblDNASequnceBit";
            this.lblDNASequnceBit.Size = new System.Drawing.Size(10, 13);
            this.lblDNASequnceBit.TabIndex = 14;
            this.lblDNASequnceBit.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(628, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(804, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(10, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "-";
            // 
            // txtPlainTextMatrix
            // 
            this.txtPlainTextMatrix.AutoSize = true;
            this.txtPlainTextMatrix.Location = new System.Drawing.Point(12, 441);
            this.txtPlainTextMatrix.Name = "txtPlainTextMatrix";
            this.txtPlainTextMatrix.Size = new System.Drawing.Size(103, 13);
            this.txtPlainTextMatrix.TabIndex = 17;
            this.txtPlainTextMatrix.Text = "Encrypt Step2(XOR)";
            // 
            // txtStep2
            // 
            this.txtStep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStep2.Location = new System.Drawing.Point(170, 438);
            this.txtStep2.Multiline = true;
            this.txtStep2.Name = "txtStep2";
            this.txtStep2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStep2.Size = new System.Drawing.Size(628, 84);
            this.txtStep2.TabIndex = 5;
            // 
            // lblPlainTextMatrix
            // 
            this.lblPlainTextMatrix.AutoSize = true;
            this.lblPlainTextMatrix.Location = new System.Drawing.Point(804, 378);
            this.lblPlainTextMatrix.Name = "lblPlainTextMatrix";
            this.lblPlainTextMatrix.Size = new System.Drawing.Size(10, 13);
            this.lblPlainTextMatrix.TabIndex = 21;
            this.lblPlainTextMatrix.Text = "-";
            // 
            // lblPasswordMatrix
            // 
            this.lblPasswordMatrix.AutoSize = true;
            this.lblPasswordMatrix.Location = new System.Drawing.Point(804, 479);
            this.lblPasswordMatrix.Name = "lblPasswordMatrix";
            this.lblPasswordMatrix.Size = new System.Drawing.Size(10, 13);
            this.lblPasswordMatrix.TabIndex = 22;
            this.lblPasswordMatrix.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Encrypted Plain Text";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtResult.Location = new System.Drawing.Point(170, 528);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(628, 84);
            this.txtResult.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Encrypt Step1(DNA Comp)";
            // 
            // txtStep1
            // 
            this.txtStep1.Location = new System.Drawing.Point(170, 258);
            this.txtStep1.Multiline = true;
            this.txtStep1.Name = "txtStep1";
            this.txtStep1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStep1.Size = new System.Drawing.Size(628, 84);
            this.txtStep1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Huffman Compression";
            // 
            // txtHuffman
            // 
            this.txtHuffman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtHuffman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtHuffman.Location = new System.Drawing.Point(170, 618);
            this.txtHuffman.Multiline = true;
            this.txtHuffman.Name = "txtHuffman";
            this.txtHuffman.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHuffman.Size = new System.Drawing.Size(628, 84);
            this.txtHuffman.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(804, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(804, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "-";
            // 
            // txtResultString
            // 
            this.txtResultString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResultString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtResultString.Location = new System.Drawing.Point(170, 708);
            this.txtResultString.Multiline = true;
            this.txtResultString.Name = "txtResultString";
            this.txtResultString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultString.Size = new System.Drawing.Size(628, 84);
            this.txtResultString.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 708);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Result String";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(804, 741);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 838);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtResultString);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHuffman);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStep1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPasswordMatrix);
            this.Controls.Add(this.lblPlainTextMatrix);
            this.Controls.Add(this.txtStep2);
            this.Controls.Add(this.txtPlainTextMatrix);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDNASequnceBit);
            this.Controls.Add(this.lblDNASequnce);
            this.Controls.Add(this.lblPlainTextbit);
            this.Controls.Add(this.lblPlainText);
            this.Controls.Add(this.txtDNASequnceBinary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDNASequnceString);
            this.Controls.Add(this.txtPlainTextBit);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtPlainTextBit;
        private System.Windows.Forms.TextBox txtDNASequnceString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNASequnceBinary;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.Label lblPlainTextbit;
        private System.Windows.Forms.Label lblDNASequnce;
        private System.Windows.Forms.Label lblDNASequnceBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label txtPlainTextMatrix;
        private System.Windows.Forms.TextBox txtStep2;
        private System.Windows.Forms.Label lblPlainTextMatrix;
        private System.Windows.Forms.Label lblPasswordMatrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStep1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHuffman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResultString;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

