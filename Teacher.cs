namespace composition_vs_inheritance;

public class Teacher : NewsUploader
{
    public Teacher(string username, string email) : base(username, email)
    {

    }
}
