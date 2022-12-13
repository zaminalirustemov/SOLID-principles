namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Kamil";
            student.Surname = "Ibrahimov";
            student.Age = 22;

            Teacher teacher = new();
            teacher.Age = 37;
            teacher.Name = "Namiq";
            teacher.Surname = "Abdullayev";
            teacher.Experience = 11;
            Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");
            Console.WriteLine($"{teacher.Name} {teacher.Surname} {teacher.Age} {teacher.Experience}");
        }
    }
}