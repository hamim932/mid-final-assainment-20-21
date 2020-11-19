using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid-term
{
    


class Program

{
    static void Main(string[] args)
    {
        Department d1 = new Department("SE");
        Faculty A1 = new Faculty("H.M Sharier", "Q308");
        Faculty A2 = new Faculty("Golam Mostofa""Q402");

        Course G1 = new Course("C++", "1112", 4);
        Course G2 = new Course("C#", "9992", 5);
        Course G3 = new Course("C", "2223", 5);


        Section B1 = new Section("A", A1, G1);
        Section B2 = new Section("A", A1, G2);
        Section B3 = new Section("B", A2, G1);
        Section B4 = new Section("B", A2, G2);
        Section B5 = new Section("A", A2, G3);
        Section B6 = new Section("A", A2, G3);

        d1.AddCourse(G1, G2, G3);

        c1.AddSection(A1, A3);
        c2.AddSection(A2, A4);
        c3.AddSection(A5);

        G1.ShowInfo();
        Console.WriteLine()
            G2.ShowInfo();
        Console.WriteLine();
        G3.ShowInfo();

       
        A1.AddFacultySection(s1);
        A1.AddFacultySection(s2);
        A2.AddFacultySection(s3);
        A2.AddFacultySection(s4);
        A2.AddFacultySection(s5);
        A2.AddFacultySection(s6);

       
        
        Console.WriteLine();
        A1.FacultyInfo();
        Console.WriteLine();
        A2.FacultyInfo();


    }
}