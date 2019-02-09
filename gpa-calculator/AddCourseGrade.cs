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
        private const int DeltaX = 154;
        private const int DeltaY = 50;
        private Database Db;
        private DataTable grades;
        private DataTable courses;
        private int PrevX;
        private int PrevY;
        private int NumCourses = 3;
        public string StudentId;

        public AddCourseGrade()
        {
            Db = new Database();
            InitializeComponent();
        }

        private void AddCourseGrade_Load(object sender, EventArgs e)
        {
            PrevX = Course3.Location.X;
            PrevY = Course3.Location.Y;

            // Get all courses
            // Get all grades
            // Insert data into combobox
            string query = "SELECT * FROM course";
            courses = Db.GetData(query);
            query = "SELECT * FROM grade";
            grades = Db.GetData(query);

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
                box.ValueMember = "value";
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
            NumCourses++;
            ComboBox box = new ComboBox
            {
                DisplayMember = "title",
                ValueMember = "id",
                DataSource = courses,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(PrevX, PrevY + DeltaY),
                Name = "Course" + NumCourses,
                /* TODO change the Location */
            };

            // Add it to the view
            Controls.Add(box);

            // Change PrevX and PrevY
            PrevX = box.Location.X;
            PrevY = box.Location.Y;

            ComboBox gbox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(box.Location.X + DeltaX, box.Location.Y),
                Name = "Grade" + NumCourses,
            };



            gbox.DisplayMember = "grade";
            gbox.ValueMember = "value";
            gbox.DataSource = grades;
            gbox.Format += Grade1_Format;
            gbox.FormattingEnabled = true;

            Controls.Add(gbox);

            if (NumCourses >= 5)
            {
                AddCourse.Enabled = false;
            }
        }


        private Decimal CalculateGPA()
        {
            // For now I will assume that credit number is always equal to 3.
            const int cn = 3;
            Decimal sum = 0;

            for (int i = 1; i <= NumCourses; i++)
            {
                ComboBox co = (ComboBox)Controls["Course" + i];
                ComboBox gr = (ComboBox)Controls["Grade" + i];

                object c = co.SelectedValue; // CSC201
                object g = gr.SelectedValue; // 3.5

                sum += cn * Convert.ToInt32(g.ToString());
            }
            sum = sum / (cn * NumCourses);

            return sum;
        }

        private void SaveCourses()
        {
            string query = "";
            Db.Insert(query);
        }

        private void CalcGPA_Click(object sender, EventArgs e)
        {
            decimal gpa = CalculateGPA();
            label3.Text = gpa.ToString();
        }


    }
}
