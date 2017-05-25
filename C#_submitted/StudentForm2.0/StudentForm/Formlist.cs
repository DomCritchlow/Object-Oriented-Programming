using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Formlist : Form
    {



        List<Student> stud = new List<Student>();

       

        public Formlist()
        {
            InitializeComponent();
            Student_Label.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {





        }







        private void Add_button_Click(object sender, EventArgs e)
        {
            The_Form studinfo = new The_Form();
            studinfo.Owner = this;
            studinfo.ShowDialog();

            stud.Add(new Student{ Fname = studinfo.Studname, Tuition =studinfo.Cost, StudID = studinfo.StudID , Credit = studinfo.Credits, Resident = studinfo.res});


            refreshList();
        }




        private void refreshList()
        {
            listBox_student.Items.Clear();
            foreach (Student student in stud)
            {
                if (student.fname != null)
                {
                    listBox_student.Items.Add(student.fname);

                    Student_Label.Text = "Student ID:" + student.StudID + "\nStudent Name:" + student.Fname + "\nResident:"
                       + student.Resident + "\nCredit Hours:" + student.Credit + "\nTotal Tuition:" + student.Tuition;
                }
                }
                
           
            
        }









        private void listBox_student_SelectedIndexChanged(object sender, EventArgs e)
        {

            Student_Label.Text = "Student ID:" + stud[listBox_student.SelectedIndex].StudID + "\nStudent Name:" + stud[listBox_student.SelectedIndex].Fname + "\nResident:"
                   + stud[listBox_student.SelectedIndex].Resident + "\nCredit Hours:" + stud[listBox_student.SelectedIndex].Credit + "\nTotal Tuition:" + stud[listBox_student.SelectedIndex].Tuition;
           
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

            stud.RemoveAt(listBox_student.SelectedIndex);
            refreshList();
            Student_Label.Text = "";

        }
    }
}
