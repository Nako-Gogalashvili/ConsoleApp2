using System;
using System.Diagnostics;
using System.Linq;

class University
    {
        static void Main(string[] args)
        {
          List<Students> listofStudents = new List<Students>();
          listofStudents.Add(new Students("Keti", 21, "Mathematic", 'Bs'));
          listofStudents.Add(new Students("Natia", 23, "History", "Bs"));
          listofStudents.Add(new Students("Beqa", 25, "Biology", "Ms"));
          listofStudents.Add(new Students("Sandro", 22, "Geography", "Bs"));
          listofStudents.Add(new Students("Giorgi", 35, "History", "Ms"));
          listofStudents.Add(new Students("Salome", 28, "Mathemathic", "Ms"));

           var sortedstudent = from student in listofStudents
                                where student.Faculty == "History"
                                select student;

            foreach (Students elements in sortedstudent)
            Console.WriteLine(elements.ToString());

           var student = from student in listofStudents
                         where student.Age >= 28 && Degree == "Ms"
                         select student;

           var number = from number in listofStudents
                        where number => 22
                        orderby number descending
                        select number;

           foreach (Students elem in number)
            Console.WriteLine(elem.ToString());



    }



    }
}
