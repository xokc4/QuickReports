using QuickReports.Models;

namespace QuickReports
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            InitializeInputControls(); // Инициализация элементов управления на форме
        }

        private void InitializeInputControls()
        {
            // Создание элементов управления для круга
            radiusTextBox = new TextBox { PlaceholderText = "Радиус", Location = new Point(0, 0) };
            centerXTextBox = new TextBox { PlaceholderText = "Центр X", Location = new Point(0, 30) };
            centerYTextBox = new TextBox { PlaceholderText = "Центр Y", Location = new Point(0, 60) };

            // Создание элементов управления для прямоугольника
            widthTextBox = new TextBox { PlaceholderText = "Ширина", Location = new Point(0, 0) };
            heightTextBox = new TextBox { PlaceholderText = "Высота", Location = new Point(0, 30) };
            rectXTextBox = new TextBox { PlaceholderText = "X", Location = new Point(0, 60) };
            rectYTextBox = new TextBox { PlaceholderText = "Y", Location = new Point(0, 90) };

            // Создание элементов управления для треугольника
            sideLengthTextBox = new TextBox { PlaceholderText = "Длина стороны", Location = new Point(0, 0) };
            triangleXTextBox = new TextBox { PlaceholderText = "Центр X", Location = new Point(0, 30) };
            triangleYTextBox = new TextBox { PlaceholderText = "Центр Y", Location = new Point(0, 60) };
            angleTextBox = new TextBox { PlaceholderText = "Угол", Location = new Point(0, 90) };

            // Комбобоксы для выбора цветов заливки и окантовки
            fillColorComboBox = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 120) };
            fillColorComboBox.DataSource = Enum.GetValues(typeof(KnownColor));

            borderColorComboBox = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(0, 150) };
            borderColorComboBox.DataSource = Enum.GetValues(typeof(KnownColor));

            // Кнопка для добавления фигуры
            addButton = new Button
            {
                Text = "Добавить фигуру",
                Location = new Point(0, 180),
                Size = new Size(100, 30)
            };
            addButton.Click += AddButton_Click;

            // Добавление элементов управления на панель ввода
            inputPanel.Controls.Add(radiusTextBox);
            inputPanel.Controls.Add(centerXTextBox);
            inputPanel.Controls.Add(centerYTextBox);
            inputPanel.Controls.Add(widthTextBox);
            inputPanel.Controls.Add(heightTextBox);
            inputPanel.Controls.Add(rectXTextBox);
            inputPanel.Controls.Add(rectYTextBox);
            inputPanel.Controls.Add(sideLengthTextBox);
            inputPanel.Controls.Add(triangleXTextBox);
            inputPanel.Controls.Add(triangleYTextBox);
            inputPanel.Controls.Add(angleTextBox);
            inputPanel.Controls.Add(fillColorComboBox);
            inputPanel.Controls.Add(borderColorComboBox);
            inputPanel.Controls.Add(addButton);
        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {
            // Очистка панели ввода и добавление элементов для точки
            inputPanel.Controls.Clear();
            var pointXTextBox = new TextBox { PlaceholderText = "X", Location = new Point(0, 0) };
            var pointYTextBox = new TextBox { PlaceholderText = "Y", Location = new Point(0, 30) };
            inputPanel.Controls.Add(pointXTextBox);
            inputPanel.Controls.Add(pointYTextBox);

            // Добавление кнопки для создания точки
            var addPointButton = new Button
            {
                Text = "Добавить точку",
                Location = new Point(0, 60),
                Size = new Size(100, 30)
            };
            // Кнопка для удаления точки
            var removePointButton = new Button
            {
                Text = "Удалить точку",
                Location = new Point(0, 100),
                Size = new Size(200, 40)
            };
            removePointButton.Click += RemovePointButton_Click;
            inputPanel.Controls.Add(removePointButton);
            var checkPointButton = new Button
            {
                Text = "Проверить точку",
                Location = new Point(0, 150),
                Size = new Size(200, 40)
            };
            checkPointButton.Click += CheckPointButton_Click;
            inputPanel.Controls.Add(checkPointButton);
            addPointButton.Click += AddPoint_Click;
            inputPanel.Controls.Add(addPointButton);
        }
        private void RemovePointButton_Click(object sender, EventArgs e)
        {
            // Удаление последней добавленной точки
            bool RemovePoint = graphicPrimitiveControl.RemoveLastPoint();
            MessageBox.Show(RemovePoint ? "Точку удалили" : "Нет точки");
        }
        private void CheckPointButton_Click(object sender, EventArgs e)
        {

            bool pointExists = graphicPrimitiveControl.CheckPointInFigures();
            MessageBox.Show(pointExists ? "Точка находится внутри фигуры." : "Точка не найдена внутри фигур.");
        }
        // Метод вызывается при нажатии кнопки "Добавить точку"
        private void AddPoint_Click(object sender, EventArgs e)
        {
            // Получение координат X и Y из текстовых полей
            int x = int.Parse(inputPanel.Controls.OfType<TextBox>().First(tb => tb.PlaceholderText == "X").Text);
            int y = int.Parse(inputPanel.Controls.OfType<TextBox>().First(tb => tb.PlaceholderText == "Y").Text);

            // Создание точки и добавление ее в контроль graphicPrimitiveControl
            bool Addpoint = graphicPrimitiveControl.CreateNewPoint(x, y);
            MessageBox.Show(Addpoint ? "Добавили точку" : "Точка уже есть");
        }
        // Метод вызывается при нажатии кнопки для добавления треугольника
        private void TriangleButton_Click(object sender, EventArgs e)
        {
            // Очистка панели ввода и добавление элементов для треугольника
            inputPanel.Controls.Clear();
            inputPanel.Controls.Add(sideLengthTextBox);
            inputPanel.Controls.Add(triangleXTextBox);
            inputPanel.Controls.Add(triangleYTextBox);
            inputPanel.Controls.Add(angleTextBox);
            inputPanel.Controls.Add(fillColorComboBox);
            inputPanel.Controls.Add(borderColorComboBox);
            inputPanel.Controls.Add(addButton);
        }

        // Метод вызывается при нажатии кнопки для добавления прямоугольника
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            // Очистка панели ввода и добавление элементов для прямоугольника
            inputPanel.Controls.Clear();
            inputPanel.Controls.Add(widthTextBox);
            inputPanel.Controls.Add(heightTextBox);
            inputPanel.Controls.Add(rectXTextBox);
            inputPanel.Controls.Add(rectYTextBox);
            inputPanel.Controls.Add(fillColorComboBox);
            inputPanel.Controls.Add(borderColorComboBox);
            inputPanel.Controls.Add(addButton);
        }

        // Метод вызывается при нажатии кнопки для добавления круга
        private void CircleButton_Click(object sender, EventArgs e)
        {
            // Очистка панели ввода и добавление элементов для круга
            inputPanel.Controls.Clear();
            inputPanel.Controls.Add(radiusTextBox);
            inputPanel.Controls.Add(centerXTextBox);
            inputPanel.Controls.Add(centerYTextBox);
            inputPanel.Controls.Add(fillColorComboBox);
            inputPanel.Controls.Add(borderColorComboBox);
            inputPanel.Controls.Add(addButton);
        }

        // Метод вызывается при нажатии кнопки "Добавить фигуру"
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получение выбранных цветов заливки и окантовки из комбобоксов
            Color fillColor = Color.FromKnownColor((KnownColor)fillColorComboBox.SelectedItem);
            Color borderColor = Color.FromKnownColor((KnownColor)borderColorComboBox.SelectedItem);

            // Добавление фигуры в зависимости от активных элементов ввода
            if (radiusTextBox.Parent == inputPanel)
            {
                var radius = double.Parse(radiusTextBox.Text);
                var centerX = int.Parse(centerXTextBox.Text);
                var centerY = int.Parse(centerYTextBox.Text);
                var circle = new Acircle(radius, new Point(centerX, centerY), fillColor, borderColor);
                graphicPrimitiveControl.AddFigure(circle);
            }
            else if (widthTextBox.Parent == inputPanel)
            {
                var width = double.Parse(widthTextBox.Text);
                var height = double.Parse(heightTextBox.Text);
                var x = int.Parse(rectXTextBox.Text);
                var y = int.Parse(rectYTextBox.Text);
                var rectangle = new RectangleFigur(width, height, new Point(x, y), fillColor, borderColor);
                graphicPrimitiveControl.AddFigure(rectangle);
            }
            else if (sideLengthTextBox.Parent == inputPanel)
            {
                var sideLength = double.Parse(sideLengthTextBox.Text);
                var centerX = int.Parse(triangleXTextBox.Text);
                var centerY = int.Parse(triangleYTextBox.Text);
                var angle = double.Parse(angleTextBox.Text);
                var triangle = new Triangle(sideLength, new Point(centerX, centerY), angle, fillColor, borderColor);
                graphicPrimitiveControl.AddFigure(triangle);
            }
        }
    }

}
