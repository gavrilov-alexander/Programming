using ProgrammingAppInformationSystem.Model.Classes;
using ProgrammingAppInformationSystem.Model.Enums;
using System.Collections.Immutable;
using System.ComponentModel;
using Newtonsoft.Json;

namespace ProgrammingAppInformationSystem.View
{
    /// <summary>
    /// ������ ������ �������� ���� ����������.
    /// </summary>
    public partial class MainForm : Form
    {
        public static Organization organization;
        /// <summary>
        /// ��������� ��������� ������ <see cref="Organization"/>.
        /// </summary>
        private static List<Organization> _organizations = new List<Organization>();

        /// <summary>
        /// �������, ��������� � OrganizationListBox.
        /// </summary>
        private static Organization _currentOrganization;

        /// <summary>
        /// �������� �����, ��������� ����� ����������� �������.
        /// </summary>
        private static string _fileName;

        /// <summary>
        /// ������� ������ ���� <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DeserializeData();
            InitializeOrganizationListBox();
            OrganizationListBox.SelectedIndex = -1;
            SelectedOrganizationClear();
        }
        
        /// <summary>
        /// ������� ����, ��� �������� ������, ������������� ����� ���������� � ���� ����������.
        /// </summary>
        private void DeserializeData()
        {
            string direcoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"OrganizationApp");
            DirectoryInfo directoryInfo = new DirectoryInfo(direcoryName);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            _fileName = Path.Combine(direcoryName, "input.json");
            FileInfo fileInfo = new FileInfo(_fileName);
            if (!fileInfo.Exists)
            {
                File.WriteAllText(_fileName, string.Empty);
            }
            else
            {
                JsonTextReader reader = new JsonTextReader(new StreamReader(_fileName));
                reader.SupportMultipleContent = true;
                while (reader.Read())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Organization organization = serializer.Deserialize<Organization>(reader);
                    _organizations.Add(organization);
                }
                reader.Close();
            }
        }

        /// <summary>
        /// ����������� ���������� �� ��������, ������������ � ���������.
        /// </summary>
        private void SerializeData()
        {
            File.WriteAllText(_fileName, string.Empty);
            foreach (Organization organization in _organizations)
            {
                File.AppendAllText(_fileName, JsonConvert.SerializeObject(organization));
            }
        }

        /// <summary>
        /// ��������� OrganizationListBox.
        /// </summary>
        private void InitializeOrganizationListBox()
        {
            OrganizationListBox.DisplayMember = nameof(Organization.Info);
            OrganizationListBox.DataSource = _organizations;
        }

        /// <summary>
        /// ��������� ������, ������������ � OrganizationListBox.
        /// </summary>
        private void UpdateOrganizationListBox()
        {
            OrganizationListBox.DataSource = null;
            OrganizationListBox.DataSource = _organizations;
            OrganizationListBox.DisplayMember = nameof(Organization.Info);
        }

        /// <summary>
        /// ������� ����, ������������ ���������� � ��������� � OrganizationListBox �������.
        /// </summary>
        private void SelectedOrganizationClear()
        {
            NameTextBox.Clear();
            AddressTextBox.Clear();
            CategoryTextBox.Clear();
            RatingTextBox.Clear();
        }

        /// <summary>
        /// ������� ����, ������������ ���������� � ��������� � OrganizationListBox �������.
        /// </summary>
        private void UpdateCurrentOrganization()
        {
            if (OrganizationListBox.SelectedItem == null)
            {
                return;
            }
            OrganizationListBox.DisplayMember = null;
            OrganizationListBox.DisplayMember = nameof(Organization.Info);
            NameTextBox.Text = _currentOrganization.Name;
            AddressTextBox.Text = _currentOrganization.Address;
            CategoryTextBox.Text = _currentOrganization.Category;
            RatingTextBox.Text = _currentOrganization.Rating.ToString();
        }

        /// <summary>
        /// ��������� NameTextBox, AddressTextBox, CategoryTextBox, RatingTextBox ���������� 
        /// ���������� � OrganizationListBox ��������.
        /// </summary>
        private void OrganizationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrganizationListBox.SelectedItem == null)
            {
                return;
            }
            if (_currentOrganization == OrganizationListBox.SelectedItem)
            {
                return;
            }
            _currentOrganization = _organizations[OrganizationListBox.SelectedIndex];
            NameTextBox.Text = _currentOrganization.Name;
            AddressTextBox.Text = _currentOrganization.Address;
            CategoryTextBox.Text = _currentOrganization.Category;
            RatingTextBox.Text = _currentOrganization.Rating.ToString();
        }

        /// <summary>
        /// ������� ����� ����� ��� ���������� ������ �������.
        /// </summary>
        private void AddOrganizationPictureBox_Click(object sender, EventArgs e)
        {
            AddAndEditForm addAndEditForm = new AddAndEditForm(new Organization());
            addAndEditForm.ShowDialog();
            if (addAndEditForm.DialogResult == DialogResult.OK)
            {
                _organizations.Add(addAndEditForm.currentOrganization);
                _organizations.Sort(Organization.Compare);
                UpdateOrganizationListBox();
                OrganizationListBox.SelectedItem = addAndEditForm.currentOrganization;
            }
            else
            {
                MessageBox.Show("������ �� ��� ��������");
            }
        }

        /// <summary>
        /// ������� ����� ����� ��� ��������� ���������� �������.
        /// </summary>
        private void EditOrganizationPictureBox_Click(object sender, EventArgs e)
        {
            if (OrganizationListBox.SelectedIndex == -1)
            {
                return;
            }
            if (_currentOrganization == null)
            {
                return;
            }
            AddAndEditForm addAndEditForm = new AddAndEditForm(new Organization(_currentOrganization));
            addAndEditForm.ShowDialog();
            if (addAndEditForm.DialogResult == DialogResult.OK)
            {
                _currentOrganization.Name = addAndEditForm.currentOrganization.Name;
                _currentOrganization.Address = addAndEditForm.currentOrganization.Address;
                _currentOrganization.Category = addAndEditForm.currentOrganization.Category;
                _currentOrganization.Rating = addAndEditForm.currentOrganization.Rating;
                _organizations.Sort(Organization.Compare);
                UpdateOrganizationListBox();
                OrganizationListBox.SelectedItem = _currentOrganization;
                UpdateCurrentOrganization();
            }
            else
            {
                MessageBox.Show("������ �� ��� ��������");
            }
        }

        /// <summary>
        /// ������� �� ��������� ��������� � OrganizationListBox ������.
        /// </summary>
        private void RemoveOrganizationPictureBox_Click(object sender, EventArgs e)
        {
            if (OrganizationListBox.SelectedItem == null)
            {
                return;
            }
            if (OrganizationListBox.SelectedIndex == -1)
            {
                return;
            }
            if (_organizations.Count == 0)
            {
                return;
            }
            _organizations.RemoveAt(OrganizationListBox.SelectedIndex);
            UpdateOrganizationListBox();
            OrganizationListBox.SelectedIndex = -1;
            _currentOrganization = null;
            SelectedOrganizationClear();
        }

        /// <summary>
        /// ������������ ��������� NameTextBox.
        /// </summary>
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ������������ ��������� AddressTextBox.
        /// </summary>
        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ������������ ��������� CategoryTextBox.
        /// </summary>
        private void CategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ������������ ��������� RatingTextBox.
        /// </summary>
        private void RatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ������ ������, ����������� ��� �������� �������� ���� ����������.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeData();
        }
    }
}