using Programming.Model.Classes.Geometry;

namespace Programming.View
{
    using Rectangle = Model.Classes.Geometry.Rectangle;
    using Movie = Model.Classes.Movie;
    using Programming.Model.Enums;
    using Point2D = Point2D;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;
    using Programming.Model.Classes.Geometry;

    public partial class MainForm : Form
    {
        private const int DefaultSize = 5;
        private Rectangle[] _classesRectangles = new Rectangle[DefaultSize];
        private Rectangle _classesCurrentRectangle;
        private Movie[] _movies=new Movie[DefaultSize];
        private Movie _currentMovie;
        private Random random = new Random();
        private Rectangle _currentRectangle = new Rectangle(1.0, 1.0, "black", new Point2D(1.0, 1.0));
        private BindingList<Rectangle> _rectangles = new BindingList<Rectangle>();
        private BindingList<Panel> _rectanglePanels = new BindingList<Panel>();
        private System.Drawing.Color _colorRed = System.Drawing.Color.FromArgb(127, 255, 127, 127);
        private System.Drawing.Color _colorGreen = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        public MainForm()
        {
            InitializeComponent();

            InitializeEnumsListBox();
            InitializeSeasonComboBox();
            ParsingResult.Visible = false;

            for (int i = 0; i < DefaultSize; i++)
            {
                _classesRectangles[i] = RectangleFactory.Randomize();
            }
            RandomMoviesArray();
            InitializeClassesRectangleListBox();
            InitializeMovieListBox();
            ClassesRectangleListBox.SelectedIndex = 0;
            MovieListBox.SelectedIndex = 0;
            InitializeRectangleListBox();
            RectangleListBox.SelectedIndex = -1;
            RectangleListBox.SelectedItem = null;
        }

        private void InitializeEnumsListBox()
        {
            object[] enums = new object[] { typeof(Color), typeof(EducationalForm), typeof(Genre),
                typeof(Manufactures), typeof(Season), typeof(Weekday) };
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
        }

        private void InitializeSeasonComboBox()
        {
            var seasons = Enum.GetValues(typeof(Season));
            foreach (var season in seasons)
            {
                SeasonComboBox.Items.Add(season);
            }
            SeasonComboBox.SelectedIndex = 0;
        }

        private void InitializeClassesRectangleListBox()
        {
            ClassesRectangleListBox.DisplayMember = nameof(Rectangle.Info);
            ClassesRectangleListBox.DataSource = _classesRectangles;
        }

        private void InitializeMovieListBox()
        {
            MovieListBox.DisplayMember = nameof(Movie.Info);
            MovieListBox.DataSource = _movies;
        }
        private void InitializeRectangleListBox()
        {
            RectangleListBox.DisplayMember = nameof(Rectangle.Info);
            RectangleListBox.DataSource = _rectangles;
        }

