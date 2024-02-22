namespace Classes;


public class Person{
    public string FirstName { get; set; }
    public String LastName { get; set; }

    public string GetFullName(){
        return $"{FirstName} {LastName}";
    }

    public Person(string firstName, string lastName){
        Console.WriteLine("Inside the Person-Class Constructor");
        FirstName = firstName;
        LastName = lastName;

    }
};