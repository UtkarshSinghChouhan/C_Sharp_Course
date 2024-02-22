namespace CMS.UI.Models;
public class Student
{

    // We can also assign the deafault value  to the class feild during the creation of the class feilds
    public string firstName = default;
    public string lastName = string.Empty;   //the default value of the string is null i.e. empty string
    public int id = 0;

    public const int maxEnrolledCourses = 3;

    public  readonly int price  = 1000;

    public static int maxBooksAllowed = 3;

    public Student(){
        price = 2000;
    }


}
