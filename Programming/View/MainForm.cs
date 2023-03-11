namespace Programming
{
    using Rectangle = Model.Classes.Rectangle;
    using Movie = Model.Classes.Movie;
    public partial class MainForm : Form
    {
        private const int DefaultSize = 5;
        private const int SubstringIndexClass = 26;
        private Rectangle[] _rectangles = new Rectangle[DefaultSize];
        private Rectangle _currentRectangle;
        private Movie[] _movies=new Movie[DefaultSize];
        private Movie _currentMovie;
        public MainForm()
        {
            // TODO: Вынести инициализацию компонентов
            InitializeComponent();

            object[] enums = new object[] { typeof(Color), typeof(EducationalForm), typeof(Genre),     
                typeof(Manufactures), typeof(Season), typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;

            ParsingResult.Visible = false;

            var seasons = Enum.GetValues(typeof(Season));                                           
            foreach (var season in seasons)
            {
                SeasonComboBox.Items.Add(season);
            }
            SeasonComboBox.SelectedIndex = 0;

            Random random = new Random();
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < DefaultSize; i++)
            {
                double length = random.NextDouble() * 100;
                double width = random.NextDouble() * 100;
                string color = colors.GetValue(index: random.Next(0, colors.Length)).ToString();
                _rectangles[i] = new Rectangle(length, width, color);
            }
            int j = 0;
            // TODO: Заменить метод Substring в добавлении элементов в ListBox
            foreach (var rectangle in _rectangles)
            {
                j++;
                RectangleListBox.Items.Add(rectangle.ToString().Substring(SubstringIndexClass) + " " + j.ToString());
            }
            RectangleListBox.SelectedIndex = 0;

            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < DefaultSize; i++)
            {
                string name = (i + 1).ToString();
                int duration = random.Next(1, 301);
                int year = random.Next(1900, 2024);
                string genre = genres.GetValue(index: random.Next(0, genres.Length)).ToString();
                double rating = random.NextDouble() * 10;
                _movies[i] = new Movie(name, duration, year, genre, rating);
            }
            j = 0;
            foreach (var movie in _movies)
            {
                j++;
                MovieListBox.Items.Add(movie.ToString().Substring(SubstringIndexClass) + " " + j.ToString());
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
            if (ParsingValueTextBox.Text == null)                                                           
            {
                return;
            }
            ParsingResult.Visible = true;
            object ParsedValue;
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

                default:                                                                                   
                    MessageBox.Show("Выберете время года из выпадающего списка");
                    break;
            }
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MovieListBox.SelectedIndex];
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
                _currentRectangle.Length=Double.Parse(RectangleLengthTextBox.Text);
            }
            catch
            {
                RectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Double.Parse(RectangleWidthTextBox.Text);
            }
            catch
            {
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
                _currentMovie.Duration = Int32.Parse(MovieDurationTextBox.Text);
            }
            catch
            {
                MovieDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                MovieYearTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Year = Int32.Parse(MovieYearTextBox.Text);
            }
            catch
            {
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
                _currentMovie.Rating = Double.Parse(MovieRatingTextBox.Text);
            }
            catch
            {
                MovieRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void FindRectangleWithMaxWidth()
        {
            double maxWidth = _rectangles[0].Width;
            int i = 0;
            int maxWidthIndex=0;
            // Поиск прямоугольника с максимальной шириной
            foreach (var tempRectangle in _rectangles)
            {
                if (tempRectangle.Width > maxWidth)
                {
                    maxWidthIndex = i;
                    maxWidth = tempRectangle.Width;
                }
                i++;
            }
            RectangleListBox.SelectedIndex = maxWidthIndex;
        }
        private void FindMovieWithMaxRating()
        {
            double maxRating = _movies[0].Rating;
            int i = 0;
            int maxRatingIndex=0;
            // Поиск фильма с максимальным рейтингом
            foreach (var tempMovie in _movies)
            {
                if (tempMovie.Rating > maxRating)
                {
                    maxRatingIndex = i;
                    maxRating = tempMovie.Rating;
                }
                i++;
            }
            MovieListBox.SelectedIndex = maxRatingIndex;
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth();
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            FindMovieWithMaxRating();
        }
    }
}