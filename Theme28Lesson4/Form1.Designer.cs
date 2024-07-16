namespace Theme28Lesson4
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
            listBox1 = new ListBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBoxPath = new TextBox();
            label2 = new Label();
            buttonSave = new Button();
            buttonBowse = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(307, 229);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Список элементов";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(12, 289);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(307, 23);
            textBoxPath.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 265);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите путь к файлу:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(93, 318);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "В список";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonBowse
            // 
            buttonBowse.Location = new Point(12, 318);
            buttonBowse.Name = "buttonBowse";
            buttonBowse.Size = new Size(75, 23);
            buttonBowse.TabIndex = 5;
            buttonBowse.Text = "Обзор";
            buttonBowse.UseVisualStyleBackColor = true;
            buttonBowse.Click += buttonBowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 352);
            Controls.Add(buttonBowse);
            Controls.Add(buttonSave);
            Controls.Add(label2);
            Controls.Add(textBoxPath);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBoxPath;
        private Label label2;
        private Button buttonSave;
        private Button buttonBowse;
    }
}
