namespace composition_vs_inheritance;

public class Student : User
{
    public string Klass;
    public Student(string username, string email, string klass) : base(username, email)
    {
        Klass = klass;
    }
}
