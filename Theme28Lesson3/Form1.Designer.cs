namespace Theme28Lesson3
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Триммеры");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Газонокосилки");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Аэраторы");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Техника для сада", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Котлы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Насосы");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Фильтры");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Водоснабжение, фильтрация и отопление", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Сучкорезы");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Секаторы");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Бензоинструмент");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Интсрумент", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Подставки");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Дачный гарнитур");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Мебель", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Садовый инструмент и инвентарь", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Садовая техника", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode16});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Триммеры";
            treeNode2.Name = "Узел5";
            treeNode2.Text = "Газонокосилки";
            treeNode3.Name = "Узел6";
            treeNode3.Text = "Аэраторы";
            treeNode4.Name = "Узел1";
            treeNode4.Text = "Техника для сада";
            treeNode5.Name = "Узел7";
            treeNode5.Text = "Котлы";
            treeNode6.Name = "Узел8";
            treeNode6.Text = "Насосы";
            treeNode7.Name = "Узел9";
            treeNode7.Text = "Фильтры";
            treeNode8.Name = "Узел2";
            treeNode8.Text = "Водоснабжение, фильтрация и отопление";
            treeNode9.Name = "Узел12";
            treeNode9.Text = "Сучкорезы";
            treeNode10.Name = "Узел13";
            treeNode10.Text = "Секаторы";
            treeNode11.Name = "Узел14";
            treeNode11.Text = "Бензоинструмент";
            treeNode12.Name = "Узел10";
            treeNode12.Text = "Интсрумент";
            treeNode13.Name = "Узел15";
            treeNode13.Text = "Подставки";
            treeNode14.Name = "Узел16";
            treeNode14.Text = "Дачный гарнитур";
            treeNode15.Name = "Узел11";
            treeNode15.Text = "Мебель";
            treeNode16.Name = "Узел3";
            treeNode16.Text = "Садовый инструмент и инвентарь";
            treeNode17.Name = "Узел0";
            treeNode17.Text = "Садовая техника";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(261, 293);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 318);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

