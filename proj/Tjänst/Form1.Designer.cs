namespace Tjänst
{
    partial class Stugtjänster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stugtjänster));
            this.emailText = new System.Windows.Forms.TextBox();
            this.sendEmail = new System.Windows.Forms.Button();
            this.stugorList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serviceList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.reservationList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(30, 29);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(172, 20);
            this.emailText.TabIndex = 0;
            this.emailText.Text = "insert email...";
            this.emailText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(54, 55);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(75, 23);
            this.sendEmail.TabIndex = 1;
            this.sendEmail.Text = "ok";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_ClickAsync);
            // 
            // stugorList
            // 
            this.stugorList.FormattingEnabled = true;
            this.stugorList.Location = new System.Drawing.Point(471, 55);
            this.stugorList.Name = "stugorList";
            this.stugorList.Size = new System.Drawing.Size(260, 82);
            this.stugorList.TabIndex = 2;
            this.stugorList.SelectedIndexChanged += new System.EventHandler(this.stugorList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ange din e-post adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boka tjänst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Välj Stuga";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // serviceList
            // 
            this.serviceList.FormattingEnabled = true;
            this.serviceList.Location = new System.Drawing.Point(471, 178);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(260, 95);
            this.serviceList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tjänster";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum";
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(553, 383);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 10;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // reservationList
            // 
            this.reservationList.FormattingEnabled = true;
            this.reservationList.Location = new System.Drawing.Point(30, 115);
            this.reservationList.Name = "reservationList";
            this.reservationList.Size = new System.Drawing.Size(378, 121);
            this.reservationList.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mina bokningar";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(474, 321);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(208, 20);
            this.datum.TabIndex = 13;
            this.datum.Text = "0000/00/00";
            this.datum.TextChanged += new System.EventHandler(this.datum_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(32, 250);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Radera";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_ClickAsync);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(273, 249);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 15;
            this.modifyButton.Text = "Modifiera";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_ClickAsync);
            // 
            // Stugtjänster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reservationList);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stugorList);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.emailText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stugtjänster";
            this.Text = "Stugtjänster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.ListBox stugorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox serviceList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.ListBox reservationList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox datum;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
    }
}

