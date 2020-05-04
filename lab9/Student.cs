using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => Name + LastName;
        public DateTime EnlistedTime { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }

    public class StudentsView
    {
        public StudentsList List { get; set; }

        public StudentsView()
        {
            List = new StudentsList()
            {

                students = new ObservableCollection<Student>()
                {

                    new Student
                    {
                        ID = 1,
                        Name = "Jan",
                        LastName = "Kowalski",
                        EnlistedTime = new DateTime(2000, 1, 1)
                    },

                    new Student
                    {
                        ID = 2,
                        Name = "Andrzej",
                        LastName = "Nowak",
                        EnlistedTime = new DateTime(2005, 1, 1)
                    },

                    new Student
                    {
                        ID = 3,
                        Name = "Marek",
                        LastName = "Kwiatkowski",
                        EnlistedTime = new DateTime(2010, 1, 1)
                    }
                }
            };

        }
    }

    public class StudentsList
    {
        public ObservableCollection<Student> students { get; set; } = new ObservableCollection<Student>();

    }
}