        private void RandomMoviesArray()
        {
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
                ParsingResult.Text = $"Это день недели ({ParsedValue}  =  {(int)ParsedValue + 1})";
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

        private void ClassesRectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_classesCurrentRectangle == _classesRectangles[ClassesRectangleListBox.SelectedIndex])
            {
                return;
            }
            _classesCurrentRectangle = _classesRectangles[ClassesRectangleListBox.SelectedIndex];
            ClassesRectangleHeightTextBox.Text = _classesCurrentRectangle.Height.ToString();
            ClassesRectangleWidthTextBox.Text = _classesCurrentRectangle.Width.ToString();
            ClassesRectangleColorTextBox.Text = _classesCurrentRectangle.Color.ToString();
            ClassesRectangleCenterXTextBox.Text = _classesCurrentRectangle.Center.X.ToString();
            ClassesRectangleCenterYTextBox.Text = _classesCurrentRectangle.Center.Y.ToString();
            ClassesRectangleIdTextBox.Text = _classesCurrentRectangle.Id.ToString();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentMovie == _movies[MovieListBox.SelectedIndex])
            {
                return;
            }
            _currentMovie = _movies[MovieListBox.SelectedIndex];
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieDurationTextBox.Text = _currentMovie.Duration.ToString();
            MovieYearTextBox.Text = _currentMovie.Year.ToString();
            MovieGenreTextBox.Text= _currentMovie.Genre.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void ClassesRectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                ClassesRectangleHeightTextBox.BackColor = System.Drawing.Color.White;
                _classesCurrentRectangle.Height=Double.Parse(ClassesRectangleHeightTextBox.Text);
                UpdateRectangleInfo(ClassesRectangleListBox);
            }
            catch
            {
                ClassesRectangleHeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ClassesRectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Возвращение цвета TextBox к исходному
                ClassesRectangleWidthTextBox.BackColor = System.Drawing.Color.White;
                _classesCurrentRectangle.Width = Double.Parse(ClassesRectangleWidthTextBox.Text);
                UpdateRectangleInfo(ClassesRectangleListBox);
            }
            catch
            {
                ClassesRectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _classesCurrentRectangle.Color = ClassesRectangleColorTextBox.Text;
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
            UpdateMovieInfo(MovieListBox);
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
                UpdateMovieInfo(MovieListBox);
            }
            catch
            {
                MovieRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindRectangleWithMaxWidth()
        {
            double maxWidth = _classesRectangles[0].Width;
            int i = 0;
            int maxWidthIndex=0;
            // Поиск прямоугольника с максимальной шириной
            foreach (var tempRectangle in _classesRectangles)
            {
                if (tempRectangle.Width > maxWidth)
                {
                    maxWidthIndex = i;
                    maxWidth = tempRectangle.Width;
                }
                i++;
            }
            ClassesRectangleListBox.SelectedIndex = maxWidthIndex;
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

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1)
            {
                ClearRectangleInfo();
                return;
            }
            if (_currentRectangle == _rectangles[RectangleListBox.SelectedIndex])
            {
                return;
            }
            _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle.Width == Double.Parse(RectangleWidthTextBox.Text))
                {
                    return;
                }
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Double.Parse(RectangleWidthTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle.Height == Double.Parse(RectangleHeightTextBox.Text))
                {
                    return;
                }
                RectangleHeightTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Height = Double.Parse(RectangleHeightTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleHeightTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RectangleIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RectangleAddPictureBox_Click(object sender, EventArgs e)
        {
            var newRectangle = RectangleFactory.Randomize(RectangleCanvasPanel);
            newRectangle.Color = _colorGreen.ToString();
            _rectangles.Add(newRectangle);
            var rectanglePanel = new Panel();
            rectanglePanel.Location = new Point((int)(newRectangle.Center.X-(newRectangle.Width/2)), 
                                                (int)(newRectangle.Center.Y-(newRectangle.Height/2)));
            rectanglePanel.Size = new Size { Width = (int)newRectangle.Width, Height = (int)newRectangle.Height };
            rectanglePanel.BackColor = _colorGreen;
            _rectanglePanels.Add(rectanglePanel);
            FindCollisions(newRectangle);
            RectangleCanvasPanel.Controls.Add(rectanglePanel);
            if (_currentRectangle != null && RectangleIdTextBox.Text != "")
            {
                RectangleListBox.SelectedItem = _currentRectangle;
            }
            else
            {
                RectangleListBox.SelectedIndex = -1;
            }
        }

        private void RectangleDeletePictureBox_Click(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem != null && RectangleListBox.SelectedIndex != -1)
            {
                RectangleCanvasPanel.Controls.RemoveAt(RectangleListBox.SelectedIndex);
                if (_rectanglePanels[RectangleListBox.SelectedIndex].BackColor == _colorGreen)
                {
                    _rectanglePanels.RemoveAt(RectangleListBox.SelectedIndex);
                    _rectangles.RemoveAt(RectangleListBox.SelectedIndex);
                    RectangleListBox.SelectedIndex = -1;
                    _currentRectangle = null;
                }
                else
                {
                    _rectanglePanels.RemoveAt(RectangleListBox.SelectedIndex);
                    _rectangles.RemoveAt(RectangleListBox.SelectedIndex);
                    RectangleListBox.SelectedIndex = -1;
                    FindAllCollisions();
                    _currentRectangle = null;
                }
            }
        }

        private void RectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle.Center.X == Double.Parse(RectangleXTextBox.Text))
                {
                    return;
                }
                RectangleXTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Center.X = Double.Parse(RectangleXTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleXTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle.Center.Y == Double.Parse(RectangleYTextBox.Text))
                {
                    return;
                }
                RectangleYTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Center.Y = Double.Parse(RectangleYTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void UpdateRectangleInfo(ListBox listBox)
        {
            listBox.DisplayMember = null;
            listBox.DisplayMember = nameof(Rectangle.Info);
        }

        private void UpdateMovieInfo(ListBox listBox)
        {
            listBox.DisplayMember = null;
            listBox.DisplayMember= nameof(Movie.Info);
        }

        private void ClearRectangleInfo()
        {
            RectangleHeightTextBox.Clear();
            RectangleWidthTextBox.Clear();
            RectangleXTextBox.Clear();
            RectangleYTextBox.Clear();
            RectangleIdTextBox.Clear();
        }
        
        private void FindCollisions(Rectangle rectangle)
        {
            _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor = _colorGreen;
            
            for (int i = 0; i < _rectangles.Count; i++)
            {
                if (rectangle != _rectangles[i] 
                    && CollisionManager.IsCollision(rectangle, _rectangles[i]))
                {
                    _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor = _colorRed;
                    if (_rectanglePanels[i].BackColor != _colorRed)
                    {
                        _rectanglePanels[i].BackColor = _colorRed;
                    }
                }
            }
        }

        private void FindAllCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                _rectanglePanels[i].BackColor = _colorGreen;
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i != j && CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = _colorRed;
                        _rectanglePanels[j].BackColor = _colorRed;
                    }
                }
            }
            UpdateAllRectanglePanels();
        }

        private void UpdateAllRectanglePanels()
        {
            RectangleCanvasPanel.Controls.Clear();
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                RectangleCanvasPanel.Controls.Add(_rectanglePanels[i]);
            }
        }

        private void UpdateRectanglePanel(Rectangle rectangle)
        {
            int index = _rectangles.IndexOf(rectangle);
            _rectanglePanels[index].Location = new Point((int)(rectangle.Center.X - (rectangle.Width / 2)),
                                                             (int)(rectangle.Center.Y - (rectangle.Height / 2)));
            _rectanglePanels[index].Width = (int)rectangle.Width;
            _rectanglePanels[index].Height = (int)rectangle.Height;
        }
    }
}