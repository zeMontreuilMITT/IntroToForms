namespace IntroToForms
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
            OperandInputField = new TextBox();
            ProductOutput = new TextBox();
            OperandLabel = new Label();
            ProductLabel = new Label();
            MultiplyButton = new Button();
            SuspendLayout();
            // 
            // OperandInputField
            // 
            OperandInputField.AccessibleDescription = "Input for number number operand to be multiplied";
            OperandInputField.AccessibleName = "Operand Input Field";
            OperandInputField.Location = new Point(401, 169);
            OperandInputField.Name = "OperandInputField";
            OperandInputField.Size = new Size(100, 23);
            OperandInputField.TabIndex = 0;
            OperandInputField.TextChanged += OperandInputField_TextChanged;
            // 
            // ProductOutput
            // 
            ProductOutput.AccessibleDescription = "Product of Operand Input multiplied by two";
            ProductOutput.AccessibleName = "Product Output";
            ProductOutput.BackColor = SystemColors.Window;
            ProductOutput.Location = new Point(521, 169);
            ProductOutput.Name = "ProductOutput";
            ProductOutput.Size = new Size(100, 23);
            ProductOutput.TabIndex = 1;
            // 
            // OperandLabel
            // 
            OperandLabel.AccessibleName = "Operand Label";
            OperandLabel.AutoSize = true;
            OperandLabel.Location = new Point(401, 145);
            OperandLabel.Name = "OperandLabel";
            OperandLabel.Size = new Size(84, 15);
            OperandLabel.TabIndex = 2;
            OperandLabel.Text = "Operand Input";
            // 
            // ProductLabel
            // 
            ProductLabel.AccessibleName = "Product Label";
            ProductLabel.AutoSize = true;
            ProductLabel.Location = new Point(521, 145);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(49, 15);
            ProductLabel.TabIndex = 3;
            ProductLabel.Text = "Product";
            // 
            // MultiplyButton
            // 
            MultiplyButton.AccessibleDescription = "Multiplies operand by two";
            MultiplyButton.AccessibleName = "Multiply Button";
            MultiplyButton.Location = new Point(401, 210);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(75, 23);
            MultiplyButton.TabIndex = 4;
            MultiplyButton.Text = "* 2";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MultiplyButton);
            Controls.Add(ProductLabel);
            Controls.Add(OperandLabel);
            Controls.Add(ProductOutput);
            Controls.Add(OperandInputField);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OperandInputField;
        private TextBox ProductOutput;
        private Label OperandLabel;
        private Label ProductLabel;
        private Button MultiplyButton;
    }
}