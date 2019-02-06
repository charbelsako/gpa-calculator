using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpa_calculator
{
    public partial class gpa : Form
    {
        private Database Db = new Database();
        public gpa()
        {
            InitializeComponent();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetGPA()
        {
            // Get the user's gpa
            string query = "";
            DataTable result = Db.GetData(query);
            // Calculate GPA.
            // Sum of the multiplication of each course by number of credit and value of grade

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If the user exists I don't need to add him.
            string Id = StudentId.Text;
          
            string query = "SELECT id FROM student WHERE id = +\'"+Id+"\'LIMIT 1";
            DataTable result = Db.GetData(query);
            int n = result.Rows.Count;
            if(n > 0)
            {
                GetGPA();
                return;
            }
            // User doesn't exist in the database add him to it.
            string Name = NameTextBox.Text;
            query = "INSERT INTO student(id, name) VALUES(\'"+Id+"\', \'"+Name+"\')";
            Db.Insert(query);
        }

        private void AddGrade_Click(object sender, EventArgs e)
        {
            AddCourseGrade n = new AddCourseGrade();
            Hide();
            n.Show();
        }
    }
}
