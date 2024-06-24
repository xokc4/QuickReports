using QuickReports.Controllers;

namespace QuickReports
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Existing controls declarations
        private GraphicPrimitiveControl graphicPrimitiveControl;
        private Panel inputPanel;
        private TextBox radiusTextBox, centerXTextBox, centerYTextBox;
        private TextBox widthTextBox, heightTextBox, rectXTextBox, rectYTextBox;
        private TextBox sideLengthTextBox, triangleXTextBox, triangleYTextBox, angleTextBox;
        private Button triangleButton, rectangleButton, circleButton, addButton, addPointButton;

        // New controls declarations
        private ComboBox fillColorComboBox; // Комбобокс для выбора цвета заливки
        private ComboBox borderColorComboBox; // Комбобокс для выбора цвета окантовки

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            graphicPrimitiveControl = new GraphicPrimitiveControl();
            triangleButton = new Button();
            rectangleButton = new Button();
            circleButton = new Button();
            addPointButton = new Button();
            inputPanel = new Panel();
            fillColorComboBox = new ComboBox();
            borderColorComboBox = new ComboBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // graphicPrimitiveControl
            // 
            graphicPrimitiveControl.Location = new Point(0, 246);
            graphicPrimitiveControl.Margin = new Padding(4, 5, 4, 5);
            graphicPrimitiveControl.Name = "graphicPrimitiveControl";
            graphicPrimitiveControl.Size = new Size(1250, 691);
            graphicPrimitiveControl.TabIndex = 0;
            // 
            // triangleButton
            // 
            triangleButton.Location = new Point(12, 14);
            triangleButton.Margin = new Padding(4, 5, 4, 5);
            triangleButton.Name = "triangleButton";
            triangleButton.Size = new Size(125, 47);
            triangleButton.TabIndex = 1;
            triangleButton.Text = "Треугольник";
            triangleButton.UseVisualStyleBackColor = true;
            triangleButton.Click += TriangleButton_Click;
            // 
            // rectangleButton
            // 
            rectangleButton.Location = new Point(12, 71);
            rectangleButton.Margin = new Padding(4, 5, 4, 5);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(125, 47);
            rectangleButton.TabIndex = 2;
            rectangleButton.Text = "Прямоугольник";
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += RectangleButton_Click;
            // 
            // circleButton
            // 
            circleButton.Location = new Point(12, 141);
            circleButton.Margin = new Padding(4, 5, 4, 5);
            circleButton.Name = "circleButton";
            circleButton.Size = new Size(125, 47);
            circleButton.TabIndex = 3;
            circleButton.Text = "Круг";
            circleButton.UseVisualStyleBackColor = true;
            circleButton.Click += CircleButton_Click;
            // 
            // addPointButton
            // 
            addPointButton.Location = new Point(12, 198);
            addPointButton.Margin = new Padding(4, 5, 4, 5);
            addPointButton.Name = "addPointButton";
            addPointButton.Size = new Size(125, 38);
            addPointButton.TabIndex = 5;
            addPointButton.Text = "точка";
            addPointButton.UseVisualStyleBackColor = true;
            addPointButton.Click += AddPointButton_Click;
            // 
            // inputPanel
            // 
            inputPanel.Location = new Point(145, 16);
            inputPanel.Margin = new Padding(4, 5, 4, 5);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(380, 312);
            inputPanel.TabIndex = 4;
            // 
            // fillColorComboBox
            // 
            fillColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fillColorComboBox.FormattingEnabled = true;
            fillColorComboBox.Location = new Point(0, 120);
            fillColorComboBox.Name = "fillColorComboBox";
            fillColorComboBox.Size = new Size(121, 33);
            fillColorComboBox.TabIndex = 5;
            // 
            // borderColorComboBox
            // 
            borderColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            borderColorComboBox.FormattingEnabled = true;
            borderColorComboBox.Location = new Point(0, 150);
            borderColorComboBox.Name = "borderColorComboBox";
            borderColorComboBox.Size = new Size(121, 33);
            borderColorComboBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Location = new Point(0, 180);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 30);
            addButton.TabIndex = 7;
            addButton.Text = "Добавить фигуру";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 938);
            Controls.Add(graphicPrimitiveControl);
            Controls.Add(triangleButton);
            Controls.Add(rectangleButton);
            Controls.Add(circleButton);
            Controls.Add(addPointButton);
            Controls.Add(inputPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
    }

}
