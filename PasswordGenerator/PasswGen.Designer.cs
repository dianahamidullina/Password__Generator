namespace PasswordGenerator
{
    partial class PasswGen
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
            this.components = new System.ComponentModel.Container();
            this.GroupBoxGenerationParams = new System.Windows.Forms.GroupBox();
            this.LabelPasswordLengthValue = new System.Windows.Forms.Label();
            this.LabelPasswordLength = new System.Windows.Forms.Label();
            this.TrackBarPasswordLength = new System.Windows.Forms.TrackBar();
            this.CheckBoxUseUppercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseLowercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseDigits = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseSpecialSymbols = new System.Windows.Forms.CheckBox();
            this.ButtonGeneratePassword = new System.Windows.Forms.Button();
            this.ButtonClearPassword = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelGeneratedPassword = new System.Windows.Forms.Label();
            this.TimerShowLabelCopiedToClipboard = new System.Windows.Forms.Timer(this.components);
            this.ImageListDefault = new System.Windows.Forms.ImageList(this.components);
            this.ToolTipForControl = new System.Windows.Forms.ToolTip(this.components);
            this.savepasswword_button = new System.Windows.Forms.Button();
            this.TextBoxGeneratedPassword = new System.Windows.Forms.TextBox();
            this.GroupBoxGenerationParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxGenerationParams
            // 
            this.GroupBoxGenerationParams.BackColor = System.Drawing.Color.Lavender;
            this.GroupBoxGenerationParams.Controls.Add(this.LabelPasswordLengthValue);
            this.GroupBoxGenerationParams.Controls.Add(this.LabelPasswordLength);
            this.GroupBoxGenerationParams.Controls.Add(this.TrackBarPasswordLength);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseUppercaseLetters);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseLowercaseLetters);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseDigits);
            this.GroupBoxGenerationParams.Controls.Add(this.CheckBoxUseSpecialSymbols);
            this.GroupBoxGenerationParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxGenerationParams.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxGenerationParams.Name = "GroupBoxGenerationParams";
            this.GroupBoxGenerationParams.Size = new System.Drawing.Size(784, 274);
            this.GroupBoxGenerationParams.TabIndex = 0;
            this.GroupBoxGenerationParams.TabStop = false;
            this.GroupBoxGenerationParams.Text = "Параметры генерации пароля";
            // 
            // LabelPasswordLengthValue
            // 
            this.LabelPasswordLengthValue.AutoSize = true;
            this.LabelPasswordLengthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPasswordLengthValue.Location = new System.Drawing.Point(227, 194);
            this.LabelPasswordLengthValue.Name = "LabelPasswordLengthValue";
            this.LabelPasswordLengthValue.Size = new System.Drawing.Size(26, 18);
            this.LabelPasswordLengthValue.TabIndex = 6;
            this.LabelPasswordLengthValue.Text = "##";
            // 
            // LabelPasswordLength
            // 
            this.LabelPasswordLength.AutoSize = true;
            this.LabelPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPasswordLength.Location = new System.Drawing.Point(15, 192);
            this.LabelPasswordLength.Name = "LabelPasswordLength";
            this.LabelPasswordLength.Size = new System.Drawing.Size(199, 18);
            this.LabelPasswordLength.TabIndex = 5;
            this.LabelPasswordLength.Text = "Длина пароля (символов) :\r\n";
            // 
            // TrackBarPasswordLength
            // 
            this.TrackBarPasswordLength.BackColor = System.Drawing.Color.Lavender;
            this.TrackBarPasswordLength.Location = new System.Drawing.Point(321, 182);
            this.TrackBarPasswordLength.Maximum = 30;
            this.TrackBarPasswordLength.Minimum = 5;
            this.TrackBarPasswordLength.Name = "TrackBarPasswordLength";
            this.TrackBarPasswordLength.Size = new System.Drawing.Size(417, 56);
            this.TrackBarPasswordLength.TabIndex = 4;
            this.TrackBarPasswordLength.Value = 5;
            this.TrackBarPasswordLength.Scroll += new System.EventHandler(this.TrackBarPasswordLength_Scroll);
            // 
            // CheckBoxUseUppercaseLetters
            // 
            this.CheckBoxUseUppercaseLetters.AutoSize = true;
            this.CheckBoxUseUppercaseLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxUseUppercaseLetters.Location = new System.Drawing.Point(18, 113);
            this.CheckBoxUseUppercaseLetters.Name = "CheckBoxUseUppercaseLetters";
            this.CheckBoxUseUppercaseLetters.Size = new System.Drawing.Size(338, 22);
            this.CheckBoxUseUppercaseLetters.TabIndex = 3;
            this.CheckBoxUseUppercaseLetters.Text = " Использовать прописные латинские буквы";
            this.CheckBoxUseUppercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxUseUppercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxUseUppercaseLetters_CheckedChanged);
            // 
            // CheckBoxUseLowercaseLetters
            // 
            this.CheckBoxUseLowercaseLetters.AutoSize = true;
            this.CheckBoxUseLowercaseLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxUseLowercaseLetters.Location = new System.Drawing.Point(18, 87);
            this.CheckBoxUseLowercaseLetters.Name = "CheckBoxUseLowercaseLetters";
            this.CheckBoxUseLowercaseLetters.Size = new System.Drawing.Size(325, 22);
            this.CheckBoxUseLowercaseLetters.TabIndex = 2;
            this.CheckBoxUseLowercaseLetters.Text = "Использовать строчные латинские буквы";
            this.CheckBoxUseLowercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxUseLowercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxUseLowercaseLetters_CheckedChanged);
            // 
            // CheckBoxUseDigits
            // 
            this.CheckBoxUseDigits.AutoSize = true;
            this.CheckBoxUseDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxUseDigits.Location = new System.Drawing.Point(18, 61);
            this.CheckBoxUseDigits.Name = "CheckBoxUseDigits";
            this.CheckBoxUseDigits.Size = new System.Drawing.Size(183, 22);
            this.CheckBoxUseDigits.TabIndex = 1;
            this.CheckBoxUseDigits.Text = "Использовать цифры";
            this.CheckBoxUseDigits.UseVisualStyleBackColor = true;
            this.CheckBoxUseDigits.CheckedChanged += new System.EventHandler(this.CheckBoxUseDigits_CheckedChanged);
            // 
            // CheckBoxUseSpecialSymbols
            // 
            this.CheckBoxUseSpecialSymbols.AutoSize = true;
            this.CheckBoxUseSpecialSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxUseSpecialSymbols.Location = new System.Drawing.Point(18, 35);
            this.CheckBoxUseSpecialSymbols.Name = "CheckBoxUseSpecialSymbols";
            this.CheckBoxUseSpecialSymbols.Size = new System.Drawing.Size(295, 22);
            this.CheckBoxUseSpecialSymbols.TabIndex = 0;
            this.CheckBoxUseSpecialSymbols.Text = "Использовать специальные символы";
            this.CheckBoxUseSpecialSymbols.UseVisualStyleBackColor = true;
            this.CheckBoxUseSpecialSymbols.CheckedChanged += new System.EventHandler(this.CheckBoxUseSpecialSymbols_CheckedChanged);
            // 
            // ButtonGeneratePassword
            // 
            this.ButtonGeneratePassword.BackColor = System.Drawing.Color.Thistle;
            this.ButtonGeneratePassword.Location = new System.Drawing.Point(12, 278);
            this.ButtonGeneratePassword.Name = "ButtonGeneratePassword";
            this.ButtonGeneratePassword.Size = new System.Drawing.Size(204, 47);
            this.ButtonGeneratePassword.TabIndex = 1;
            this.ButtonGeneratePassword.Text = "Сгенерировать пароль";
            this.ToolTipForControl.SetToolTip(this.ButtonGeneratePassword, " Сгенерировать надёжный пароль с заданной длинной и используемыми символами");
            this.ButtonGeneratePassword.UseVisualStyleBackColor = false;
            this.ButtonGeneratePassword.Click += new System.EventHandler(this.ButtonGeneratePassword_Click);
            // 
            // ButtonClearPassword
            // 
            this.ButtonClearPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearPassword.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClearPassword.Image = global::PasswordGenerator.Properties.Resources.icons8_удалить_32;
            this.ButtonClearPassword.Location = new System.Drawing.Point(514, 338);
            this.ButtonClearPassword.Name = "ButtonClearPassword";
            this.ButtonClearPassword.Size = new System.Drawing.Size(49, 45);
            this.ButtonClearPassword.TabIndex = 2;
            this.ToolTipForControl.SetToolTip(this.ButtonClearPassword, "Очистить поле");
            this.ButtonClearPassword.UseVisualStyleBackColor = false;
            this.ButtonClearPassword.Click += new System.EventHandler(this.ButtonClearPassword_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.BackColor = System.Drawing.Color.Thistle;
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Location = new System.Drawing.Point(629, 338);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(143, 45);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Выход";
            this.ToolTipForControl.SetToolTip(this.ButtonExit, "Выйти из программы\r\n");
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelGeneratedPassword
            // 
            this.LabelGeneratedPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelGeneratedPassword.AutoSize = true;
            this.LabelGeneratedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGeneratedPassword.Location = new System.Drawing.Point(12, 350);
            this.LabelGeneratedPassword.Name = "LabelGeneratedPassword";
            this.LabelGeneratedPassword.Size = new System.Drawing.Size(236, 20);
            this.LabelGeneratedPassword.TabIndex = 4;
            this.LabelGeneratedPassword.Text = "Сгенерированный пароль :\r\n";
            // 
            // TimerShowLabelCopiedToClipboard
            // 
            this.TimerShowLabelCopiedToClipboard.Interval = 2000;
            // 
            // ImageListDefault
            // 
            this.ImageListDefault.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageListDefault.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageListDefault.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // savepasswword_button
            // 
            this.savepasswword_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savepasswword_button.BackColor = System.Drawing.Color.Thistle;
            this.savepasswword_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.savepasswword_button.Location = new System.Drawing.Point(230, 278);
            this.savepasswword_button.Name = "savepasswword_button";
            this.savepasswword_button.Size = new System.Drawing.Size(191, 47);
            this.savepasswword_button.TabIndex = 6;
            this.savepasswword_button.Text = "Сохранить пароль ";
            this.ToolTipForControl.SetToolTip(this.savepasswword_button, "Выйти из программы\r\n");
            this.savepasswword_button.UseVisualStyleBackColor = false;
            this.savepasswword_button.Click += new System.EventHandler(this.savepasswword_button_Click);
            // 
            // TextBoxGeneratedPassword
            // 
            this.TextBoxGeneratedPassword.AcceptsTab = true;
            this.TextBoxGeneratedPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.TextBoxGeneratedPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TextBoxGeneratedPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.TextBoxGeneratedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxGeneratedPassword.Location = new System.Drawing.Point(254, 338);
            this.TextBoxGeneratedPassword.Multiline = true;
            this.TextBoxGeneratedPassword.Name = "TextBoxGeneratedPassword";
            this.TextBoxGeneratedPassword.Size = new System.Drawing.Size(254, 46);
            this.TextBoxGeneratedPassword.TabIndex = 5;
            this.TextBoxGeneratedPassword.TextChanged += new System.EventHandler(this.TextBoxGeneratedPassword_TextChanged);
            // 
            // PasswGen
            // 
            this.AcceptButton = this.ButtonGeneratePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(784, 396);
            this.Controls.Add(this.savepasswword_button);
            this.Controls.Add(this.TextBoxGeneratedPassword);
            this.Controls.Add(this.LabelGeneratedPassword);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonClearPassword);
            this.Controls.Add(this.ButtonGeneratePassword);
            this.Controls.Add(this.GroupBoxGenerationParams);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswGen";
            this.Text = "My Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswGen_FormClosing);
            this.Load += new System.EventHandler(this.PasswGen_Load);
            this.GroupBoxGenerationParams.ResumeLayout(false);
            this.GroupBoxGenerationParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxGenerationParams;
        private System.Windows.Forms.Label LabelPasswordLengthValue;
        private System.Windows.Forms.Label LabelPasswordLength;
        private System.Windows.Forms.TrackBar TrackBarPasswordLength;
        private System.Windows.Forms.ToolTip ToolTipForControl;
        private System.Windows.Forms.Button ButtonClearPassword;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label LabelGeneratedPassword;
        private System.Windows.Forms.Timer TimerShowLabelCopiedToClipboard;
        private System.Windows.Forms.ImageList ImageListDefault;
        private System.Windows.Forms.TextBox TextBoxGeneratedPassword;
        public System.Windows.Forms.CheckBox CheckBoxUseUppercaseLetters;
        public System.Windows.Forms.CheckBox CheckBoxUseLowercaseLetters;
        public System.Windows.Forms.CheckBox CheckBoxUseDigits;
        public System.Windows.Forms.CheckBox CheckBoxUseSpecialSymbols;
        public System.Windows.Forms.Button ButtonGeneratePassword;
        private System.Windows.Forms.Button savepasswword_button;
    }
}

