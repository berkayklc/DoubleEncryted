namespace DoubleEncrypt
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
            this.bttn_SelectKeyDOC = new System.Windows.Forms.Button();
            this.bttn_takeyourKEY = new System.Windows.Forms.Button();
            this.bttn_createKEY = new System.Windows.Forms.Button();
            this.bttn_Encrypt = new System.Windows.Forms.Button();
            this.bttn_DeCrypt = new System.Windows.Forms.Button();
            this.textbox_selection = new System.Windows.Forms.TextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label_docName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_selectionPath = new System.Windows.Forms.Label();
            this.textBox_ResultMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_SelectKeyDOC
            // 
            this.bttn_SelectKeyDOC.Location = new System.Drawing.Point(12, 12);
            this.bttn_SelectKeyDOC.Name = "bttn_SelectKeyDOC";
            this.bttn_SelectKeyDOC.Size = new System.Drawing.Size(167, 69);
            this.bttn_SelectKeyDOC.TabIndex = 0;
            this.bttn_SelectKeyDOC.Text = "Select Key Document";
            this.bttn_SelectKeyDOC.UseVisualStyleBackColor = true;
            this.bttn_SelectKeyDOC.Click += new System.EventHandler(this.bttn_SelectKeyDOC_Click);
            // 
            // bttn_takeyourKEY
            // 
            this.bttn_takeyourKEY.Location = new System.Drawing.Point(12, 307);
            this.bttn_takeyourKEY.Name = "bttn_takeyourKEY";
            this.bttn_takeyourKEY.Size = new System.Drawing.Size(167, 69);
            this.bttn_takeyourKEY.TabIndex = 1;
            this.bttn_takeyourKEY.Text = "Take Your Key";
            this.bttn_takeyourKEY.UseVisualStyleBackColor = true;
            this.bttn_takeyourKEY.Click += new System.EventHandler(this.bttn_takeyourKEY_Click);
            // 
            // bttn_createKEY
            // 
            this.bttn_createKEY.Location = new System.Drawing.Point(12, 382);
            this.bttn_createKEY.Name = "bttn_createKEY";
            this.bttn_createKEY.Size = new System.Drawing.Size(167, 69);
            this.bttn_createKEY.TabIndex = 2;
            this.bttn_createKEY.Text = "Create New Key Document";
            this.bttn_createKEY.UseVisualStyleBackColor = true;
            this.bttn_createKEY.Click += new System.EventHandler(this.bttn_createKEY_Click);
            // 
            // bttn_Encrypt
            // 
            this.bttn_Encrypt.Location = new System.Drawing.Point(730, 307);
            this.bttn_Encrypt.Name = "bttn_Encrypt";
            this.bttn_Encrypt.Size = new System.Drawing.Size(167, 69);
            this.bttn_Encrypt.TabIndex = 3;
            this.bttn_Encrypt.Text = "Encrypt";
            this.bttn_Encrypt.UseVisualStyleBackColor = true;
            this.bttn_Encrypt.Click += new System.EventHandler(this.bttn_Encrypt_Click);
            // 
            // bttn_DeCrypt
            // 
            this.bttn_DeCrypt.Location = new System.Drawing.Point(730, 382);
            this.bttn_DeCrypt.Name = "bttn_DeCrypt";
            this.bttn_DeCrypt.Size = new System.Drawing.Size(167, 69);
            this.bttn_DeCrypt.TabIndex = 4;
            this.bttn_DeCrypt.Text = "DeCrypt";
            this.bttn_DeCrypt.UseVisualStyleBackColor = true;
            this.bttn_DeCrypt.Click += new System.EventHandler(this.bttn_DeCrypt_Click);
            // 
            // textbox_selection
            // 
            this.textbox_selection.Location = new System.Drawing.Point(231, 54);
            this.textbox_selection.Name = "textbox_selection";
            this.textbox_selection.Size = new System.Drawing.Size(478, 27);
            this.textbox_selection.TabIndex = 5;
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(231, 186);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(478, 27);
            this.textBox_message.TabIndex = 6;
            // 
            // label_docName
            // 
            this.label_docName.AutoSize = true;
            this.label_docName.Location = new System.Drawing.Point(231, 21);
            this.label_docName.Name = "label_docName";
            this.label_docName.Size = new System.Drawing.Size(70, 20);
            this.label_docName.TabIndex = 7;
            this.label_docName.Text = "Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Your Message Which Will Encrypt or DeCrypt:";
            // 
            // label_selectionPath
            // 
            this.label_selectionPath.AutoSize = true;
            this.label_selectionPath.Location = new System.Drawing.Point(12, 454);
            this.label_selectionPath.Name = "label_selectionPath";
            this.label_selectionPath.Size = new System.Drawing.Size(154, 20);
            this.label_selectionPath.TabIndex = 9;
            this.label_selectionPath.Text = "<-- Selection Path -->";
            // 
            // textBox_ResultMessage
            // 
            this.textBox_ResultMessage.Location = new System.Drawing.Point(231, 349);
            this.textBox_ResultMessage.Multiline = true;
            this.textBox_ResultMessage.Name = "textBox_ResultMessage";
            this.textBox_ResultMessage.Size = new System.Drawing.Size(448, 59);
            this.textBox_ResultMessage.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Your NEW Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ResultMessage);
            this.Controls.Add(this.label_selectionPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_docName);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.textbox_selection);
            this.Controls.Add(this.bttn_DeCrypt);
            this.Controls.Add(this.bttn_Encrypt);
            this.Controls.Add(this.bttn_createKEY);
            this.Controls.Add(this.bttn_takeyourKEY);
            this.Controls.Add(this.bttn_SelectKeyDOC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttn_SelectKeyDOC;
        private Button bttn_takeyourKEY;
        private Button bttn_createKEY;
        private Button bttn_Encrypt;
        private Button bttn_DeCrypt;
        private TextBox textbox_selection;
        private TextBox textBox_message;
        private Label label_docName;
        private Label label2;
        private Label label_selectionPath;
        private TextBox textBox_ResultMessage;
        private Label label1;
    }
}