using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="MoviesColntrol"/>.
    /// </summary>
    public partial class MoviesColntrol : UserControl
    {
        private const int DefaultSize = 5;
        private Movie[] _movies = new Movie[DefaultSize];
        private Movie _currentMovie;
        private Random random = new Random();

        /// <summary>
        /// Создает объект типа <see cref="MoviesColntrol"/>
        /// </summary>
        public MoviesColntrol()
        {
            InitializeComponent();
            RandomMoviesArray();
            InitializeMovieListBox();
            MovieListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполняет MovieListBox элементами коллекции _movies.
        /// </summary>
        private void InitializeMovieListBox()
        {
            MovieListBox.DisplayMember = nameof(Movie.Info);
            MovieListBox.DataSource = _movies;
        }

        /// <summary>
        /// Заполняет коллекцию _movies случайно сгенерированными экземплярами класса <see cref="Movie"/>.
        /// </summary>
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

        /// <summary>
        /// Заполняет MovieNameTextBox, MovieDurationTextBox, MovieYearTextBox, MovieGenreTextBox, MovieRatingTextBox 
        /// значениями выбранного в MovieListBox элемента.
        /// </summary>
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
            MovieGenreTextBox.Text = _currentMovie.Genre.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        /// <summary>
        /// Записывает в _currentMovie значение из MovieNameTextBox.
        /// </summary>
        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
            UpdateMovieInfo(MovieListBox);
        }

        /// <summary>
        /// Записывает в _currentMovie значение из MovieDurationTextBox.
        /// </summary>
        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MovieDurationTextBox.BackColor = AppColors.White;
                _currentMovie.Duration = Int32.Parse(MovieDurationTextBox.Text);
            }
            catch
            {
                MovieDurationTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Записывает в _currentMovie значение из MovieYearTextBox.
        /// </summary>
        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MovieYearTextBox.BackColor = AppColors.White;
                _currentMovie.Year = Int32.Parse(MovieYearTextBox.Text);
            }
            catch
            {
                MovieYearTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Записывает в _currentMovie значение из MovieGenreTextBox.
        /// </summary>
        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = MovieGenreTextBox.Text;
        }

        /// <summary>
        /// Записывает в _currentMovie значение из MovieRatingTextBox.
        /// </summary>
        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MovieRatingTextBox.BackColor = AppColors.White;
                _currentMovie.Rating = Double.Parse(MovieRatingTextBox.Text);
                UpdateMovieInfo(MovieListBox);
            }
            catch
            {
                MovieRatingTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Выбирает в MovieListBox найденный элемент коллекции _movies с максимальным рейтингом.
        /// </summary>
        private void FindMovieWithMaxRating()
        {
            double maxRating = _movies[0].Rating;
            int i = 0;
            int maxRatingIndex = 0;
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

        /// <summary>
        /// Вызывает метод FindMovieWithMaxRating.
        /// </summary>
        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            FindMovieWithMaxRating();
        }

        /// <summary>
        /// Обновляет данные, отображаемые в обновляемом ListBox.
        /// </summary>
        /// <param name="listBox">Обновляемый ListBox.</param>
        private void UpdateMovieInfo(ListBox listBox)
        {
            listBox.DisplayMember = null;
            listBox.DisplayMember = nameof(Movie.Info);
        }
    }
}
