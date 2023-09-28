namespace IntroToForms
{
    partial class TodoListForm
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
            TitleLabel = new Label();
            TodoListBox = new CheckedListBox();
            ItemInputTextBox = new TextBox();
            ItemAddButton = new Button();
            WarningLabel = new Label();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AccessibleName = "Title Label";
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(154, 43);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(534, 106);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "My To-Do List";
            // 
            // TodoListBox
            // 
            TodoListBox.AccessibleDescription = "Main container of to-do list items";
            TodoListBox.AccessibleName = "To-do List";
            TodoListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TodoListBox.FormattingEnabled = true;
            TodoListBox.Location = new Point(154, 184);
            TodoListBox.Name = "TodoListBox";
            TodoListBox.Size = new Size(1187, 424);
            TodoListBox.TabIndex = 1;
            TodoListBox.ItemCheck += TodoListBox_ItemCheck;
            // 
            // ItemInputTextBox
            // 
            ItemInputTextBox.AccessibleDescription = "Field for inputting new to-do items";
            ItemInputTextBox.AccessibleName = "Item Input Text Box";
            ItemInputTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemInputTextBox.Location = new Point(154, 726);
            ItemInputTextBox.Name = "ItemInputTextBox";
            ItemInputTextBox.Size = new Size(856, 71);
            ItemInputTextBox.TabIndex = 2;
            ItemInputTextBox.TextChanged += ItemInputTextBox_TextChanged;
            ItemInputTextBox.KeyDown += ItemInputTextBox_KeyDown;
            // 
            // ItemAddButton
            // 
            ItemAddButton.AccessibleDescription = "Add item in entry field to to-do list";
            ItemAddButton.AccessibleName = "Item Add Button";
            ItemAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ItemAddButton.Location = new Point(1061, 726);
            ItemAddButton.Name = "ItemAddButton";
            ItemAddButton.Size = new Size(280, 69);
            ItemAddButton.TabIndex = 3;
            ItemAddButton.Text = "Add";
            ItemAddButton.UseVisualStyleBackColor = true;
            ItemAddButton.Click += ItemAddButton_Click;
            // 
            // WarningLabel
            // 
            WarningLabel.AccessibleName = "Warning Label";
            WarningLabel.AutoSize = true;
            WarningLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WarningLabel.ForeColor = Color.Red;
            WarningLabel.Location = new Point(154, 857);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(0, 65);
            WarningLabel.TabIndex = 4;
            // 
            // TodoListForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2286, 1440);
            Controls.Add(WarningLabel);
            Controls.Add(ItemAddButton);
            Controls.Add(ItemInputTextBox);
            Controls.Add(TodoListBox);
            Controls.Add(TitleLabel);
            Margin = new Padding(9, 10, 9, 10);
            Name = "TodoListForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private CheckedListBox TodoListBox;
        private TextBox ItemInputTextBox;
        private Button ItemAddButton;
        private Label WarningLabel;
    }
}