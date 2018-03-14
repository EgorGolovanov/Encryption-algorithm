namespace AssimmetryAlgorithmEncryption
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.InputTextRB = new System.Windows.Forms.RichTextBox();
            this.EncryptionButton = new System.Windows.Forms.Button();
            this.EducationButton = new System.Windows.Forms.Button();
            this.OutputTextRB = new System.Windows.Forms.RichTextBox();
            this.AlgorithmsGB = new System.Windows.Forms.GroupBox();
            this.RSACheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.AlgoRSAGroupBox = new System.Windows.Forms.GroupBox();
            this.KeyDTextBox = new System.Windows.Forms.TextBox();
            this.KeyNTextBox = new System.Windows.Forms.TextBox();
            this.Infolabel1 = new System.Windows.Forms.Label();
            this.EncryptRSAButton = new System.Windows.Forms.Button();
            this.DecipherRSAButton = new System.Windows.Forms.Button();
            this.DLabel = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.AlgorithmsGB.SuspendLayout();
            this.AlgoRSAGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(0, 346);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(50, 50);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "<----\r\n";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Location = new System.Drawing.Point(708, 346);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(50, 50);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "---->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Visible = false;
            // 
            // InputTextRB
            // 
            this.InputTextRB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputTextRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextRB.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputTextRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextRB.Location = new System.Drawing.Point(0, 0);
            this.InputTextRB.Name = "InputTextRB";
            this.InputTextRB.Size = new System.Drawing.Size(270, 397);
            this.InputTextRB.TabIndex = 2;
            this.InputTextRB.Text = "";
            this.InputTextRB.Visible = false;
            // 
            // EncryptionButton
            // 
            this.EncryptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EncryptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptionButton.Location = new System.Drawing.Point(154, 219);
            this.EncryptionButton.Name = "EncryptionButton";
            this.EncryptionButton.Size = new System.Drawing.Size(200, 100);
            this.EncryptionButton.TabIndex = 3;
            this.EncryptionButton.Text = "Воспользоваться шифрованием";
            this.EncryptionButton.UseVisualStyleBackColor = true;
            this.EncryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // EducationButton
            // 
            this.EducationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EducationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EducationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EducationButton.Location = new System.Drawing.Point(401, 219);
            this.EducationButton.Name = "EducationButton";
            this.EducationButton.Size = new System.Drawing.Size(200, 100);
            this.EducationButton.TabIndex = 4;
            this.EducationButton.Text = "Увидеть работу алгоритма\r\n";
            this.EducationButton.UseVisualStyleBackColor = false;
            // 
            // OutputTextRB
            // 
            this.OutputTextRB.Dock = System.Windows.Forms.DockStyle.Right;
            this.OutputTextRB.Enabled = false;
            this.OutputTextRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextRB.Location = new System.Drawing.Point(487, 0);
            this.OutputTextRB.Name = "OutputTextRB";
            this.OutputTextRB.Size = new System.Drawing.Size(271, 397);
            this.OutputTextRB.TabIndex = 5;
            this.OutputTextRB.Text = "";
            this.OutputTextRB.Visible = false;
            // 
            // AlgorithmsGB
            // 
            this.AlgorithmsGB.Controls.Add(this.checkBox2);
            this.AlgorithmsGB.Controls.Add(this.RSACheckBox);
            this.AlgorithmsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlgorithmsGB.Location = new System.Drawing.Point(276, 12);
            this.AlgorithmsGB.Name = "AlgorithmsGB";
            this.AlgorithmsGB.Size = new System.Drawing.Size(205, 100);
            this.AlgorithmsGB.TabIndex = 7;
            this.AlgorithmsGB.TabStop = false;
            this.AlgorithmsGB.Text = "Выберите алгоритм для использования";
            this.AlgorithmsGB.Visible = false;
            // 
            // RSACheckBox
            // 
            this.RSACheckBox.AutoSize = true;
            this.RSACheckBox.Checked = true;
            this.RSACheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RSACheckBox.Location = new System.Drawing.Point(6, 39);
            this.RSACheckBox.Name = "RSACheckBox";
            this.RSACheckBox.Size = new System.Drawing.Size(121, 21);
            this.RSACheckBox.TabIndex = 0;
            this.RSACheckBox.Text = "Алгоритм RSA";
            this.RSACheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(181, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Еще какой то алгортим";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // AlgoRSAGroupBox
            // 
            this.AlgoRSAGroupBox.Controls.Add(this.NLabel);
            this.AlgoRSAGroupBox.Controls.Add(this.DLabel);
            this.AlgoRSAGroupBox.Controls.Add(this.DecipherRSAButton);
            this.AlgoRSAGroupBox.Controls.Add(this.EncryptRSAButton);
            this.AlgoRSAGroupBox.Controls.Add(this.Infolabel1);
            this.AlgoRSAGroupBox.Controls.Add(this.KeyNTextBox);
            this.AlgoRSAGroupBox.Controls.Add(this.KeyDTextBox);
            this.AlgoRSAGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlgoRSAGroupBox.Location = new System.Drawing.Point(276, 118);
            this.AlgoRSAGroupBox.Name = "AlgoRSAGroupBox";
            this.AlgoRSAGroupBox.Size = new System.Drawing.Size(205, 267);
            this.AlgoRSAGroupBox.TabIndex = 8;
            this.AlgoRSAGroupBox.TabStop = false;
            this.AlgoRSAGroupBox.Text = "Алгоритм RSA";
            this.AlgoRSAGroupBox.Visible = false;
            // 
            // KeyDTextBox
            // 
            this.KeyDTextBox.Location = new System.Drawing.Point(64, 56);
            this.KeyDTextBox.Name = "KeyDTextBox";
            this.KeyDTextBox.Size = new System.Drawing.Size(136, 23);
            this.KeyDTextBox.TabIndex = 0;
            // 
            // KeyNTextBox
            // 
            this.KeyNTextBox.Location = new System.Drawing.Point(64, 85);
            this.KeyNTextBox.Name = "KeyNTextBox";
            this.KeyNTextBox.Size = new System.Drawing.Size(136, 23);
            this.KeyNTextBox.TabIndex = 1;
            // 
            // Infolabel1
            // 
            this.Infolabel1.AutoSize = true;
            this.Infolabel1.Location = new System.Drawing.Point(6, 19);
            this.Infolabel1.Name = "Infolabel1";
            this.Infolabel1.Size = new System.Drawing.Size(175, 34);
            this.Infolabel1.TabIndex = 2;
            this.Infolabel1.Text = "Введите секретный ключ\r\nдля расшифровки\r\n";
            // 
            // EncryptRSAButton
            // 
            this.EncryptRSAButton.Location = new System.Drawing.Point(9, 188);
            this.EncryptRSAButton.Name = "EncryptRSAButton";
            this.EncryptRSAButton.Size = new System.Drawing.Size(190, 33);
            this.EncryptRSAButton.TabIndex = 3;
            this.EncryptRSAButton.Text = "Зашифровать";
            this.EncryptRSAButton.UseVisualStyleBackColor = true;
            this.EncryptRSAButton.Click += new System.EventHandler(this.EncryptRSAButton_Click);
            // 
            // DecipherRSAButton
            // 
            this.DecipherRSAButton.Location = new System.Drawing.Point(9, 228);
            this.DecipherRSAButton.Name = "DecipherRSAButton";
            this.DecipherRSAButton.Size = new System.Drawing.Size(190, 33);
            this.DecipherRSAButton.TabIndex = 4;
            this.DecipherRSAButton.Text = "Расшифровать";
            this.DecipherRSAButton.UseVisualStyleBackColor = true;
            this.DecipherRSAButton.Click += new System.EventHandler(this.DecipherRSAButton_Click);
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(24, 59);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(34, 17);
            this.DLabel.TabIndex = 5;
            this.DLabel.Text = "D = ";
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Location = new System.Drawing.Point(24, 88);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(34, 17);
            this.NLabel.TabIndex = 6;
            this.NLabel.Text = "N = ";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(758, 397);
            this.Controls.Add(this.AlgoRSAGroupBox);
            this.Controls.Add(this.AlgorithmsGB);
            this.Controls.Add(this.EducationButton);
            this.Controls.Add(this.EncryptionButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InputTextRB);
            this.Controls.Add(this.OutputTextRB);
            this.MinimumSize = new System.Drawing.Size(725, 365);
            this.Name = "Main_Form";
            this.Text = "Обучающее приложение";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AlgorithmsGB.ResumeLayout(false);
            this.AlgorithmsGB.PerformLayout();
            this.AlgoRSAGroupBox.ResumeLayout(false);
            this.AlgoRSAGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.RichTextBox InputTextRB;
        private System.Windows.Forms.Button EncryptionButton;
        private System.Windows.Forms.Button EducationButton;
        private System.Windows.Forms.RichTextBox OutputTextRB;
        private System.Windows.Forms.GroupBox AlgorithmsGB;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox RSACheckBox;
        private System.Windows.Forms.GroupBox AlgoRSAGroupBox;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Button DecipherRSAButton;
        private System.Windows.Forms.Button EncryptRSAButton;
        private System.Windows.Forms.Label Infolabel1;
        private System.Windows.Forms.TextBox KeyNTextBox;
        private System.Windows.Forms.TextBox KeyDTextBox;
    }
}

