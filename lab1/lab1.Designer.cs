namespace lab1
{
    partial class lab1
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
            label1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            label2 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            Key = new TextBox();
            label3 = new Label();
            start = new Button();
            browse = new Button();
            PlainText = new TextBox();
            EncText = new TextBox();
            label4 = new Label();
            label5 = new Label();
            InitBTN = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "Method";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 53);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Vigenere";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Rotating grid";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Location = new Point(12, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 85);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Action";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(3, 53);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(103, 24);
            radioButton4.TabIndex = 2;
            radioButton4.Text = "Decryption";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(3, 23);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 24);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "Encryption";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Key
            // 
            Key.Location = new Point(12, 212);
            Key.Name = "Key";
            Key.Size = new Size(244, 27);
            Key.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 189);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 3;
            label3.Text = "Key";
            // 
            // start
            // 
            start.Location = new Point(12, 304);
            start.Name = "start";
            start.Size = new Size(100, 34);
            start.TabIndex = 4;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // browse
            // 
            browse.Location = new Point(156, 304);
            browse.Name = "browse";
            browse.Size = new Size(100, 34);
            browse.TabIndex = 5;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = true;
            browse.Click += Browse_Click;
            // 
            // PlainText
            // 
            PlainText.Location = new Point(275, 35);
            PlainText.Multiline = true;
            PlainText.Name = "PlainText";
            PlainText.Size = new Size(474, 103);
            PlainText.TabIndex = 6;
            // 
            // EncText
            // 
            EncText.Location = new Point(275, 179);
            EncText.Multiline = true;
            EncText.Name = "EncText";
            EncText.Size = new Size(474, 136);
            EncText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 9);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Original";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 155);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 9;
            label5.Text = "Encrypted";
            // 
            // InitBTN
            // 
            InitBTN.Location = new Point(12, 245);
            InitBTN.Name = "InitBTN";
            InitBTN.Size = new Size(244, 34);
            InitBTN.TabIndex = 10;
            InitBTN.Text = "Initialize";
            InitBTN.UseVisualStyleBackColor = true;
            InitBTN.Click += InitBTN_Click;
            // 
            // lab1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 350);
            Controls.Add(InitBTN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EncText);
            Controls.Add(PlainText);
            Controls.Add(browse);
            Controls.Add(start);
            Controls.Add(label3);
            Controls.Add(Key);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "lab1";
            Text = "lab1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox Key;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button start;
        private Button browse;
        private TextBox PlainText;
        private TextBox EncText;
        private Label label4;
        private Label label5;
        private Button InitBTN;
    }
}
