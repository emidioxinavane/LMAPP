using LMAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMAPP.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();


            var authors = new Author[]
           {
            new Author{AuthorID=25870,Name="Joao Craveirinha"},
            new Author{AuthorID=25860,Name="Noemia de Sousa"},
            new Author{AuthorID=25850,Name="Paulina Chiziane"},
            new Author{AuthorID=25820,Name="Mia Couto"},
            new Author{AuthorID=25810,Name="Fernando Pessoa"},
            new Author{AuthorID=25830,Name="Calane da Silva"},
            new Author{AuthorID=25800,Name="Luis Vaz de Camoes"},
            new Author{AuthorID=25840,Name="Rui Nogar"},
            new Author{AuthorID=25804,Name="Eca de Queiros"},
            new Author{AuthorID=25834,Name="Gottfried Wilhelm Leibniz"},
            new Author{AuthorID=25824,Name="Montesquieu"},
            new Author{AuthorID=25854,Name="Jean-Jacques Rousseau"},
            new Author{AuthorID=25826,Name="Thomas Hobes"},
            new Author{AuthorID=25837,Name="Voltaire"},
            new Author{AuthorID=25825,Name="John Locke"},
            new Author{AuthorID=25896,Name="Maquiavel"},
            new Author{AuthorID=25897,Name="Aristoteles"},
            new Author{AuthorID=25888,Name="Descartes"},
            new Author{AuthorID=25889,Name="René Descartes"},
            };
            foreach (Author a in authors)
            {
                context.Authors.Add(a);
            }
            context.SaveChanges();

            var books = new Book[]
          {
            new Book{BookID=258010,Title="Os Luisiadas"},
            new Book{BookID=258020,Title="Os Maias"},
            new Book{BookID=258031,Title="Sangue Negro"},
            new Book{BookID=258040,Title="35 Sonnets"},
            new Book{BookID=258050,Title="Antinous"},
            new Book{BookID=258062,Title="Mensagem "},
            new Book{BookID=258070,Title="Niketche: Uma História de Poligamia"},
            new Book{BookID=258080,Title="Balada de amor ao vento"},
            new Book{BookID=258090,Title="Terra sonâmbula"},
            new Book{BookID=258039,Title="Mulheres de cinza"},
            new Book{BookID=258093,Title="Um rio chamado tempo, uma casa chamada terra"},
            new Book{BookID=258044,Title="O fio das missangas"},
            new Book{BookID=258421,Title="Antes de nascer o mundo"},
            new Book{BookID=258032,Title="Estórias abensonhadas"},
            new Book{BookID=258341,Title="O Crime do Padre Amaro"},
            new Book{BookID=258051,Title="Do Contrato Social"},
            new Book{BookID=258565,Title="Cartas Persas"},
            new Book{BookID=258072,Title="Leviatã"},
            new Book{BookID=258082,Title="Do cidadão"},
            new Book{BookID=258092,Title="Cartas Persas"},
          };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();


            var authorBooks = new AuthorBook[]
              {
            new AuthorBook{AuthorID=25870,BookID=258062},
            new AuthorBook{AuthorID=25870,BookID=258090},
            new AuthorBook{AuthorID=25860,BookID=258090},
            new AuthorBook{AuthorID=25860,BookID=258093},
            new AuthorBook{AuthorID=25850,BookID=258093},
            new AuthorBook{AuthorID=25850,BookID=258090},
            new AuthorBook{AuthorID=25820,BookID=258092},
            new AuthorBook{AuthorID=25820,BookID=258070},
               };
            foreach (AuthorBook ab in authorBooks)
            {
                context.AuthorBooks.Add(ab);
            }
            context.SaveChanges();
        }
    }
}
