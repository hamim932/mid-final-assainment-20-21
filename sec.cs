using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid-term
 

{
    class Section


{
    public string SectionName { get; set; }
    public Faculty teacher;
    public Course Subject;


    public Section()
    {
        Console.WriteLine("Empty Section Constructor.");
    }



    public Section(string Course Subject, sectionName, Faculty teacher)
    {

                SectionName = sectionName;
                this.courese = Subject
                this.teacher = teacher;

    }
}
}