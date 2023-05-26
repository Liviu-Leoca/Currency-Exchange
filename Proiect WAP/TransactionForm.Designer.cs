namespace Proiect_WAP
{
    partial class TransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SrsCrs = new System.Windows.Forms.TextBox();
            this.trgCrs = new System.Windows.Forms.TextBox();
            this.Amnt = new System.Windows.Forms.TextBox();
            this.ExRt = new System.Windows.Forms.TextBox();
            this.Dat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // SrsCrs
            // 
            this.SrsCrs.Location = new System.Drawing.Point(15, 38);
            this.SrsCrs.Name = "SrsCrs";
            this.SrsCrs.Size = new System.Drawing.Size(100, 20);
            this.SrsCrs.TabIndex = 5;
            // 
            // trgCrs
            // 
            this.trgCrs.Location = new System.Drawing.Point(161, 38);
            this.trgCrs.Name = "trgCrs";
            this.trgCrs.Size = new System.Drawing.Size(100, 20);
            this.trgCrs.TabIndex = 6;
            // 
            // Amnt
            // 
            this.Amnt.Location = new System.Drawing.Point(312, 38);
            this.Amnt.Name = "Amnt";
            this.Amnt.Size = new System.Drawing.Size(100, 20);
            this.Amnt.TabIndex = 7;
            // 
            // ExRt
            // 
            this.ExRt.Location = new System.Drawing.Point(460, 38);
            this.ExRt.Name = "ExRt";
            this.ExRt.Size = new System.Drawing.Size(100, 20);
            this.ExRt.TabIndex = 8;
            this.ExRt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Dat
            // 
            this.Dat.Location = new System.Drawing.Point(594, 38);
            this.Dat.Name = "Dat";
            this.Dat.Size = new System.Drawing.Size(100, 20);
            this.Dat.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(594, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 111);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dat);
            this.Controls.Add(this.ExRt);
            this.Controls.Add(this.Amnt);
            this.Controls.Add(this.trgCrs);
            this.Controls.Add(this.SrsCrs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SrsCrs;
        private System.Windows.Forms.TextBox trgCrs;
        private System.Windows.Forms.TextBox Amnt;
        private System.Windows.Forms.TextBox ExRt;
        private System.Windows.Forms.TextBox Dat;
        private System.Windows.Forms.Button button1;
    }
}