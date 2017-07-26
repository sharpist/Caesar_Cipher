namespace Caesar_Cipher
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.labelClick = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelClick
            // 
            this.labelClick.AutoSize = true;
            this.labelClick.BackColor = System.Drawing.Color.Transparent;
            this.labelClick.Location = new System.Drawing.Point(160, 22);
            this.labelClick.MaximumSize = new System.Drawing.Size(80, 80);
            this.labelClick.MinimumSize = new System.Drawing.Size(80, 80);
            this.labelClick.Name = "labelClick";
            this.labelClick.Size = new System.Drawing.Size(80, 80);
            this.labelClick.TabIndex = 0;
            this.labelClick.Click += new System.EventHandler(this.labelClick_Click);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(268, 14);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(104, 17);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "Введите ключ:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 95);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(145, 17);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Введите сообщение:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(303, 39);
            this.textBoxKey.MaximumSize = new System.Drawing.Size(30, 30);
            this.textBoxKey.MaxLength = 1;
            this.textBoxKey.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(30, 23);
            this.textBoxKey.TabIndex = 3;
            this.textBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(5, 115);
            this.textBox.MaximumSize = new System.Drawing.Size(375, 200);
            this.textBox.MinimumSize = new System.Drawing.Size(375, 200);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(375, 200);
            this.textBox.TabIndex = 4;
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.Checked = true;
            this.radioButtonEncrypt.Location = new System.Drawing.Point(15, 12);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(101, 21);
            this.radioButtonEncrypt.TabIndex = 5;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Шифровать";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.Location = new System.Drawing.Point(15, 39);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(125, 21);
            this.radioButtonDecrypt.TabIndex = 6;
            this.radioButtonDecrypt.Text = "Расшифровать";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.radioButtonDecrypt);
            this.Controls.Add(this.radioButtonEncrypt);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelClick);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 360);
            this.MinimumSize = new System.Drawing.Size(400, 360);
            this.Name = "Form";
            this.Text = "Caesar Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClick;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonDecrypt;
    }
}

