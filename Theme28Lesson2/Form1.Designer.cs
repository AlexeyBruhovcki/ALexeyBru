namespace Theme28Lesson2
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
            textBoxLogonInput = new TextBox();
            buttonPassGen = new Button();
            label2 = new Label();
            label3 = new Label();
            listBoxLogin = new ListBox();
            listBoxPassword = new ListBox();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя:";
            // 
            // textBoxLogonInput
            // 
            textBoxLogonInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogonInput.Location = new Point(12, 37);
            textBoxLogonInput.Name = "textBoxLogonInput";
            textBoxLogonInput.Size = new Size(177, 33);
            textBoxLogonInput.TabIndex = 1;
            // 
            // buttonPassGen
            // 
            buttonPassGen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPassGen.Location = new Point(12, 76);
            buttonPassGen.Name = "buttonPassGen";
            buttonPassGen.Size = new Size(177, 58);
            buttonPassGen.TabIndex = 2;
            buttonPassGen.Text = "Сгенерировать пароль";
            buttonPassGen.UseVisualStyleBackColor = true;
            buttonPassGen.Click += buttonPassGen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(195, 9);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 3;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(401, 9);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "Пароль:";
            // 
            // listBoxLogin
            // 
            listBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxLogin.FormattingEnabled = true;
            listBoxLogin.ItemHeight = 21;
            listBoxLogin.Location = new Point(195, 37);
            listBoxLogin.Name = "listBoxLogin";
            listBoxLogin.Size = new Size(200, 214);
            listBoxLogin.TabIndex = 5;
            // 
            // listBoxPassword
            // 
            listBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxPassword.FormattingEnabled = true;
            listBoxPassword.ItemHeight = 21;
            listBoxPassword.Location = new Point(401, 37);
            listBoxPassword.Name = "listBoxPassword";
            listBoxPassword.Size = new Size(200, 214);
            listBoxPassword.TabIndex = 6;
            listBoxPassword.SelectedIndexChanged += listBoxPassword_SelectedIndexChanged;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDel.Location = new Point(12, 140);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(177, 30);
            buttonDel.TabIndex = 7;
            buttonDel.Text = "Удалить запись";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 259);
            Controls.Add(buttonDel);
            Controls.Add(listBoxPassword);
            Controls.Add(listBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonPassGen);
            Controls.Add(textBoxLogonInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLogonInput;
        private Button buttonPassGen;
        private Label label2;
        private Label label3;
        private ListBox listBoxLogin;
        private ListBox listBoxPassword;
        private Button buttonDel;
    }
}
