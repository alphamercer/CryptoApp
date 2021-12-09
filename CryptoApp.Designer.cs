namespace CryptoApp
{
    partial class CryptoApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabSkitala = new System.Windows.Forms.TabPage();
            this.key_S = new System.Windows.Forms.NumericUpDown();
            this.label2_S = new System.Windows.Forms.Label();
            this.checkBox_S = new System.Windows.Forms.CheckBox();
            this.label3_S = new System.Windows.Forms.Label();
            this.output_S = new System.Windows.Forms.TextBox();
            this.ButtonSkitala = new System.Windows.Forms.Button();
            this.label1_S = new System.Windows.Forms.Label();
            this.input_S = new System.Windows.Forms.TextBox();
            this.TabPolybius = new System.Windows.Forms.TabPage();
            this.checkBox_PS = new System.Windows.Forms.CheckBox();
            this.ButtonPolybius = new System.Windows.Forms.Button();
            this.label2_PS = new System.Windows.Forms.Label();
            this.label4_PS = new System.Windows.Forms.Label();
            this.label1_PS = new System.Windows.Forms.Label();
            this.output_PS = new System.Windows.Forms.TextBox();
            this.key_PS = new System.Windows.Forms.TextBox();
            this.input_PS = new System.Windows.Forms.TextBox();
            this.TabGronsfeld = new System.Windows.Forms.TabPage();
            this.label3_GF = new System.Windows.Forms.Label();
            this.label2_GF = new System.Windows.Forms.Label();
            this.label1_GF = new System.Windows.Forms.Label();
            this.checkBox_GF = new System.Windows.Forms.CheckBox();
            this.key_GF = new System.Windows.Forms.TextBox();
            this.input_GF = new System.Windows.Forms.TextBox();
            this.output_GF = new System.Windows.Forms.TextBox();
            this.ButtonGronsfeld = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabSkitala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key_S)).BeginInit();
            this.TabPolybius.SuspendLayout();
            this.TabGronsfeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabSkitala);
            this.tabControl1.Controls.Add(this.TabPolybius);
            this.tabControl1.Controls.Add(this.TabGronsfeld);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(304, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // TabSkitala
            // 
            this.TabSkitala.Controls.Add(this.key_S);
            this.TabSkitala.Controls.Add(this.label2_S);
            this.TabSkitala.Controls.Add(this.checkBox_S);
            this.TabSkitala.Controls.Add(this.label3_S);
            this.TabSkitala.Controls.Add(this.output_S);
            this.TabSkitala.Controls.Add(this.ButtonSkitala);
            this.TabSkitala.Controls.Add(this.label1_S);
            this.TabSkitala.Controls.Add(this.input_S);
            this.TabSkitala.Location = new System.Drawing.Point(4, 22);
            this.TabSkitala.Name = "TabSkitala";
            this.TabSkitala.Padding = new System.Windows.Forms.Padding(3);
            this.TabSkitala.Size = new System.Drawing.Size(296, 272);
            this.TabSkitala.TabIndex = 0;
            this.TabSkitala.Text = "Скитала";
            this.TabSkitala.UseVisualStyleBackColor = true;
            // 
            // key_S
            // 
            this.key_S.Location = new System.Drawing.Point(78, 96);
            this.key_S.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.key_S.Name = "key_S";
            this.key_S.Size = new System.Drawing.Size(132, 20);
            this.key_S.TabIndex = 8;
            this.key_S.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2_S
            // 
            this.label2_S.AutoSize = true;
            this.label2_S.Location = new System.Drawing.Point(78, 76);
            this.label2_S.Name = "label2_S";
            this.label2_S.Size = new System.Drawing.Size(123, 13);
            this.label2_S.TabIndex = 7;
            this.label2_S.Text = "Введите ключ (ширину)";
            // 
            // checkBox_S
            // 
            this.checkBox_S.AutoSize = true;
            this.checkBox_S.Location = new System.Drawing.Point(78, 236);
            this.checkBox_S.Name = "checkBox_S";
            this.checkBox_S.Size = new System.Drawing.Size(102, 17);
            this.checkBox_S.TabIndex = 5;
            this.checkBox_S.Text = "Расшифровать";
            this.checkBox_S.UseVisualStyleBackColor = true;
            // 
            // label3_S
            // 
            this.label3_S.AutoSize = true;
            this.label3_S.Location = new System.Drawing.Point(78, 176);
            this.label3_S.Name = "label3_S";
            this.label3_S.Size = new System.Drawing.Size(59, 13);
            this.label3_S.TabIndex = 4;
            this.label3_S.Text = "Результат";
            // 
            // output_S
            // 
            this.output_S.Location = new System.Drawing.Point(78, 196);
            this.output_S.Name = "output_S";
            this.output_S.ReadOnly = true;
            this.output_S.Size = new System.Drawing.Size(132, 20);
            this.output_S.TabIndex = 3;
            // 
            // ButtonSkitala
            // 
            this.ButtonSkitala.Location = new System.Drawing.Point(108, 136);
            this.ButtonSkitala.Name = "ButtonSkitala";
            this.ButtonSkitala.Size = new System.Drawing.Size(75, 23);
            this.ButtonSkitala.TabIndex = 2;
            this.ButtonSkitala.Text = "Выполнить";
            this.ButtonSkitala.UseVisualStyleBackColor = true;
            this.ButtonSkitala.Click += new System.EventHandler(this.ButtonSkitala_Click);
            // 
            // label1_S
            // 
            this.label1_S.AutoSize = true;
            this.label1_S.Location = new System.Drawing.Point(78, 16);
            this.label1_S.Name = "label1_S";
            this.label1_S.Size = new System.Drawing.Size(80, 13);
            this.label1_S.TabIndex = 1;
            this.label1_S.Text = "Введите текст";
            // 
            // input_S
            // 
            this.input_S.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.input_S.Location = new System.Drawing.Point(78, 36);
            this.input_S.Name = "input_S";
            this.input_S.Size = new System.Drawing.Size(132, 20);
            this.input_S.TabIndex = 0;
            // 
            // TabPolybius
            // 
            this.TabPolybius.Controls.Add(this.checkBox_PS);
            this.TabPolybius.Controls.Add(this.ButtonPolybius);
            this.TabPolybius.Controls.Add(this.label2_PS);
            this.TabPolybius.Controls.Add(this.label4_PS);
            this.TabPolybius.Controls.Add(this.label1_PS);
            this.TabPolybius.Controls.Add(this.output_PS);
            this.TabPolybius.Controls.Add(this.key_PS);
            this.TabPolybius.Controls.Add(this.input_PS);
            this.TabPolybius.Location = new System.Drawing.Point(4, 22);
            this.TabPolybius.Name = "TabPolybius";
            this.TabPolybius.Padding = new System.Windows.Forms.Padding(3);
            this.TabPolybius.Size = new System.Drawing.Size(296, 272);
            this.TabPolybius.TabIndex = 1;
            this.TabPolybius.Text = "Полибианский квадрат";
            this.TabPolybius.UseVisualStyleBackColor = true;
            // 
            // checkBox_PS
            // 
            this.checkBox_PS.AutoSize = true;
            this.checkBox_PS.Location = new System.Drawing.Point(78, 236);
            this.checkBox_PS.Name = "checkBox_PS";
            this.checkBox_PS.Size = new System.Drawing.Size(102, 17);
            this.checkBox_PS.TabIndex = 4;
            this.checkBox_PS.Text = "Расшифровать";
            this.checkBox_PS.UseVisualStyleBackColor = true;
            // 
            // ButtonPolybius
            // 
            this.ButtonPolybius.Location = new System.Drawing.Point(108, 136);
            this.ButtonPolybius.Name = "ButtonPolybius";
            this.ButtonPolybius.Size = new System.Drawing.Size(75, 23);
            this.ButtonPolybius.TabIndex = 2;
            this.ButtonPolybius.Text = "Выполнить";
            this.ButtonPolybius.UseVisualStyleBackColor = true;
            this.ButtonPolybius.Click += new System.EventHandler(this.ButtonPolybius_Click);
            // 
            // label2_PS
            // 
            this.label2_PS.AutoSize = true;
            this.label2_PS.Location = new System.Drawing.Point(78, 76);
            this.label2_PS.Name = "label2_PS";
            this.label2_PS.Size = new System.Drawing.Size(77, 13);
            this.label2_PS.TabIndex = 6;
            this.label2_PS.Text = "Введите ключ";
            // 
            // label4_PS
            // 
            this.label4_PS.AutoSize = true;
            this.label4_PS.Location = new System.Drawing.Point(78, 176);
            this.label4_PS.Name = "label4_PS";
            this.label4_PS.Size = new System.Drawing.Size(59, 13);
            this.label4_PS.TabIndex = 5;
            this.label4_PS.Text = "Результат";
            // 
            // label1_PS
            // 
            this.label1_PS.AutoSize = true;
            this.label1_PS.Location = new System.Drawing.Point(78, 16);
            this.label1_PS.Name = "label1_PS";
            this.label1_PS.Size = new System.Drawing.Size(80, 13);
            this.label1_PS.TabIndex = 4;
            this.label1_PS.Text = "Введите текст";
            // 
            // output_PS
            // 
            this.output_PS.Location = new System.Drawing.Point(78, 196);
            this.output_PS.Name = "output_PS";
            this.output_PS.ReadOnly = true;
            this.output_PS.Size = new System.Drawing.Size(132, 20);
            this.output_PS.TabIndex = 3;
            // 
            // key_PS
            // 
            this.key_PS.Location = new System.Drawing.Point(78, 96);
            this.key_PS.Name = "key_PS";
            this.key_PS.Size = new System.Drawing.Size(132, 20);
            this.key_PS.TabIndex = 1;
            // 
            // input_PS
            // 
            this.input_PS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.input_PS.Location = new System.Drawing.Point(78, 36);
            this.input_PS.Name = "input_PS";
            this.input_PS.Size = new System.Drawing.Size(132, 20);
            this.input_PS.TabIndex = 0;
            // 
            // TabGronsfeld
            // 
            this.TabGronsfeld.Controls.Add(this.label3_GF);
            this.TabGronsfeld.Controls.Add(this.label2_GF);
            this.TabGronsfeld.Controls.Add(this.label1_GF);
            this.TabGronsfeld.Controls.Add(this.checkBox_GF);
            this.TabGronsfeld.Controls.Add(this.key_GF);
            this.TabGronsfeld.Controls.Add(this.input_GF);
            this.TabGronsfeld.Controls.Add(this.output_GF);
            this.TabGronsfeld.Controls.Add(this.ButtonGronsfeld);
            this.TabGronsfeld.Location = new System.Drawing.Point(4, 22);
            this.TabGronsfeld.Name = "TabGronsfeld";
            this.TabGronsfeld.Padding = new System.Windows.Forms.Padding(3);
            this.TabGronsfeld.Size = new System.Drawing.Size(296, 272);
            this.TabGronsfeld.TabIndex = 2;
            this.TabGronsfeld.Text = "Шифр Гронсфельда";
            this.TabGronsfeld.UseVisualStyleBackColor = true;
            // 
            // label3_GF
            // 
            this.label3_GF.AutoSize = true;
            this.label3_GF.Location = new System.Drawing.Point(78, 176);
            this.label3_GF.Name = "label3_GF";
            this.label3_GF.Size = new System.Drawing.Size(59, 13);
            this.label3_GF.TabIndex = 7;
            this.label3_GF.Text = "Результат";
            // 
            // label2_GF
            // 
            this.label2_GF.AutoSize = true;
            this.label2_GF.Location = new System.Drawing.Point(78, 76);
            this.label2_GF.Name = "label2_GF";
            this.label2_GF.Size = new System.Drawing.Size(77, 13);
            this.label2_GF.TabIndex = 6;
            this.label2_GF.Text = "Введите ключ";
            // 
            // label1_GF
            // 
            this.label1_GF.AutoSize = true;
            this.label1_GF.Location = new System.Drawing.Point(78, 16);
            this.label1_GF.Name = "label1_GF";
            this.label1_GF.Size = new System.Drawing.Size(80, 13);
            this.label1_GF.TabIndex = 5;
            this.label1_GF.Text = "Введите текст";
            // 
            // checkBox_GF
            // 
            this.checkBox_GF.AutoSize = true;
            this.checkBox_GF.Location = new System.Drawing.Point(78, 236);
            this.checkBox_GF.Name = "checkBox_GF";
            this.checkBox_GF.Size = new System.Drawing.Size(102, 17);
            this.checkBox_GF.TabIndex = 4;
            this.checkBox_GF.Text = "Расшифровать";
            this.checkBox_GF.UseVisualStyleBackColor = true;
            // 
            // key_GF
            // 
            this.key_GF.Location = new System.Drawing.Point(78, 96);
            this.key_GF.Name = "key_GF";
            this.key_GF.Size = new System.Drawing.Size(132, 20);
            this.key_GF.TabIndex = 1;
            // 
            // input_GF
            // 
            this.input_GF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.input_GF.Location = new System.Drawing.Point(78, 36);
            this.input_GF.Name = "input_GF";
            this.input_GF.Size = new System.Drawing.Size(132, 20);
            this.input_GF.TabIndex = 0;
            // 
            // output_GF
            // 
            this.output_GF.Location = new System.Drawing.Point(78, 196);
            this.output_GF.Name = "output_GF";
            this.output_GF.ReadOnly = true;
            this.output_GF.Size = new System.Drawing.Size(132, 20);
            this.output_GF.TabIndex = 3;
            // 
            // ButtonGronsfeld
            // 
            this.ButtonGronsfeld.Location = new System.Drawing.Point(108, 136);
            this.ButtonGronsfeld.Name = "ButtonGronsfeld";
            this.ButtonGronsfeld.Size = new System.Drawing.Size(75, 23);
            this.ButtonGronsfeld.TabIndex = 2;
            this.ButtonGronsfeld.Text = "Выполнить";
            this.ButtonGronsfeld.UseVisualStyleBackColor = true;
            this.ButtonGronsfeld.Click += new System.EventHandler(this.ButtonGronsfeld_Click);
            // 
            // CryptoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(328, 322);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CryptoApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoApp";
            this.tabControl1.ResumeLayout(false);
            this.TabSkitala.ResumeLayout(false);
            this.TabSkitala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.key_S)).EndInit();
            this.TabPolybius.ResumeLayout(false);
            this.TabPolybius.PerformLayout();
            this.TabGronsfeld.ResumeLayout(false);
            this.TabGronsfeld.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabSkitala;
        private System.Windows.Forms.TabPage TabPolybius;
        private System.Windows.Forms.TabPage TabGronsfeld;
        private System.Windows.Forms.TextBox key_GF;
        private System.Windows.Forms.TextBox output_GF;
        private System.Windows.Forms.TextBox input_GF;
        private System.Windows.Forms.Button ButtonGronsfeld;
        private System.Windows.Forms.CheckBox checkBox_GF;
        private System.Windows.Forms.Label label1_GF;
        private System.Windows.Forms.Label label3_GF;
        private System.Windows.Forms.Label label2_GF;
        private System.Windows.Forms.Button ButtonPolybius;
        private System.Windows.Forms.Label label2_PS;
        private System.Windows.Forms.Label label4_PS;
        private System.Windows.Forms.Label label1_PS;
        private System.Windows.Forms.TextBox output_PS;
        private System.Windows.Forms.TextBox key_PS;
        private System.Windows.Forms.TextBox input_PS;
        private System.Windows.Forms.CheckBox checkBox_PS;
        private System.Windows.Forms.TextBox input_S;
        private System.Windows.Forms.Label label1_S;
        private System.Windows.Forms.Button ButtonSkitala;
        private System.Windows.Forms.CheckBox checkBox_S;
        private System.Windows.Forms.Label label3_S;
        private System.Windows.Forms.TextBox output_S;
        private System.Windows.Forms.Label label2_S;
        private System.Windows.Forms.NumericUpDown key_S;
    }
}

