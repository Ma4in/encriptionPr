namespace encriptionPr
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.MainText = new System.Windows.Forms.RichTextBox();
            this.encriptedText = new System.Windows.Forms.RichTextBox();
            this.encriptType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encriptButton = new System.Windows.Forms.Button();
            this.decriptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.codeWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cLang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текст";
            // 
            // MainText
            // 
            this.MainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainText.Location = new System.Drawing.Point(12, 47);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(474, 106);
            this.MainText.TabIndex = 1;
            this.MainText.Text = "";
            this.MainText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainText_KeyPress);
            // 
            // encriptedText
            // 
            this.encriptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriptedText.Location = new System.Drawing.Point(12, 269);
            this.encriptedText.Name = "encriptedText";
            this.encriptedText.Size = new System.Drawing.Size(474, 106);
            this.encriptedText.TabIndex = 1;
            this.encriptedText.Text = "";
            this.encriptedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.encriptedText_KeyPress);
            // 
            // encriptType
            // 
            this.encriptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encriptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriptType.FormattingEnabled = true;
            this.encriptType.Items.AddRange(new object[] {
            "Подстановкой",
            "Перестановокой",
            "Подменой",
            "Гаммированием"});
            this.encriptType.Location = new System.Drawing.Point(312, 162);
            this.encriptType.Name = "encriptType";
            this.encriptType.Size = new System.Drawing.Size(183, 32);
            this.encriptType.TabIndex = 2;
            this.encriptType.SelectedIndexChanged += new System.EventHandler(this.encriptType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите метод шифрования";
            // 
            // encriptButton
            // 
            this.encriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriptButton.Location = new System.Drawing.Point(18, 204);
            this.encriptButton.Name = "encriptButton";
            this.encriptButton.Size = new System.Drawing.Size(129, 59);
            this.encriptButton.TabIndex = 3;
            this.encriptButton.Text = "Шифровать";
            this.encriptButton.UseVisualStyleBackColor = true;
            this.encriptButton.Click += new System.EventHandler(this.encriptButton_Click);
            // 
            // decriptButton
            // 
            this.decriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decriptButton.Location = new System.Drawing.Point(153, 204);
            this.decriptButton.Name = "decriptButton";
            this.decriptButton.Size = new System.Drawing.Size(129, 59);
            this.decriptButton.TabIndex = 3;
            this.decriptButton.Text = "Дешифровать";
            this.decriptButton.UseVisualStyleBackColor = true;
            this.decriptButton.Click += new System.EventHandler(this.decriptButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите кодовое слово";
            this.label3.Visible = false;
            // 
            // codeWord
            // 
            this.codeWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeWord.Location = new System.Drawing.Point(315, 225);
            this.codeWord.Name = "codeWord";
            this.codeWord.Size = new System.Drawing.Size(161, 26);
            this.codeWord.TabIndex = 5;
            this.codeWord.Visible = false;
            this.codeWord.TextChanged += new System.EventHandler(this.codeWord_TextChanged);
            this.codeWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeWord_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Лангугаге";
            // 
            // cLang
            // 
            this.cLang.Location = new System.Drawing.Point(401, 12);
            this.cLang.Name = "cLang";
            this.cLang.Size = new System.Drawing.Size(75, 23);
            this.cLang.TabIndex = 7;
            this.cLang.Text = "RUS";
            this.cLang.UseVisualStyleBackColor = true;
            this.cLang.Click += new System.EventHandler(this.cLang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 387);
            this.Controls.Add(this.cLang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codeWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decriptButton);
            this.Controls.Add(this.encriptButton);
            this.Controls.Add(this.encriptType);
            this.Controls.Add(this.encriptedText);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MainText;
        private System.Windows.Forms.RichTextBox encriptedText;
        private System.Windows.Forms.ComboBox encriptType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encriptButton;
        private System.Windows.Forms.Button decriptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cLang;
    }
}

