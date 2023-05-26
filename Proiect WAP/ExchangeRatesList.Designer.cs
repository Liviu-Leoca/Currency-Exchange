namespace Proiect_WAP
{
    partial class ExchangeRatesList
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
            this.ExchangeRatesLv = new System.Windows.Forms.ListView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExchangeRatesLv
            // 
            this.ExchangeRatesLv.HideSelection = false;
            this.ExchangeRatesLv.Location = new System.Drawing.Point(12, 12);
            this.ExchangeRatesLv.Name = "ExchangeRatesLv";
            this.ExchangeRatesLv.Size = new System.Drawing.Size(428, 426);
            this.ExchangeRatesLv.TabIndex = 0;
            this.ExchangeRatesLv.UseCompatibleStateImageBehavior = false;
            this.ExchangeRatesLv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ExchangeRatesLv_MouseDoubleClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(365, 453);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExchangeRatesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ExchangeRatesLv);
            this.Name = "ExchangeRatesList";
            this.Text = "ExchangeRatesList";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ExchangeRatesList_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ExchangeRatesLv;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button1;
    }
}