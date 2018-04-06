namespace Containment_Example_1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnDisplayAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.txtAccountNumber2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustID2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 26);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 488);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnDisplayAccount
            // 
            this.BtnDisplayAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplayAccount.Location = new System.Drawing.Point(50, 533);
            this.BtnDisplayAccount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnDisplayAccount.Name = "BtnDisplayAccount";
            this.BtnDisplayAccount.Size = new System.Drawing.Size(360, 45);
            this.BtnDisplayAccount.TabIndex = 0;
            this.BtnDisplayAccount.Text = "Display All Customers";
            this.BtnDisplayAccount.UseVisualStyleBackColor = true;
            this.BtnDisplayAccount.Click += new System.EventHandler(this.BtnDisplay);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.txtAccountType);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.txtAccountNum);
            this.panel1.Controls.Add(this.txtCustID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(502, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 308);
            this.panel1.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(30, 242);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(410, 43);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add Account To Customer";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // txtAccountType
            // 
            this.txtAccountType.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountType.Location = new System.Drawing.Point(239, 178);
            this.txtAccountType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(200, 31);
            this.txtAccountType.TabIndex = 4;
            this.txtAccountType.Tag = "Type of Account";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(239, 127);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(200, 31);
            this.txtBalance.TabIndex = 3;
            this.txtBalance.Tag = "Balance";
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNum.Location = new System.Drawing.Point(239, 87);
            this.txtAccountNum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(200, 31);
            this.txtAccountNum.TabIndex = 2;
            this.txtAccountNum.Tag = "Account# (Add Account)";
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID.Location = new System.Drawing.Point(239, 36);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(200, 31);
            this.txtCustID.TabIndex = 1;
            this.txtCustID.Tag = "Customer ID (Add Account)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.txtAccountNumber2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCustID2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(502, 366);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 213);
            this.panel2.TabIndex = 3;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(120, 145);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(210, 40);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "Close Account";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseAccount);
            // 
            // txtAccountNumber2
            // 
            this.txtAccountNumber2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber2.Location = new System.Drawing.Point(214, 88);
            this.txtAccountNumber2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAccountNumber2.Name = "txtAccountNumber2";
            this.txtAccountNumber2.Size = new System.Drawing.Size(226, 31);
            this.txtAccountNumber2.TabIndex = 7;
            this.txtAccountNumber2.Tag = "Account# (Close Account)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Account #";
            // 
            // txtCustID2
            // 
            this.txtCustID2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID2.Location = new System.Drawing.Point(214, 20);
            this.txtCustID2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCustID2.Name = "txtCustID2";
            this.txtCustID2.Size = new System.Drawing.Size(226, 31);
            this.txtCustID2.TabIndex = 6;
            this.txtCustID2.Tag = "CustomerID (Close Account)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer ID";
            // 
            // lblError
            // 
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblError.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(35, 609);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(942, 51);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "lblError";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1025, 692);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDisplayAccount);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Display Customers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnDisplayAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox txtAccountNumber2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustID2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label lblError;
    }
}

