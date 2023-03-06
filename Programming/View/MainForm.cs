namespace Programming
{
    public partial class MainForm : Form
    {
        const int n = 5;
        // Создание массива элементов класса Rectangle
        private Rectangle[] _rectangles = new Rectangle[n];
        private Rectangle _currentRectangle;
        // Создание массива элементов класса Movie
        private Movie[] _movies=new Movie[n];
        private Movie _currentMovie;
        public MainForm()
        {
            InitializeComponent();

            // Создание массива перечислений
            object[] enums = new object[] { typeof(Color), typeof(EducationalForm), typeof(Genre),     
                typeof(Manufactures), typeof(Season), typeof(Weekday) };
            // Добавление перечислений в EnumsListBox
            EnumsListBox.Items.AddRange(enums);
            // Задание начального выброного перечисления из списка перечислений
            EnumsListBox.SelectedIndex = 0;

            // Скрытие лэйбла для вывода результата из WeekdayParsing GroupBox 
            ParsingResult.Visible = false;

            // Добавление перечисления Season в ComboBox в SeasonHandle
            var seasons = Enum.GetValues(typeof(Season));                                           
            foreach (var season in seasons)
            {
                SeasonComboBox.Items.Add(season);
            }
            // Задание начального выброного элемента из списка в ComboBox
            SeasonComboBox.SelectedIndex = 0;

            Random random = new Random();
            // Создание массива с еперчислением цветов
            var colors = Enum.GetValues(typeof(Color));
            // Инициализация массива прямоугольников
            for (int i = 0; i < n; i++)
            {
                _rectangles[i] = new Rectangle(random.NextDouble()*100, random.NextDouble()*100, colors.GetValue(index:random.Next(0,colors.Length)).ToString());
            }
            int j = 0;
            // Добавление массива прямоугольников в ListBox
            foreach (var temp_rectangle in _rectangles)
            {
                j++;
                RectangleListBox.Items.Add(temp_rectangle + " " + j.ToString());
            }
            RectangleListBox.SelectedIndex = 0;

            // Создание массива с перечислением жанров
            var genres = Enum.GetValues(typeof(Genre));
            // Инициализация массива фильмов
            for (int i = 0; i < n; i++)
            {
                _movies[i] = new Movie((i+1).ToString(), random.Next(1,301), random.Next(1900,2024), genres.GetValue(index: random.Next(0, genres.Length)).ToString(),random.NextDouble()*10);
            }
            j = 0;
            // Добавление массива фильмов в ListBox
            foreach (var temp_movie in _movies)
            {
                j++;
                MovieListBox.Items.Add(temp_movie + " " + j.ToString());
            }
            MovieListBox.SelectedIndex = 0;
        }

        // Изменение отображаемого перечисления в ValuesListBox
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)                  
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
            // Очистка отображения индекса выбранного элемента из перечисления
            ValueTextBox.Clear();                                                                   
        }

        // Отображение индекса выбранного элемента из списка ValuesListBox
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)                 
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            int selectedValue = (int)ValuesListBox.SelectedItem;
            ValueTextBox.Text = selectedValue.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            // Проверка введенной строки
            if (ParsingValueTextBox.Text == null)                                                           
            {
                return;
            }
            ParsingResult.Visible = true;
            object ParsedValue;
            // Попытка преобразования введенной строки в тип Enum
            if (Enum.TryParse(typeof(Weekday), ParsingValueTextBox.Text, out ParsedValue))                  
            {
                ParsingResult.Text = $"Это день недели ({ParsedValue}  =  {(int)ParsedValue+1})";
            }
            else
            {
                ParsingResult.Text = "Нет такого дня недели";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            // Очистка изменнений при запуске инструкций изменения выбранного сезона
            this.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;                                       
            switch (SeasonComboBox.SelectedIndex)
            {
                // Зима
                case 0:                                                                                    
                    
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                // Весна
                case 1:                                                                                    
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                // Лето
                case 2:                                                                                    

                    MessageBox.Show("Ура! Солнце!");
                    break;
                // Осень
                case 3:                                                                                    
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                // Инструкции на случай, если введен ни один из сезонов
                default:                                                                                   
                    MessageBox.Show("Выберете время года из выпадающего списка");
                    break;
            }
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
            // Добавление в TextBox параметров выбранного прямоугольника
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MovieListBox.SelectedIndex];
            // Добавление в TextBox параметров выбранного фильма
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieDurationTextBox.Text = _currentMovie.Duration.ToString();
            MovieYearTextBox.Text = _currentMovie.Year.ToString();
            MovieGenreTextBox.Text= _currentMovie.Genre.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                RectangleLengthTextBox.BackColor = System.Drawing.Color.White;
                //Преобразование введенного значения в параметр прямоугольника
                _currentRectangle.Length=Double.Parse(RectangleLengthTextBox.Text);
            }
            catch
            {
                // Изменение цвета TextBox в случае ошибки преобразования
                RectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
                //Преобразование введенного значения в параметр прямоугольника
                _currentRectangle.Width = Double.Parse(RectangleWidthTextBox.Text);
            }
            catch
            {
                // Изменение цвета TextBox в случае ошибки преобразования
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectangleColorTextBox.Text;
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                MovieDurationTextBox.BackColor = System.Drawing.Color.White;
                //Преобразование введенного значения в параметр фильма
                _currentMovie.Duration = Int32.Parse(MovieDurationTextBox.Text);
            }
            catch
            {
                // Изменение цвета TextBox в случае ошибки преобразования
                MovieDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                MovieYearTextBox.BackColor = System.Drawing.Color.White;
                //Преобразование введенного значения в параметр фильма
                _currentMovie.Year = Int32.Parse(MovieYearTextBox.Text);
            }
            catch
            {
                // Изменение цвета TextBox в случае ошибки преобразования
                MovieYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = MovieGenreTextBox.Text;
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                MovieRatingTextBox.BackColor = System.Drawing.Color.White;
                //Преобразование введенного значения в параметр фильма
                _currentMovie.Rating = Double.Parse(MovieRatingTextBox.Text);
            }
            catch
            {
                // Изменение цвета TextBox в случае ошибки преобразования
                MovieRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void FindRictangleWithMaxWidth()
        {
            double maxwidth = _rectangles[0].Width;
            int i = 0;
            int maxi=0;
            // Поиск прямоугольника с максимальной шириной
            foreach (var tempRectangle in _rectangles)
            {
                if (tempRectangle.Width > maxwidth)
                {
                    maxi = i;
                    maxwidth = tempRectangle.Width;
                }
                i++;
            }
            // Отображение в ListBox найденного прямоугольника
            RectangleListBox.SelectedIndex = maxi;
        }
        private void FindMovieWithMaxRating()
        {
            double maxrating = _movies[0].Rating;
            int i = 0;
            int maxi=0;
            // Поиск фильма с максимальным рейтингом
            foreach (var tempMovie in _movies)
            {
                if (tempMovie.Rating > maxrating)
                {
                    maxi = i;
                    maxrating = tempMovie.Rating;
                }
                i++;
            }
            // Отображение в ListBox найденного фильма
            MovieListBox.SelectedIndex = maxi;
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            FindRictangleWithMaxWidth();
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            FindMovieWithMaxRating();
        }
    }
}