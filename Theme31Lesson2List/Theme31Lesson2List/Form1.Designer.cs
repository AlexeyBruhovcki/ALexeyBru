namespace Theme31Lesson2List
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
            listBoxTasks = new ListBox();
            label1 = new Label();
            textBoxDescription = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxSearch = new TextBox();
            label3 = new Label();
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            listBoxDate = new ListBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(12, 78);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(179, 289);
            listBoxTasks.TabIndex = 0;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Список задач";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(263, 78);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(167, 289);
            textBoxDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 60);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Описание";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(436, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 34);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(355, 23);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Поиск";
            label3.Click += label3_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(436, 125);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(436, 154);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(436, 96);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(120, 23);
            textBoxName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 78);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 10;
            label4.Text = "Имя задачи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 16);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 11;
            label5.Text = "Дата задачи";
            // 
            // listBoxDate
            // 
            listBoxDate.FormattingEnabled = true;
            listBoxDate.ItemHeight = 15;
            listBoxDate.Location = new Point(197, 78);
            listBoxDate.Name = "listBoxDate";
            listBoxDate.Size = new Size(60, 289);
            listBoxDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 60);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 13;
            label6.Text = "Дата";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 379);
            Controls.Add(label6);
            Controls.Add(listBoxDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(textBoxSearch);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(listBoxTasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTasks;
        private Label label1;
        private TextBox textBoxDescription;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxSearch;
        private Label label3;
        private Button buttonAdd;
        private Button buttonDelete;
        private TextBox textBoxName;
        private Label label4;
        private Label label5;
        private ListBox listBoxDate;
        private Label label6;
    }
}
