namespace test11
{
    partial class DataVMP
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
            txtbox_data = new TextBox();
            txtbox_vmp = new TextBox();
            button1 = new Button();
            txtbox_lpu11 = new TextBox();
            btnback = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            txtbox_filename1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            lbl_file = new Label();
            SuspendLayout();
            // 
            // txtbox_data
            // 
            txtbox_data.Location = new Point(134, 116);
            txtbox_data.Name = "txtbox_data";
            txtbox_data.Size = new Size(159, 23);
            txtbox_data.TabIndex = 0;
            // 
            // txtbox_vmp
            // 
            txtbox_vmp.Location = new Point(134, 156);
            txtbox_vmp.Name = "txtbox_vmp";
            txtbox_vmp.Size = new Size(159, 23);
            txtbox_vmp.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(120, 252);
            button1.Name = "button1";
            button1.Size = new Size(141, 31);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtbox_lpu11
            // 
            txtbox_lpu11.Location = new Point(134, 197);
            txtbox_lpu11.Name = "txtbox_lpu11";
            txtbox_lpu11.Size = new Size(159, 23);
            txtbox_lpu11.TabIndex = 3;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Info;
            btnback.Location = new Point(12, 12);
            btnback.Name = "btnback";
            btnback.Size = new Size(70, 31);
            btnback.TabIndex = 4;
            btnback.Text = "Назад";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(72, 119);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(69, 159);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Код ВМП";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(30, 190);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 7;
            label3.Text = "Необходимое\r\nзначение  LPU_1";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(619, 14);
            button2.Name = "button2";
            button2.Size = new Size(130, 31);
            button2.TabIndex = 8;
            button2.Text = "Открыть файл";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtbox_filename1
            // 
            txtbox_filename1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_filename1.Location = new Point(215, 16);
            txtbox_filename1.Name = "txtbox_filename1";
            txtbox_filename1.Size = new Size(398, 29);
            txtbox_filename1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(299, 119);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 14;
            label4.Text = "В формате XXXX-XX-XX";
            // 
            // lbl_file
            // 
            lbl_file.AutoSize = true;
            lbl_file.BackColor = Color.Transparent;
            lbl_file.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_file.Location = new Point(101, 22);
            lbl_file.Name = "lbl_file";
            lbl_file.Size = new Size(108, 21);
            lbl_file.TabIndex = 15;
            lbl_file.Text = "Выбран файл:";
            // 
            // DataVMP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            BackgroundImage = Properties.Resources._2024_03_05_14_52_46;
            ClientSize = new Size(761, 301);
            Controls.Add(lbl_file);
            Controls.Add(label4);
            Controls.Add(txtbox_filename1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnback);
            Controls.Add(txtbox_lpu11);
            Controls.Add(button1);
            Controls.Add(txtbox_vmp);
            Controls.Add(txtbox_data);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "DataVMP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчёт по дате и коду ВМП";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_data;
        private TextBox txtbox_vmp;
        private Button button1;
        private TextBox txtbox_lpu11;
        private Button btnback;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private TextBox txtbox_filename1;
        private OpenFileDialog openFileDialog1;
        private Label label4;
        private Label lbl_file;
    }
}