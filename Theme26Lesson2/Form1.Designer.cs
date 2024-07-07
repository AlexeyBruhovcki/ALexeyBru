namespace Theme26Lesson2
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
            textBoxFirstVar = new TextBox();
            textBoxSecondVar = new TextBox();
            label1 = new Label();
            labelResult = new Label();
            checkBoxAdd = new CheckBox();
            checkBoxSub = new CheckBox();
            buttonCalc = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBoxFirstVar
            // 
            textBoxFirstVar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFirstVar.Location = new Point(12, 12);
            textBoxFirstVar.Name = "textBoxFirstVar";
            textBoxFirstVar.Size = new Size(84, 43);
            textBoxFirstVar.TabIndex = 0;
            textBoxFirstVar.KeyPress += textBoxFirstVar_KeyPress;
            // 
            // textBoxSecondVar
            // 
            textBoxSecondVar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSecondVar.Location = new Point(102, 12);
            textBoxSecondVar.Name = "textBoxSecondVar";
            textBoxSecondVar.Size = new Size(84, 43);
            textBoxSecondVar.TabIndex = 1;
            textBoxSecondVar.KeyPress += textBoxSecondVar_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.BackColor = SystemColors.ButtonHighlight;
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(12, 58);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(263, 37);
            labelResult.TabIndex = 3;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Location = new Point(192, 12);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new Size(83, 19);
            checkBoxAdd.TabIndex = 4;
            checkBoxAdd.Text = "Сложение";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxSub
            // 
            checkBoxSub.AutoSize = true;
            checkBoxSub.Location = new Point(192, 36);
            checkBoxSub.Name = "checkBoxSub";
            checkBoxSub.Size = new Size(87, 19);
            checkBoxSub.TabIndex = 5;
            checkBoxSub.Text = "Вычитание";
            checkBoxSub.UseVisualStyleBackColor = true;
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalc.Location = new Point(12, 98);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(263, 48);
            buttonCalc.TabIndex = 6;
            buttonCalc.Text = "Посчитать";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(12, 152);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(263, 48);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 207);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalc);
            Controls.Add(checkBoxSub);
            Controls.Add(checkBoxAdd);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(textBoxSecondVar);
            Controls.Add(textBoxFirstVar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstVar;
        private TextBox textBoxSecondVar;
        private Label label1;
        private Label labelResult;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxSub;
        private Button buttonCalc;
        private Button buttonClear;
    }
}
