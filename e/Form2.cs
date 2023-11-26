using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace e
{
    public partial class Form2 : Form
    {
        public static class UserManager
        {
            public static List<User> Users { get; } = new List<User>();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of the login form
            Form1 loginForm = new Form1();

            // Hide the sign-up form
            this.Hide();

            // Show the login form
            loginForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the login form
            Form1 loginForm = new Form1();

            // Hide the sign-up form
            this.Hide();

            // Show the login form
            loginForm.Show();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
           
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email already exists
            if (UserExists(email))
            {
                MessageBox.Show("Email already exists. Please choose another email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserManager.Users.Add(new User { Email = email, Password = password });
           
            Console.WriteLine($"UserManager.Users count after signup: {UserManager.Users.Count}");

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool UserExists(string email)
        {
            return UserManager.Users.Exists(u => u.Email == email);
        }


        public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }



private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //email 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //password
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
