﻿using Programming.Model.Classes.Geometry;
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
    public partial class RectanglesCollisionControl : UserControl
    {
        private Rectangle _currentRectangle = new Rectangle(1.0, 1.0, "black", new Point2D(1.0, 1.0));
        private BindingList<Rectangle> _rectangles = new BindingList<Rectangle>();
        private BindingList<Panel> _rectanglePanels = new BindingList<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            InitializeRectangleListBox();
            RectangleListBox.SelectedIndex = -1;
            RectangleListBox.SelectedItem = null;
        }

        private void InitializeRectangleListBox()
        {
            RectangleListBox.DisplayMember = nameof(Rectangle.Info);
            RectangleListBox.DataSource = _rectangles;
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
                RectangleWidthTextBox.BackColor = AppColors.Defualt;
                if (_currentRectangle.Width == Double.Parse(RectangleWidthTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Width = Double.Parse(RectangleWidthTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleWidthTextBox.BackColor = AppColors.LightPink;
                }
            }
        }

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectangleHeightTextBox.BackColor = AppColors.Defualt;
                if (_currentRectangle.Height == Double.Parse(RectangleHeightTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Height = Double.Parse(RectangleHeightTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleHeightTextBox.BackColor = AppColors.LightPink;
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
            newRectangle.Color = AppColors.Green.ToString();
            _rectangles.Add(newRectangle);
            var rectanglePanel = new Panel();
            rectanglePanel.Location = new Point((int)(newRectangle.Center.X - (newRectangle.Width / 2)),
                                                (int)(newRectangle.Center.Y - (newRectangle.Height / 2)));
            rectanglePanel.Size = new Size { Width = (int)newRectangle.Width, Height = (int)newRectangle.Height };
            rectanglePanel.BackColor = AppColors.Green;
            _rectanglePanels.Add(rectanglePanel);
            FindCollisions(newRectangle);
            RectangleCanvasPanel.Controls.Add(rectanglePanel);
            RectangleListBox.SelectedItem = newRectangle;
        }

        private void RectangleDeletePictureBox_Click(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem != null && RectangleListBox.SelectedIndex != -1)
            {
                RectangleCanvasPanel.Controls.RemoveAt(RectangleListBox.SelectedIndex);
                if (_rectanglePanels[RectangleListBox.SelectedIndex].BackColor == AppColors.Green)
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
                RectangleXTextBox.BackColor = AppColors.Defualt;
                if (_currentRectangle.Center.X == Double.Parse(RectangleXTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Center.X = Double.Parse(RectangleXTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleXTextBox.BackColor = AppColors.LightPink;
                }
            }
        }

        private void RectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectangleYTextBox.BackColor = AppColors.Defualt;
                if (_currentRectangle.Center.Y == Double.Parse(RectangleYTextBox.Text))
                {
                    return;
                }
                _currentRectangle.Center.Y = Double.Parse(RectangleYTextBox.Text);
                UpdateRectangleInfo(RectangleListBox);
                UpdateRectanglePanel(_currentRectangle);
                FindAllCollisions();
            }
            catch
            {
                if (RectangleListBox.SelectedItem != null)
                {
                    RectangleYTextBox.BackColor = AppColors.LightPink;
                }
            }
        }

        private void UpdateRectangleInfo(ListBox listBox)
        {
            listBox.DisplayMember = null;
            listBox.DisplayMember = nameof(Rectangle.Info);
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
            _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor = AppColors.Green;

            for (int i = 0; i < _rectangles.Count; i++)
            {
                if (rectangle != _rectangles[i]
                    && CollisionManager.IsCollision(rectangle, _rectangles[i]))
                {
                    _rectanglePanels[_rectangles.IndexOf(rectangle)].BackColor = AppColors.Red;
                    if (_rectanglePanels[i].BackColor != AppColors.Red)
                    {
                        _rectanglePanels[i].BackColor = AppColors.Red;
                    }
                }
            }
        }

        private void FindAllCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.Green;
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i != j && CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.Red;
                        _rectanglePanels[j].BackColor = AppColors.Red;
                    }
                }
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
