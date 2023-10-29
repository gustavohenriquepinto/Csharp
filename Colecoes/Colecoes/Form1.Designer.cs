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
            SuspendLayout();
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 30;
            lista.Location = new Point(14, 15);
            lista.Margin = new Padding(5, 6, 5, 6);
            lista.Name = "lista";
            lista.Size = new Size(600, 484);
            lista.TabIndex = 0;
            // 
            // btnList
            // 
            btnList.Location = new Point(624, 15);
            btnList.Margin = new Padding(5, 6, 5, 6);
            btnList.Name = "btnList";
            btnList.Size = new Size(174, 78);
            btnList.TabIndex = 1;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnHashSet
            // 
            btnHashSet.Location = new Point(624, 105);
            btnHashSet.Margin = new Padding(5, 6, 5, 6);
            btnHashSet.Name = "btnHashSet";
            btnHashSet.Size = new Size(174, 78);
            btnHashSet.TabIndex = 2;
            btnHashSet.Text = "HashSet";
            btnHashSet.UseVisualStyleBackColor = true;
            btnHashSet.Click += btnHashSet_Click;
            // 
            // btnDictionary
            // 
            btnDictionary.Location = new Point(624, 195);
            btnDictionary.Margin = new Padding(5, 6, 5, 6);
            btnDictionary.Name = "btnDictionary";
            btnDictionary.Size = new Size(174, 78);
            btnDictionary.TabIndex = 3;
            btnDictionary.Text = "Dictionary";
            btnDictionary.UseVisualStyleBackColor = true;
            btnDictionary.Click += btnDictionary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 533);
            Controls.Add(btnDictionary);
            Controls.Add(btnHashSet);
            Controls.Add(btnList);
            Controls.Add(lista);
            Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
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
    }
}