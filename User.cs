namespace composition_vs_inheritance;

public class User
{

    public string FirstName;
    public string LastName;
    public readonly string UserName;
    public string Email;
    public string DOB;
    private string _password;

    public User(string username, string email)
    {
        UserName = username;
        Email = email;
    }

    public int Age()
    {
        throw new NotImplementedException();
    }
}
