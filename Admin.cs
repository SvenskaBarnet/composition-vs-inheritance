namespace composition_vs_inheritance;

public class Admin : NewsUploader 
{
    public Admin(string username, string email) : base(username, email)
    {
        
    }
}
