using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mid-term
{
    
         class Department
{
    public string DepartmentName { get; set; }
    Course[] courses;

    public int TotalCourses { get; set; }
    public Department()
    {
        course = New Course[200];

        Console.WriteLine("Empty Deparment Constructor.");
    }

    public Department(string departmentName)

    {
        courses = New Course[200];
        DepartmentName = departmentName;
        TotalCourses = 0
    }

    public void AddCourse(params Course[] courses)
    {
        (var course in courses)
        {

            if (TotalCourses350)
            {
                this.courses[TotalCourses++] = course;
            }

        }
    }


}
}