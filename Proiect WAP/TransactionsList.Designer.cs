namespace Proiect_WAP
{
    partial class TransactionsList
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
            this.TransactionsLv = new System.Windows.Forms.ListView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransactionsLv
            // 
            this.TransactionsLv.HideSelection = false;
            this.TransactionsLv.Location = new System.Drawing.Point(12, 12);
            this.TransactionsLv.Name = "TransactionsLv";
            this.TransactionsLv.Size = new System.Drawing.Size(544, 437);
            this.TransactionsLv.TabIndex = 0;
            this.TransactionsLv.UseCompatibleStateImageBehavior = false;
            this.TransactionsLv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TransactionsLv_MouseDoubleClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(481, 455);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(12, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TransactionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.TransactionsLv);
            this.Name = "TransactionsList";
            this.Text = "TransactionsList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TransactionsLv;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button2;
    }
}