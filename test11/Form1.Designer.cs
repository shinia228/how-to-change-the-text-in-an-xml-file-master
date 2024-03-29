namespace test11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_openfile = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtbox_filename = new TextBox();
            lbl_file = new Label();
            btnsave = new Button();
            lbldata = new Label();
            lblsnils = new Label();
            txtbox_snils = new TextBox();
            txtbox_spec = new TextBox();
            lbl_rvs = new Label();
            lbl_lpu1 = new Label();
            txtbox_lpu1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbox_data1 = new TextBox();
            txtbox_vmp = new TextBox();
            label4 = new Label();
            btn_back_menu = new Button();
            SuspendLayout();
            // 
            // btn_openfile
            // 
            btn_openfile.BackColor = SystemColors.Info;
            btn_openfile.Location = new Point(503, 24);
            btn_openfile.Name = "btn_openfile";
            btn_openfile.Size = new Size(146, 32);
            btn_openfile.TabIndex = 0;
            btn_openfile.Text = "Открыть файл";
            btn_openfile.UseVisualStyleBackColor = false;
            btn_openfile.Click += btn_openfile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtbox_filename
            // 
            txtbox_filename.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_filename.Location = new Point(226, 30);
            txtbox_filename.Name = "txtbox_filename";
            txtbox_filename.Size = new Size(271, 26);
            txtbox_filename.TabIndex = 1;
            // 
            // lbl_file
            // 
            lbl_file.AutoSize = true;
            lbl_file.BackColor = Color.Transparent;
            lbl_file.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_file.Location = new Point(114, 35);
            lbl_file.Name = "lbl_file";
            lbl_file.Size = new Size(108, 21);
            lbl_file.TabIndex = 2;
            lbl_file.Text = "Выбран файл:";
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.Info;
            btnsave.Location = new Point(213, 375);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(212, 34);
            btnsave.TabIndex = 3;
            btnsave.Text = "Сохранить";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // lbldata
            // 
            lbldata.AutoSize = true;
            lbldata.BackColor = Color.Transparent;
            lbldata.Location = new Point(230, 184);
            lbldata.Name = "lbldata";
            lbldata.Size = new Size(32, 15);
            lbldata.TabIndex = 5;
            lbldata.Text = "Дата";
            // 
            // lblsnils
            // 
            lblsnils.AutoSize = true;
            lblsnils.BackColor = Color.Transparent;
            lblsnils.Location = new Point(213, 225);
            lblsnils.Name = "lblsnils";
            lblsnils.Size = new Size(49, 15);
            lblsnils.TabIndex = 6;
            lblsnils.Text = "СНИЛС";
            // 
            // txtbox_snils
            // 
            txtbox_snils.Location = new Point(284, 225);
            txtbox_snils.Name = "txtbox_snils";
            txtbox_snils.Size = new Size(169, 23);
            txtbox_snils.TabIndex = 7;
            // 
            // txtbox_spec
            // 
            txtbox_spec.Location = new Point(284, 261);
            txtbox_spec.Name = "txtbox_spec";
            txtbox_spec.Size = new Size(169, 23);
            txtbox_spec.TabIndex = 8;
            // 
            // lbl_rvs
            // 
            lbl_rvs.AutoSize = true;
            lbl_rvs.BackColor = Color.Transparent;
            lbl_rvs.Location = new Point(153, 264);
            lbl_rvs.Name = "lbl_rvs";
            lbl_rvs.Size = new Size(125, 15);
            lbl_rvs.TabIndex = 9;
            lbl_rvs.Text = "Специальность (РВС)";
            // 
            // lbl_lpu1
            // 
            lbl_lpu1.AutoSize = true;
            lbl_lpu1.BackColor = Color.Transparent;
            lbl_lpu1.Location = new Point(159, 303);
            lbl_lpu1.Name = "lbl_lpu1";
            lbl_lpu1.Size = new Size(39, 15);
            lbl_lpu1.TabIndex = 10;
            lbl_lpu1.Text = "LPU_1";
            // 
            // txtbox_lpu1
            // 
            txtbox_lpu1.Location = new Point(19, 321);
            txtbox_lpu1.Name = "txtbox_lpu1";
            txtbox_lpu1.Size = new Size(169, 23);
            txtbox_lpu1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(12, 137);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 12;
            button1.Text = "Только Дата";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(459, 184);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 13;
            label1.Text = "В формате XXXX-XX-XX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 109);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 14;
            label2.Text = "Заполните фильтры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 303);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 15;
            label3.Text = "Необходимое значение ";
            // 
            // txtbox_data1
            // 
            txtbox_data1.Location = new Point(284, 186);
            txtbox_data1.Name = "txtbox_data1";
            txtbox_data1.Size = new Size(169, 23);
            txtbox_data1.TabIndex = 16;
            // 
            // txtbox_vmp
            // 
            txtbox_vmp.Location = new Point(284, 295);
            txtbox_vmp.Name = "txtbox_vmp";
            txtbox_vmp.Size = new Size(169, 23);
            txtbox_vmp.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(221, 295);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 18;
            label4.Text = "Код ВМП";
            // 
            // btn_back_menu
            // 
            btn_back_menu.BackColor = SystemColors.Info;
            btn_back_menu.Location = new Point(12, 12);
            btn_back_menu.Name = "btn_back_menu";
            btn_back_menu.Size = new Size(84, 44);
            btn_back_menu.TabIndex = 19;
            btn_back_menu.Text = "Назад";
            btn_back_menu.UseVisualStyleBackColor = false;
            btn_back_menu.Click += btn_back_menu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(661, 450);
            Controls.Add(btn_back_menu);
            Controls.Add(label4);
            Controls.Add(txtbox_vmp);
            Controls.Add(txtbox_data1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtbox_lpu1);
            Controls.Add(lbl_lpu1);
            Controls.Add(lbl_rvs);
            Controls.Add(txtbox_spec);
            Controls.Add(txtbox_snils);
            Controls.Add(lblsnils);
            Controls.Add(lbldata);
            Controls.Add(btnsave);
            Controls.Add(lbl_file);
            Controls.Add(txtbox_filename);
            Controls.Add(btn_openfile);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчет коэффициентов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_openfile;
        private OpenFileDialog openFileDialog1;
        private TextBox txtbox_filename;
        private Label lbl_file;
        private Button btnsave;
        private Label lbldata;
        private Label lblsnils;
        private TextBox txtbox_snils;
        private TextBox txtbox_spec;
        private Label lbl_rvs;
        private Label lbl_lpu1;
        private TextBox txtbox_lpu1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbox_data1;
        private TextBox txtbox_vmp;
        private Label label4;
        private Button btn_back_menu;
    }
}
