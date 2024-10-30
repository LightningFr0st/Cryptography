namespace lab3
{
    partial class lab3
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
            enableDecryption = new RadioButton();
            enableEncryption = new RadioButton();
            label1 = new Label();
            panel2 = new Panel();
            counter = new Label();
            stats = new Label();
            browseBtn = new Button();
            startBtn = new Button();
            SelectG = new ComboBox();
            label6 = new Label();
            inputK = new TextBox();
            inputX = new TextBox();
            inputP = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            PlainFile = new TextBox();
            EncFile = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(enableDecryption);
            panel1.Controls.Add(enableEncryption);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 44);
            panel1.TabIndex = 0;
            // 
            // enableDecryption
            // 
            enableDecryption.AutoSize = true;
            enableDecryption.Location = new Point(177, 8);
            enableDecryption.Name = "enableDecryption";
            enableDecryption.Size = new Size(103, 24);
            enableDecryption.TabIndex = 3;
            enableDecryption.TabStop = true;
            enableDecryption.Text = "Decryption";
            enableDecryption.UseVisualStyleBackColor = true;
            enableDecryption.CheckedChanged += enableDecryption_CheckedChanged;
            // 
            // enableEncryption
            // 
            enableEncryption.AutoSize = true;
            enableEncryption.Location = new Point(71, 7);
            enableEncryption.Name = "enableEncryption";
            enableEncryption.Size = new Size(100, 24);
            enableEncryption.TabIndex = 2;
            enableEncryption.TabStop = true;
            enableEncryption.Text = "Encryption";
            enableEncryption.UseVisualStyleBackColor = true;
            enableEncryption.CheckedChanged += enableEncryption_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 1;
            label1.Text = "Action:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(counter);
            panel2.Controls.Add(stats);
            panel2.Controls.Add(browseBtn);
            panel2.Controls.Add(startBtn);
            panel2.Controls.Add(SelectG);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(inputK);
            panel2.Controls.Add(inputX);
            panel2.Controls.Add(inputP);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 417);
            panel2.TabIndex = 1;
            // 
            // counter
            // 
            counter.AutoSize = true;
            counter.Location = new Point(212, 151);
            counter.Name = "counter";
            counter.Size = new Size(0, 20);
            counter.TabIndex = 12;
            // 
            // stats
            // 
            stats.AutoSize = true;
            stats.Location = new Point(3, 386);
            stats.Name = "stats";
            stats.Size = new Size(56, 20);
            stats.TabIndex = 11;
            stats.Text = "Status: ";
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(186, 348);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(94, 29);
            browseBtn.TabIndex = 10;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += Browse_Click;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(3, 348);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(94, 29);
            startBtn.TabIndex = 9;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // SelectG
            // 
            SelectG.FormattingEnabled = true;
            SelectG.Location = new Point(38, 148);
            SelectG.Name = "SelectG";
            SelectG.Size = new Size(151, 28);
            SelectG.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 271);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 7;
            label6.Text = "k0 :";
            // 
            // inputK
            // 
            inputK.Location = new Point(3, 305);
            inputK.Name = "inputK";
            inputK.Size = new Size(277, 27);
            inputK.TabIndex = 6;
            // 
            // inputX
            // 
            inputX.Location = new Point(3, 226);
            inputX.Name = "inputX";
            inputX.Size = new Size(277, 27);
            inputX.TabIndex = 5;
            // 
            // inputP
            // 
            inputP.Location = new Point(3, 86);
            inputP.Name = "inputP";
            inputP.Size = new Size(277, 27);
            inputP.TabIndex = 4;
            inputP.TextChanged += PChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 191);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 3;
            label5.Text = "x :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 148);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 2;
            label4.Text = "g : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 1;
            label3.Text = "p (>255; <500) : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 35);
            label2.TabIndex = 0;
            label2.Text = "Input";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 12);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 2;
            label7.Text = "Plane file";
            // 
            // PlainFile
            // 
            PlainFile.Location = new Point(349, 51);
            PlainFile.Multiline = true;
            PlainFile.Name = "PlainFile";
            PlainFile.Size = new Size(380, 180);
            PlainFile.TabIndex = 3;
            // 
            // EncFile
            // 
            EncFile.Location = new Point(349, 305);
            EncFile.Multiline = true;
            EncFile.Name = "EncFile";
            EncFile.Size = new Size(380, 180);
            EncFile.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 260);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 5;
            label8.Text = "Encrypted file";
            // 
            // lab3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 504);
            Controls.Add(label8);
            Controls.Add(EncFile);
            Controls.Add(PlainFile);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "lab3";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton enableDecryption;
        private RadioButton enableEncryption;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ComboBox SelectG;
        private Label label6;
        private TextBox inputK;
        private TextBox inputX;
        private TextBox inputP;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button browseBtn;
        private Button startBtn;
        private Label label7;
        private TextBox PlainFile;
        private TextBox EncFile;
        private Label label8;
        private Label stats;
        private Label counter;
    }
}
