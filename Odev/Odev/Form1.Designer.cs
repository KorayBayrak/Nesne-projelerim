namespace Odev
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonKayitOl = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            buttonTemizle = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            buttonGoster = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(274, 22);
            label1.Name = "label1";
            label1.Size = new Size(242, 28);
            label1.TabIndex = 0;
            label1.Text = "Nesne 4.Hafta Ödev";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(buttonKayitOl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 253);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Kayıt Menusu";
            // 
            // buttonKayitOl
            // 
            buttonKayitOl.BackColor = Color.FromArgb(255, 192, 192);
            buttonKayitOl.Location = new Point(138, 189);
            buttonKayitOl.Name = "buttonKayitOl";
            buttonKayitOl.Size = new Size(127, 45);
            buttonKayitOl.TabIndex = 3;
            buttonKayitOl.Text = "Kayıt Ol";
            buttonKayitOl.UseVisualStyleBackColor = false;
            buttonKayitOl.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon Numarası :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(73, 154);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 44);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adı-Soyadı :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(buttonTemizle);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(buttonGoster);
            groupBox2.Location = new Point(451, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 452);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcı Bilgileri";
            // 
            // buttonTemizle
            // 
            buttonTemizle.BackColor = Color.FromArgb(255, 192, 192);
            buttonTemizle.Location = new Point(121, 358);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(106, 53);
            buttonTemizle.TabIndex = 3;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = false;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(358, 23);
            comboBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 156);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(358, 169);
            listBox1.TabIndex = 1;
            // 
            // buttonGoster
            // 
            buttonGoster.BackColor = Color.FromArgb(255, 192, 192);
            buttonGoster.Location = new Point(28, 34);
            buttonGoster.Name = "buttonGoster";
            buttonGoster.Size = new Size(291, 46);
            buttonGoster.TabIndex = 0;
            buttonGoster.Text = "Bilgileri Göster";
            buttonGoster.UseVisualStyleBackColor = false;
            buttonGoster.Click += buttonGoster_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(451, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 10);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(958, 584);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label2;
        private Button buttonKayitOl;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Button buttonGoster;
        private Panel panel1;
        private Button buttonTemizle;
        private ComboBox comboBox1;
        private ListBox listBox1;
    }
}