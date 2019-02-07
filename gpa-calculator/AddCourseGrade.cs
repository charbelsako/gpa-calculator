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
    public partial class AddCourseGrade : Form
    {
        private Database Db;
        private DataTable grades;
        private DataTable courses;

        public AddCourseGrade()
        {
            Db = new Database();
            InitializeComponent();
        }

        private void AddCourseGrade_Load(object sender, EventArgs e)
        {
            // Get all courses
            // Get all grades
            // Insert data into combobox
            string query = "SELECT * FROM course";
            courses = Db.GetData(query);
            query = "SELECT * FROM grade";
            grades = Db.GetData(query);




            Grade1.DisplayMember = "grade";
            Grade1.ValueMember = "value";
            Grade1.DataSource = grades;

            ComboBox[] CourseCombos = new ComboBox[] { Course1, Course2, Course3 };
            ComboBox[] GradeCombos = new ComboBox[] { Grade1, Grade2, Grade3 };

            foreach (ComboBox box in CourseCombos)
            {
                box.DisplayMember = "title";
                box.ValueMember = "id";
                box.DataSource = courses;
            }

            foreach (ComboBox box in GradeCombos)
            {
                box.DisplayMember = "grade";
                box.ValueMember = "id";
                box.DataSource = grades;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Grade1_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView elt = (DataRowView)e.ListItem;
            string value = elt.Row[1].ToString() + " (" + elt.Row[2].ToString() + ")";
            e.Value = value;
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            ComboBox box = new ComboBox
            {
                DisplayMember = "title",
                ValueMember = "id",
                DataSource = courses,
                DropDownStyle = ComboBoxStyle.DropDownList
                /* TODO change the Location */
            };
            // Add it to the view
            Controls.Add(box);

            ComboBox gbox = new ComboBox();
            gbox.DropDownStyle = ComboBoxStyle.DropDownList;
            gbox.Location = new Point(box.Location.X + 100, box.Location.Y);

            foreach (DataRow grade in grades.Rows)
            {
                gbox.Items.Add(grade[1] + " ("+grade[2]+")");
            }
          
            //gbox.DisplayMember = "grade";
            //gbox.ValueMember = "id";
            //gbox.DataSource = grades;
            /* TODO change the Location */
            // Add it to the view
            Controls.Add(gbox);

        }


    }
}
