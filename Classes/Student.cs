namespace Classes;

public class Student : Person{
    public int StudentId = 10000;

    public readonly int maxEnrolledCourses = 3;

    public static int maxBooksAllowed = 6;

    public Student(string firstName, string lastName) : base(firstName, lastName){
        Console.WriteLine("Inside the Student Constructor");
        FirstName = firstName;
        LastName = lastName;
    }
};