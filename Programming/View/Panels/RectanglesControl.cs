using Programming.Model.Classes.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="RectanglesControl"/>.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        private const int DefaultSize = 5;
        private Rectangle[] _rectangles = new Rectangle[DefaultSize];
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает объект типа <see cref="RectanglesControl"/>
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            for (int i = 0; i < DefaultSize; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
            }
            InitializeRectangleListBox();
            RectangleListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполняет RectangleListBox элементами коллекции _rectangles.
        /// </summary>
        private void InitializeRectangleListBox()
        {
            RectangleListBox.DisplayMember = nameof(Rectangle.Info);
            RectangleListBox.DataSource = _rectangles;
        }

        /// <summary>
        /// Заполняет RectangleHeightTextBox, RectangleWidthTextBox, RectangleColorTextBox, RectangleCenterXTextBox,
        /// RectangleCenterYTextBox, RectangleIdTextBox значениями выбранного в RectangleListBox элемента.
        /// </summary>
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == _rectangles[RectangleListBox.SelectedIndex])
            {
                return;
            }
            _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color.ToString();
            RectangleCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Записывает в _currentRectangle значение из RectangleHeightTextBox.
        /// </summary>
        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectangleHeightTextBox.BackColor = AppColors.White;
                _currentRectangle.Height = Double.Parse(RectangleHeightTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
            }
            catch
            {
                RectangleHeightTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Записывает в _currentRectangle значение из RectangleWidthTextBox.
        /// </summary>
        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectangleWidthTextBox.BackColor = AppColors.White;
                _currentRectangle.Width = Double.Parse(RectangleWidthTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
            }
            catch
            {
                RectangleWidthTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Записывает в _currentRectangle значение из RectangleColorTextBox.
        /// </summary>
        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectangleColorTextBox.Text;
        }

        /// <summary>
        /// Выбирает в RectangleListBox найденный элемент коллекции _rectangles с максимальным 
        /// значением <see cref="Rectangle.Width"/>.
        /// </summary>
        private void FindRectangleWithMaxWidth()
        {
            double maxWidth = _rectangles[0].Width;
            int i = 0;
            int maxWidthIndex = 0;
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

        /// <summary>
        /// Вызывает метод FindRectangleWithMaxWidth.
        /// </summary>
        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth();
        }

        /// <summary>
        /// Обновляет данные, отображаемые в обновляемом ListBox.
        /// </summary>
        /// <param name="listBox">Обновляемый ListBox.</param>
        private void UpdateRectangleInfo(ListBox listBox)
        {
            listBox.DisplayMember = null;
            listBox.DisplayMember = nameof(Rectangle.Info);
        }
    }
}
