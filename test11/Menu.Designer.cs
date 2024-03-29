namespace test11
{
    partial class Menu
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
            btn_datavmp = new Button();
            btn_all = new Button();
            SuspendLayout();
            // 
            // btn_datavmp
            // 
            btn_datavmp.Location = new Point(67, 49);
            btn_datavmp.Name = "btn_datavmp";
            btn_datavmp.Size = new Size(181, 38);
            btn_datavmp.TabIndex = 0;
            btn_datavmp.Text = "По дате и коду ВМП";
            btn_datavmp.UseVisualStyleBackColor = true;
            btn_datavmp.Click += btn_datavmp_Click;
            // 
            // btn_all
            // 
            btn_all.Location = new Point(67, 106);
            btn_all.Name = "btn_all";
            btn_all.Size = new Size(181, 40);
            btn_all.TabIndex = 1;
            btn_all.Text = "По дате, СНИЛС, специальности (РВС) и коду ВМП";
            btn_all.UseVisualStyleBackColor = true;
            btn_all.Click += btn_all_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            BackgroundImage = Properties.Resources._2024_03_05_14_52_46;
            ClientSize = new Size(319, 218);
            Controls.Add(btn_all);
            Controls.Add(btn_datavmp);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_datavmp;
        private Button btn_all;
    }
}