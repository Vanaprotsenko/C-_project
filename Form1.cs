using CRMSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<User> users;
        private List<Role> roles;

        public Form1()
        {
            InitializeComponent();
            InitializeRoles();
            InitializeUsers();
        }

        private void InitializeRoles()
        {
            roles = new List<Role>();

            var guestRole = new Role("Guest");
            guestRole.AddPermission(new Permission("View", "Может просматривать данные."));

            var userRole = new Role("User");
            userRole.AddPermission(new Permission("View", "Может просматривать данные."));
            userRole.AddPermission(new Permission("EditProfile", "Может редактировать свой профиль."));

            var adminRole = new Role("Admin");
            adminRole.AddPermission(new Permission("View", "Может просматривать данные."));
            adminRole.AddPermission(new Permission("Edit", "Может редактировать данные."));
            adminRole.AddPermission(new Permission("ManageUsers", "Может управлять пользователями."));

            roles.Add(guestRole);
            roles.Add(userRole);
            roles.Add(adminRole);
        }

        private void InitializeUsers()
        {
            users = new List<User>
            {
                new User(1, "alice", "password1", "Alice", "Smith", roles.First(r => r.RoleName == "User")),
                new User(2, "bob", "password2", "Bob", "Johnson", roles.First(r => r.RoleName == "Admin")),
                new User(3, "charlie", "password3", "Charlie", "Brown", roles.First(r => r.RoleName == "Guest"))
            };
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, ввівши ім'я користувача та пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = AuthenticateUser(userName, password);
            if (user != null)
            {
                OpenUserScreen(user);
            }
            else
            {
                MessageBox.Show("Невірне ім'я користувача або пароль", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private User AuthenticateUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        private void OpenUserScreen(User user)
        {
            if (user.Role.HasPermission("View"))
            {
                MessageBox.Show($"Вітаємо, {user.FirstName} {user.LastName}! Ви можете переглядати дані.", "Авторизація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (user.Role.HasPermission("EditProfile"))
            {
               
            }

            if (user.Role.HasPermission("ManageUsers"))
            {
                
            }
        }
    }
}
