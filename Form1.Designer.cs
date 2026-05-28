namespace Secure_Lock_Chat
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
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            panel1 = new Panel();
            rtbChat = new RichTextBox();
            panel2 = new Panel();
            btnVoice = new Button();
            btnExit = new Button();
            btnSend = new Button();
            txtMessage = new TextBox();
            btnClear = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 80);
            pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 71);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(236, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(466, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SecureLock Assistant";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(rtbChat);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 608);
            panel1.TabIndex = 1;
            // 
            // rtbChat
            // 
            rtbChat.Dock = DockStyle.Fill;
            rtbChat.Location = new Point(0, 0);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(800, 538);
            rtbChat.TabIndex = 1;
            rtbChat.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnVoice);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSend);
            panel2.Controls.Add(txtMessage);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 538);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 70);
            panel2.TabIndex = 0;
            // 
            // btnVoice
            // 
            btnVoice.FlatStyle = FlatStyle.Flat;
            btnVoice.Location = new Point(12, 24);
            btnVoice.Name = "btnVoice";
            btnVoice.Size = new Size(66, 40);
            btnVoice.TabIndex = 3;
            btnVoice.Text = "Speak";
            btnVoice.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(719, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSend
            // 
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Location = new Point(627, 35);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(81, 24);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(632, 40);
            txtMessage.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 507);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 25);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 688);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Name = "Form1";
            Text = "Secure Lock Bot";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private RichTextBox rtbChat;
        private Button btnExit;
        private Button btnSend;
        private TextBox txtMessage;
        private PictureBox pictureBox1;
        private Button btnVoice;
        private Button btnClear;
    }
}
