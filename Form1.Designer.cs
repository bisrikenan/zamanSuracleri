namespace zamanSuracleri
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
            components = new System.ComponentModel.Container();
            StartButton = new Button();
            stopButton = new Button();
            resetButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelSaat = new Label();
            labelDakika = new Label();
            labelSaniye = new Label();
            labelSalise = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(255, 128, 128);
            StartButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            StartButton.ForeColor = Color.Yellow;
            StartButton.Location = new Point(34, 229);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(176, 123);
            StartButton.TabIndex = 0;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.FromArgb(255, 128, 128);
            stopButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            stopButton.ForeColor = Color.Yellow;
            stopButton.Location = new Point(272, 229);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(176, 123);
            stopButton.TabIndex = 1;
            stopButton.Text = "STOP";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(255, 128, 128);
            resetButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            resetButton.ForeColor = Color.Yellow;
            resetButton.Location = new Point(504, 229);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(176, 123);
            resetButton.TabIndex = 2;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(34, 36);
            label2.Name = "label2";
            label2.Size = new Size(80, 45);
            label2.TabIndex = 4;
            label2.Text = "Saat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(170, 36);
            label3.Name = "label3";
            label3.Size = new Size(114, 45);
            label3.TabIndex = 5;
            label3.Text = "Dakika";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(337, 36);
            label4.Name = "label4";
            label4.Size = new Size(111, 45);
            label4.TabIndex = 6;
            label4.Text = "Saniye";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(487, 36);
            label5.Name = "label5";
            label5.Size = new Size(100, 45);
            label5.TabIndex = 7;
            label5.Text = "Salise";
            // 
            // labelSaat
            // 
            labelSaat.BackColor = Color.White;
            labelSaat.BorderStyle = BorderStyle.FixedSingle;
            labelSaat.Font = new Font("Segoe UI", 15F);
            labelSaat.ForeColor = Color.Red;
            labelSaat.Location = new Point(34, 81);
            labelSaat.Name = "labelSaat";
            labelSaat.Size = new Size(89, 56);
            labelSaat.TabIndex = 8;
            labelSaat.Text = "0";
            labelSaat.TextAlign = ContentAlignment.TopRight;
            // 
            // labelDakika
            // 
            labelDakika.BackColor = Color.White;
            labelDakika.BorderStyle = BorderStyle.FixedSingle;
            labelDakika.Font = new Font("Segoe UI", 15F);
            labelDakika.ForeColor = Color.Red;
            labelDakika.Location = new Point(187, 81);
            labelDakika.Name = "labelDakika";
            labelDakika.Size = new Size(97, 56);
            labelDakika.TabIndex = 9;
            labelDakika.Text = "0";
            labelDakika.TextAlign = ContentAlignment.TopRight;
            // 
            // labelSaniye
            // 
            labelSaniye.BackColor = Color.White;
            labelSaniye.BorderStyle = BorderStyle.FixedSingle;
            labelSaniye.Font = new Font("Segoe UI", 15F);
            labelSaniye.ForeColor = Color.Red;
            labelSaniye.Location = new Point(341, 81);
            labelSaniye.Name = "labelSaniye";
            labelSaniye.Size = new Size(98, 56);
            labelSaniye.TabIndex = 10;
            labelSaniye.Text = "0";
            labelSaniye.TextAlign = ContentAlignment.TopRight;
            // 
            // labelSalise
            // 
            labelSalise.BackColor = Color.White;
            labelSalise.BorderStyle = BorderStyle.FixedSingle;
            labelSalise.Font = new Font("Segoe UI", 15F);
            labelSalise.ForeColor = Color.Red;
            labelSalise.Location = new Point(487, 81);
            labelSalise.Name = "labelSalise";
            labelSalise.Size = new Size(97, 56);
            labelSalise.TabIndex = 11;
            labelSalise.Text = "0";
            labelSalise.TextAlign = ContentAlignment.TopRight;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.ForeColor = Color.Red;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 54;
            listBox1.Location = new Point(34, 372);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(646, 328);
            listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(939, 784);
            Controls.Add(listBox1);
            Controls.Add(labelSalise);
            Controls.Add(labelSaniye);
            Controls.Add(labelDakika);
            Controls.Add(labelSaat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(resetButton);
            Controls.Add(stopButton);
            Controls.Add(StartButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button stopButton;
        private Button resetButton;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelSaat;
        private Label labelDakika;
        private Label labelSaniye;
        private Label labelSalise;
        private ListBox listBox1;
    }
}
