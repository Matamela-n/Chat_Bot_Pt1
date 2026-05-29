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
            btnExit = new Button();
            rtbChat = new RichTextBox();
            panel2 = new Panel();
            btnClear = new Button();
            btnVoice = new Button();
            btnSend = new Button();
            txtMessage = new TextBox();
            pictureBox2 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 16, 48);
            pnlHeader.Controls.Add(pictureBox2);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1006, 80);
            pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.secure_lock_new_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(233, 213, 255);
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(236, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(466, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SecureLock Assistant";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(rtbChat);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 514);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(127, 29, 29);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(248, 113, 113);
            btnExit.Location = new Point(910, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.FromArgb(13, 13, 26);
            rtbChat.BorderStyle = BorderStyle.FixedSingle;
            rtbChat.Dock = DockStyle.Fill;
            rtbChat.ForeColor = Color.FromArgb(221, 214, 254);
            rtbChat.Location = new Point(0, 0);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(1006, 444);
            rtbChat.TabIndex = 1;
            rtbChat.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnVoice);
            panel2.Controls.Add(btnSend);
            panel2.Controls.Add(txtMessage);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 70);
            panel2.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(13, 13, 26);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 74);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(107, 107, 154);
            btnClear.Location = new Point(910, 24);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 25);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnVoice
            // 
            btnVoice.BackColor = Color.FromArgb(26, 16, 53);
            btnVoice.FlatAppearance.BorderColor = Color.FromArgb(59, 31, 122);
            btnVoice.FlatStyle = FlatStyle.Flat;
            btnVoice.ForeColor = Color.FromArgb(167, 139, 250);
            btnVoice.Location = new Point(12, 15);
            btnVoice.Name = "btnVoice";
            btnVoice.Size = new Size(66, 40);
            btnVoice.TabIndex = 3;
            btnVoice.Text = "Speak";
            btnVoice.UseVisualStyleBackColor = false;
            btnVoice.Click += btnVoice_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(124, 58, 237);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.FromArgb(245, 243, 255);
            btnSend.Location = new Point(818, 24);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(13, 13, 26);
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.ForeColor = Color.FromArgb(221, 214, 254);
            txtMessage.Location = new Point(84, 18);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(820, 40);
            txtMessage.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.secure_lock_new_logo;
            pictureBox2.Location = new Point(708, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(277, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 26);
            ClientSize = new Size(1006, 594);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Secure Lock Bot";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}
