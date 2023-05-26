using ProgrammingAppInformationSystem.Model.Classes;
using ProgrammingAppInformationSystem.Model.Enums;
using System.Collections.Immutable;
using System.ComponentModel;
using Newtonsoft.Json;

namespace ProgrammingAppInformationSystem.View
{
    public partial class MainForm : Form
    {
        private static List<Organization> _organizations = new List<Organization>();
        private static Organization _currentOrganization;
        private static string _fileName = "input.json";
        //public const int DefualtSize = 5;

        public MainForm()
        {
            InitializeComponent();
            //RandomOrganizations();
            DeserializeData();
            InitializeOrganizationListBox();
            OrganizationListBox.SelectedIndex = -1;
        }
        /*private void RandomOrganizations()
        {
            var categories = Enum.GetValues(typeof(Category));
            Random random = new Random();
            for (int i = 0; i < DefualtSize; i++)
            {
                _organizations.Add(new Organization($"{i}", $"{i}", 
                                   categories.GetValue(random.Next(0, categories.Length)).ToString(), 
                                   random.Next(0, 4) + random.NextDouble()));
            }
        }*/
        private void DeserializeData()
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
        private void SerializeData()
        {
            File.WriteAllText(_fileName, string.Empty);
            foreach (Organization organization in _organizations)
            {
                File.AppendAllText(_fileName, JsonConvert.SerializeObject(organization));
            }
        }
        private void InitializeOrganizationListBox()
        {
            OrganizationListBox.DisplayMember = nameof(Organization.Info);
            OrganizationListBox.DataSource = _organizations;
        }
        private void UpdateOrganizationListBox()
        {
            OrganizationListBox.DataSource = null;
            OrganizationListBox.DisplayMember = nameof(Organization.Info);
            OrganizationListBox.DataSource = _organizations;
        }
        private void SelectedOrganizationClear()
        {
            NameTextBox.Clear();
            AddressTextBox.Clear();
            CategoryTextBox.Clear();
            RatingTextBox.Clear();
        }
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

        private void AddOrganizationPictureBox_Click(object sender, EventArgs e)
        {
            StaticData.currentOrganization = new Organization();
            StaticData.Flag = false;
            AddAndEditForm addAndEditForm = new AddAndEditForm();
            addAndEditForm.ShowDialog();
            if (StaticData.Flag)
            {
                _organizations.Add(StaticData.currentOrganization);
                _organizations.Sort(Organization.Compare);
                UpdateOrganizationListBox();
                OrganizationListBox.SelectedItem = StaticData.currentOrganization;
            }
            else
            {
                MessageBox.Show("Объект не был сохранен");
            }
        }

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
            StaticData.currentOrganization = new Organization(_currentOrganization);
            StaticData.Flag = false;
            AddAndEditForm addAndEditForm = new AddAndEditForm();
            addAndEditForm.ShowDialog();
            if (StaticData.Flag)
            {
                _currentOrganization.Name = StaticData.currentOrganization.Name;
                _currentOrganization.Address = StaticData.currentOrganization.Address;
                _currentOrganization.Category = StaticData.currentOrganization.Category;
                _currentOrganization.Rating = StaticData.currentOrganization.Rating;
                _organizations.Sort(Organization.Compare);
                UpdateOrganizationListBox();
                OrganizationListBox.SelectedItem = _currentOrganization;
                UpdateCurrentOrganization();
            }
            else
            {
                MessageBox.Show("Объект не был сохранен");
            }
        }

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

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeData();
        }
    }
}