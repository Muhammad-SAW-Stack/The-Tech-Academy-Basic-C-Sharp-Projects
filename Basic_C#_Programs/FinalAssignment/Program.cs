using FinalAssignment;
using System;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }

        private class SchoolContext : IDisposable
        {
            public object Students { get; internal set; }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            internal void SaveChanges()
            {
                throw new NotImplementedException();
            }
        }
    }
}



