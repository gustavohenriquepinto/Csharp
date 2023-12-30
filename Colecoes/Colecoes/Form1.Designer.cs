namespace Colecoes
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
            lista = new ListBox();
            btnList = new Button();
            btnHashSet = new Button();
            btnDictionary = new Button();
            btnSortedList = new Button();
            btnSortedDictionary = new Button();
            btnSortedSet = new Button();
            btnQueue = new Button();
            btnStack = new Button();
            SuspendLayout();
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 25;
            lista.Location = new Point(12, 12);
            lista.Margin = new Padding(4, 5, 4, 5);
            lista.Name = "lista";
            lista.Size = new Size(558, 479);
            lista.TabIndex = 0;
            // 
            // btnList
            // 
            btnList.Location = new Point(578, 14);
            btnList.Margin = new Padding(4, 5, 4, 5);
            btnList.Name = "btnList";
            btnList.Size = new Size(184, 47);
            btnList.TabIndex = 1;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnHashSet
            // 
            btnHashSet.Location = new Point(578, 75);
            btnHashSet.Margin = new Padding(4, 5, 4, 5);
            btnHashSet.Name = "btnHashSet";
            btnHashSet.Size = new Size(184, 47);
            btnHashSet.TabIndex = 2;
            btnHashSet.Text = "HashSet";
            btnHashSet.UseVisualStyleBackColor = true;
            btnHashSet.Click += btnHashSet_Click;
            // 
            // btnDictionary
            // 
            btnDictionary.Location = new Point(578, 136);
            btnDictionary.Margin = new Padding(4, 5, 4, 5);
            btnDictionary.Name = "btnDictionary";
            btnDictionary.Size = new Size(184, 47);
            btnDictionary.TabIndex = 3;
            btnDictionary.Text = "Dictionary";
            btnDictionary.UseVisualStyleBackColor = true;
            btnDictionary.Click += btnDictionary_Click;
            // 
            // btnSortedList
            // 
            btnSortedList.Location = new Point(578, 197);
            btnSortedList.Margin = new Padding(4, 5, 4, 5);
            btnSortedList.Name = "btnSortedList";
            btnSortedList.Size = new Size(184, 47);
            btnSortedList.TabIndex = 4;
            btnSortedList.Text = "SortedList";
            btnSortedList.UseVisualStyleBackColor = true;
            btnSortedList.Click += btnSortedList_Click;
            // 
            // btnSortedDictionary
            // 
            btnSortedDictionary.Location = new Point(578, 258);
            btnSortedDictionary.Margin = new Padding(4, 5, 4, 5);
            btnSortedDictionary.Name = "btnSortedDictionary";
            btnSortedDictionary.Size = new Size(184, 47);
            btnSortedDictionary.TabIndex = 5;
            btnSortedDictionary.Text = "SortedDictionary";
            btnSortedDictionary.UseVisualStyleBackColor = true;
            btnSortedDictionary.Click += btnSortedDictionary_Click;
            // 
            // btnSortedSet
            // 
            btnSortedSet.Location = new Point(578, 319);
            btnSortedSet.Margin = new Padding(4, 5, 4, 5);
            btnSortedSet.Name = "btnSortedSet";
            btnSortedSet.Size = new Size(184, 47);
            btnSortedSet.TabIndex = 6;
            btnSortedSet.Text = "SortedSet";
            btnSortedSet.UseVisualStyleBackColor = true;
            btnSortedSet.Click += btnSortedSet_Click;
            // 
            // btnQueue
            // 
            btnQueue.Location = new Point(578, 380);
            btnQueue.Margin = new Padding(4, 5, 4, 5);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(184, 47);
            btnQueue.TabIndex = 7;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = true;
            btnQueue.Click += btnQueue_Click;
            // 
            // btnStack
            // 
            btnStack.Location = new Point(578, 441);
            btnStack.Margin = new Padding(4, 5, 4, 5);
            btnStack.Name = "btnStack";
            btnStack.Size = new Size(184, 47);
            btnStack.TabIndex = 8;
            btnStack.Text = "Stack";
            btnStack.UseVisualStyleBackColor = true;
            btnStack.Click += btnStack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 507);
            Controls.Add(btnStack);
            Controls.Add(btnQueue);
            Controls.Add(btnSortedSet);
            Controls.Add(btnSortedDictionary);
            Controls.Add(btnSortedList);
            Controls.Add(btnDictionary);
            Controls.Add(btnHashSet);
            Controls.Add(btnList);
            Controls.Add(lista);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listas Genéricas";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lista;
        private Button btnList;
        private Button btnHashSet;
        private Button btnDictionary;
        private Button btnSortedList;
        private Button btnSortedDictionary;
        private Button btnSortedSet;
        private Button btnQueue;
        private Button btnStack;
    }
}