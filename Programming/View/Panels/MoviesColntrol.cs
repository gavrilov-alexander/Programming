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
    public partial class MoviesColntrol : UserControl
    {
        private const int DefaultSize = 5;
        private Movie[] _movies = new Movie[DefaultSize];
        private Movie _currentMovie;
        private Random random = new Random();

        public MoviesColntrol()
        {
            InitializeComponent();
            RandomMoviesArray();
            InitializeMovieListBox();
            MovieListBox.SelectedIndex = 0;
        }

        private void InitializeMovieListBox()
        {
            MovieListBox.DisplayMember = nameof(Movie.Info);
            MovieListBox.DataSource = _movies;
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

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
            UpdateMovieInfo(MovieListBox);
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MovieDurationTextBox.BackColor = AppColors.Defualt;
                _currentMovie.Duration = Int32.Parse(MovieDurationTextBox.Text);
            }
            catch
            {
                MovieDurationTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MovieYearTextBox.BackColor = AppColors.Defualt;
                _currentMovie.Year = Int32.Parse(MovieYearTextBox.Text);
            }
            catch
            {
                MovieYearTextBox.BackColor = AppColors.LightPink;
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
                MovieRatingTextBox.BackColor = AppColors.Defualt;
                _currentMovie.Rating = Double.Parse(MovieRatingTextBox.Text);
                UpdateMovieInfo(MovieListBox);
            }
            catch
            {
                MovieRatingTextBox.BackColor = AppColors.LightPink;
            }
        }

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

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            FindMovieWithMaxRating();
        }

        private void UpdateMovieInfo(ListBox listBox)
        {
            listBox.DisplayMember = null;
            listBox.DisplayMember = nameof(Movie.Info);
        }
    }
}
