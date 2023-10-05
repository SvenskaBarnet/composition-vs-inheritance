using System.ComponentModel.DataAnnotations;

namespace composition_vs_inheritance;

public class NewsUploader : User
{
     public NewsUploader (string username, string email) : base(username, email)
    {

    }

    public bool UploadNews(string title, string content)
    {
        if (content.Length > 0)
        {
            Console.WriteLine("Upload news: " + title);
            return true;
        }
        else
        {
            return false;
        }
    }
}
