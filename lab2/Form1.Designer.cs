namespace lab2
{
    partial class Stream_cipher
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
            panel1 = new Panel();
            Result = new Label();
            label1 = new Label();
            Decryption = new RadioButton();
            Encryption = new RadioButton();
            Start = new Button();
            key_input = new TextBox();
            label2 = new Label();
            Browse = new Button();
            panel2 = new Panel();
            file_l = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            key_l = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            enc_l = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Result);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Decryption);
            panel1.Controls.Add(Encryption);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 118);
            panel1.TabIndex = 0;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(7, 90);
            Result.Name = "Result";
            Result.Size = new Size(52, 20);
            Result.TabIndex = 3;
            Result.Text = "Result:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Action:";
            // 
            // Decryption
            // 
            Decryption.AutoSize = true;
            Decryption.Location = new Point(7, 63);
            Decryption.Name = "Decryption";
            Decryption.Size = new Size(103, 24);
            Decryption.TabIndex = 1;
            Decryption.Text = "Decryption";
            Decryption.UseVisualStyleBackColor = true;
            Decryption.CheckedChanged += Decryption_CheckedChanged;
            // 
            // Encryption
            // 
            Encryption.AutoSize = true;
            Encryption.Checked = true;
            Encryption.Location = new Point(7, 33);
            Encryption.Name = "Encryption";
            Encryption.Size = new Size(100, 24);
            Encryption.TabIndex = 0;
            Encryption.TabStop = true;
            Encryption.Text = "Encryption";
            Encryption.UseVisualStyleBackColor = true;
            Encryption.Click += Encryption_Click;
            // 
            // Start
            // 
            Start.Location = new Point(426, 97);
            Start.Name = "Start";
            Start.Size = new Size(94, 29);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // key_input
            // 
            key_input.Location = new Point(242, 46);
            key_input.Name = "key_input";
            key_input.Size = new Size(278, 27);
            key_input.TabIndex = 2;
            key_input.Text = "000000001111111111111111111111111";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 3;
            label2.Text = "Input key (33 symbols):";
            // 
            // Browse
            // 
            Browse.Location = new Point(242, 97);
            Browse.Name = "Browse";
            Browse.Size = new Size(94, 29);
            Browse.TabIndex = 4;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(file_l);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 131);
            panel2.TabIndex = 5;
            // 
            // file_l
            // 
            file_l.Location = new Point(3, 22);
            file_l.Multiline = true;
            file_l.Name = "file_l";
            file_l.Size = new Size(500, 104);
            file_l.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, -1);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 2;
            label5.Text = "Plain file:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(key_l);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 269);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 148);
            panel3.TabIndex = 6;
            // 
            // key_l
            // 
            key_l.Location = new Point(3, 39);
            key_l.Multiline = true;
            key_l.Name = "key_l";
            key_l.Size = new Size(500, 104);
            key_l.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, -1);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 0;
            label3.Text = "Key:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(enc_l);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 423);
            panel4.Name = "panel4";
            panel4.Size = new Size(508, 148);
            panel4.TabIndex = 7;
            // 
            // enc_l
            // 
            enc_l.Location = new Point(3, 39);
            enc_l.Multiline = true;
            enc_l.Name = "enc_l";
            enc_l.Size = new Size(500, 104);
            enc_l.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, -1);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 1;
            label4.Text = "Encrypted file:";
            // 
            // Stream_cipher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 573);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Browse);
            Controls.Add(label2);
            Controls.Add(key_input);
            Controls.Add(Start);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Stream_cipher";
            Text = "Stream cipher";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton Decryption;
        private RadioButton Encryption;
        private Button Start;
        private TextBox key_input;
        private Label label2;
        private Button Browse;
        private Label Result;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private TextBox file_l;
        private TextBox key_l;
        private TextBox enc_l;
    }
}
