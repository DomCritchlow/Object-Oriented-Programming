using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    



    class Student
    {

        public string fname;
        public string stuID;
        public bool resident;
        public int credit;
        public double tuition;


        public string Fname
        {
            get { return fname;}
            set { fname = value; }

        }

        public string StudID
        {
            get { return stuID; }
            set { stuID = value; }

        }


        public int Credit
        {
            get { return credit; }
            set { credit = value; }

        }


        public double Tuition
        {
            get { return tuition; }
            set { tuition = value; }

        }

        public bool Resident
        {
            get { return resident; }
            set { resident = value; }

        }
        

        public Student()
        {
            
        }












    }




}
