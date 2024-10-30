namespace lab4
{
    partial class lab4
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
            start_btn = new Button();
            browse_btn = new Button();
            panel1 = new Panel();
            check_rbtn = new RadioButton();
            sign_rbtn = new RadioButton();
            file_txt = new TextBox();
            prime_box1 = new ComboBox();
            prime_box2 = new ComboBox();
            p_label = new Label();
            q_label = new Label();
            r_label = new Label();
            phi_r_label = new Label();
            d_txt = new TextBox();
            d_label = new Label();
            e_label = new Label();
            hash_label = new Label();
            label2 = new Label();
            orig_hash_lable = new Label();
            init_btn = new Button();
            result_label = new Label();
            sign_label = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // start_btn
            // 
            start_btn.Enabled = false;
            start_btn.Location = new Point(12, 475);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(94, 29);
            start_btn.TabIndex = 0;
            start_btn.Text = "Start";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // browse_btn
            // 
            browse_btn.Location = new Point(168, 475);
            browse_btn.Name = "browse_btn";
            browse_btn.Size = new Size(94, 29);
            browse_btn.TabIndex = 1;
            browse_btn.Text = "Browse";
            browse_btn.UseVisualStyleBackColor = true;
            browse_btn.Click += browse_btn_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(check_rbtn);
            panel1.Controls.Add(sign_rbtn);
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 69);
            panel1.TabIndex = 2;
            // 
            // check_rbtn
            // 
            check_rbtn.AutoSize = true;
            check_rbtn.Location = new Point(3, 33);
            check_rbtn.Name = "check_rbtn";
            check_rbtn.Size = new Size(69, 24);
            check_rbtn.TabIndex = 1;
            check_rbtn.Text = "Check";
            check_rbtn.UseVisualStyleBackColor = true;
            check_rbtn.CheckedChanged += check_rbtn_CheckedChanged;
            // 
            // sign_rbtn
            // 
            sign_rbtn.AutoSize = true;
            sign_rbtn.Checked = true;
            sign_rbtn.Location = new Point(3, 3);
            sign_rbtn.Name = "sign_rbtn";
            sign_rbtn.Size = new Size(59, 24);
            sign_rbtn.TabIndex = 0;
            sign_rbtn.TabStop = true;
            sign_rbtn.Text = "Sign";
            sign_rbtn.UseVisualStyleBackColor = true;
            sign_rbtn.CheckedChanged += sign_rbtn_CheckedChanged;
            // 
            // file_txt
            // 
            file_txt.Location = new Point(12, 243);
            file_txt.Multiline = true;
            file_txt.Name = "file_txt";
            file_txt.Size = new Size(250, 87);
            file_txt.TabIndex = 3;
            // 
            // prime_box1
            // 
            prime_box1.FormattingEnabled = true;
            prime_box1.Location = new Point(128, 12);
            prime_box1.Name = "prime_box1";
            prime_box1.Size = new Size(151, 28);
            prime_box1.TabIndex = 5;
            prime_box1.SelectedIndexChanged += prime_box1_SelectedIndexChanged;
            // 
            // prime_box2
            // 
            prime_box2.FormattingEnabled = true;
            prime_box2.Location = new Point(128, 45);
            prime_box2.Name = "prime_box2";
            prime_box2.Size = new Size(151, 28);
            prime_box2.TabIndex = 6;
            prime_box2.SelectedIndexChanged += prime_box2_SelectedIndexChanged;
            // 
            // p_label
            // 
            p_label.AutoSize = true;
            p_label.Location = new Point(90, 15);
            p_label.Name = "p_label";
            p_label.Size = new Size(32, 20);
            p_label.TabIndex = 7;
            p_label.Text = "p =";
            // 
            // q_label
            // 
            q_label.AutoSize = true;
            q_label.Location = new Point(90, 45);
            q_label.Name = "q_label";
            q_label.Size = new Size(32, 20);
            q_label.TabIndex = 8;
            q_label.Text = "q =";
            // 
            // r_label
            // 
            r_label.AutoSize = true;
            r_label.Location = new Point(12, 97);
            r_label.Name = "r_label";
            r_label.Size = new Size(32, 20);
            r_label.TabIndex = 9;
            r_label.Text = "r = ";
            // 
            // phi_r_label
            // 
            phi_r_label.AutoSize = true;
            phi_r_label.Location = new Point(12, 127);
            phi_r_label.Name = "phi_r_label";
            phi_r_label.Size = new Size(48, 20);
            phi_r_label.TabIndex = 10;
            phi_r_label.Text = "φ(r) =";
            // 
            // d_txt
            // 
            d_txt.Location = new Point(131, 84);
            d_txt.Name = "d_txt";
            d_txt.ReadOnly = true;
            d_txt.Size = new Size(125, 27);
            d_txt.TabIndex = 11;
            // 
            // d_label
            // 
            d_label.AutoSize = true;
            d_label.Location = new Point(93, 87);
            d_label.Name = "d_label";
            d_label.Size = new Size(36, 20);
            d_label.TabIndex = 12;
            d_label.Text = "d = ";
            // 
            // e_label
            // 
            e_label.AutoSize = true;
            e_label.Location = new Point(93, 127);
            e_label.Name = "e_label";
            e_label.Size = new Size(35, 20);
            e_label.TabIndex = 13;
            e_label.Text = "e = ";
            // 
            // hash_label
            // 
            hash_label.AutoSize = true;
            hash_label.Location = new Point(12, 357);
            hash_label.Name = "hash_label";
            hash_label.Size = new Size(57, 20);
            hash_label.TabIndex = 14;
            hash_label.Text = "hash = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 220);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 15;
            label2.Text = "file content:";
            // 
            // orig_hash_lable
            // 
            orig_hash_lable.AutoSize = true;
            orig_hash_lable.Location = new Point(12, 398);
            orig_hash_lable.Name = "orig_hash_lable";
            orig_hash_lable.Size = new Size(116, 20);
            orig_hash_lable.TabIndex = 16;
            orig_hash_lable.Text = "original hash  = ";
            // 
            // init_btn
            // 
            init_btn.Location = new Point(81, 168);
            init_btn.Name = "init_btn";
            init_btn.Size = new Size(94, 29);
            init_btn.TabIndex = 17;
            init_btn.Text = "Init";
            init_btn.UseVisualStyleBackColor = true;
            init_btn.Click += init_btn_Click;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Location = new Point(16, 438);
            result_label.Name = "result_label";
            result_label.Size = new Size(52, 20);
            result_label.TabIndex = 18;
            result_label.Text = "Result:";
            // 
            // sign_label
            // 
            sign_label.AutoSize = true;
            sign_label.Location = new Point(143, 357);
            sign_label.Name = "sign_label";
            sign_label.Size = new Size(54, 20);
            sign_label.TabIndex = 19;
            sign_label.Text = "sign = ";
            // 
            // lab4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 516);
            Controls.Add(sign_label);
            Controls.Add(result_label);
            Controls.Add(init_btn);
            Controls.Add(orig_hash_lable);
            Controls.Add(label2);
            Controls.Add(hash_label);
            Controls.Add(e_label);
            Controls.Add(d_label);
            Controls.Add(d_txt);
            Controls.Add(phi_r_label);
            Controls.Add(r_label);
            Controls.Add(q_label);
            Controls.Add(p_label);
            Controls.Add(prime_box2);
            Controls.Add(prime_box1);
            Controls.Add(file_txt);
            Controls.Add(panel1);
            Controls.Add(browse_btn);
            Controls.Add(start_btn);
            Name = "lab4";
            Text = "lab4";
            Load += lab4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_btn;
        private Button browse_btn;
        private Panel panel1;
        private RadioButton sign_rbtn;
        private RadioButton check_rbtn;
        private TextBox file_txt;
        private ComboBox prime_box1;
        private ComboBox prime_box2;
        private Label p_label;
        private Label q_label;
        private Label r_label;
        private Label phi_r_label;
        private TextBox d_txt;
        private Label d_label;
        private Label e_label;
        private Label hash_label;
        private Label label2;
        private Label orig_hash_lable;
        private Button init_btn;
        private Label result_label;
        private Label sign_label;
    }
}
