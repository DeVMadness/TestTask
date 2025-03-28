using System;
using System.Windows.Forms;
using Manager.Services.Abstraction;
using Model.Models;

namespace TestTaskWinForm
{
    public partial class UserView : Form
    {
        private readonly IUserService _userService;
        private int _selectedUserId = -1;

        public UserView(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _userService.GetUsers();
            dataGridViewUsers.DataSource = new BindingSource { DataSource = users };
            _selectedUserId = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            if (!string.IsNullOrWhiteSpace(name))
            {
                if (_selectedUserId == -1)
                {
                    _userService.CreateUser(name);
                    MessageBox.Show("User created successfully!");
                }
                else
                {
                    _userService.UpdateUser(_selectedUserId, name);
                    MessageBox.Show("User updated successfully!");
                }
                LoadUsers();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Name cannot be empty.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedUserId != -1)
            {
                string name = textBoxName.Text;

                if (!string.IsNullOrWhiteSpace(name))
                {
                    _userService.UpdateUser(_selectedUserId, name);
                    MessageBox.Show("User updated successfully!");
                    LoadUsers();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Name cannot be empty.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserId != -1)
            {
                _userService.DeleteUser(_selectedUserId);
                MessageBox.Show("User deleted successfully!");
                LoadUsers();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewUsers.SelectedRows[0];
                _selectedUserId = (int)selectedRow.Cells["UserID"].Value;

                if (textBoxName != null && selectedRow.Cells["Name"].Value != null)
                {
                    textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                }
            }
        }

        private void ClearForm()
        {
            _selectedUserId = -1;
            textBoxName.Clear();
        }
    }
}
