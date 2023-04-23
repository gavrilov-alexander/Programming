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
    public partial class RectanglesControl : UserControl
    {
        private const int DefaultSize = 5;
        private Rectangle[] _rectangles = new Rectangle[DefaultSize];
        private Rectangle _currentRectangle;

        public RectanglesControl()
        {
            InitializeComponent();
            for (int i = 0; i < DefaultSize; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
            }
            InitializeClassesRectangleListBox();
            RectangleListBox.SelectedIndex = 0;
        }

        private void InitializeClassesRectangleListBox()
        {
            RectangleListBox.DisplayMember = nameof(Rectangle.Info);
            RectangleListBox.DataSource = _rectangles;
        }

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

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectangleHeightTextBox.BackColor = AppColors.Defualt;
                _currentRectangle.Height = Double.Parse(RectangleHeightTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
            }
            catch
            {
                RectangleHeightTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectangleWidthTextBox.BackColor = AppColors.Defualt;
                _currentRectangle.Width = Double.Parse(RectangleWidthTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
            }
            catch
            {
                RectangleWidthTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectangleColorTextBox.Text;
        }

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

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth();
        }

        private void UpdateRectangleInfo(ListBox listBox)
        {
            listBox.DisplayMember = null;
            listBox.DisplayMember = nameof(Rectangle.Info);
        }
    }
}
