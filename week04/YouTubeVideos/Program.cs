using System;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Como cocinar asado", "Marcos Ferreyra", 200);
        Video v2 = new Video("Como jugar a la play", "Daniel Ferreyra", 300);
        Video v3 = new Video("Como jugar a la wii", "Marcos Daniel Ferreyra", 500);


        v1._comments.Add(new Comment("Me encantó!", " Ana"));
        v1._comments.Add(new Comment("El mejor video que vi!", " Juan"));
        v1._comments.Add(new Comment("Buen video", " Jose"));

        v2._comments.Add(new Comment("Bien", "Ana"));
        v2._comments.Add(new Comment("Me encantó!", " Juan"));
        v2._comments.Add(new Comment("Mal video", " Jose"));

        v3._comments.Add(new Comment("Me encantó!", " Jose"));
        v3._comments.Add(new Comment("Tremendo!", " Juan"));
        v3._comments.Add(new Comment("Algo flojo", " Ana"));


        List<Video> videoss = new List<Video>();

        videoss.Add(v1);
        videoss.Add(v2);
        videoss.Add(v3);

        foreach (Video parts in videoss)
        {
            Console.WriteLine($"Title: {parts._title}");
            Console.WriteLine($"Author: {parts._author}");
            Console.WriteLine($"Lenght of the video: {parts._lenght}");
            Console.WriteLine($"Number of Comments {parts.GetNumberComments()}");
            foreach (Comment part in parts._comments)
            {
                Console.Write($"Comment: {part._commentText}");
                Console.WriteLine(part._commentAuthor);


            }
            Console.WriteLine();
        }


    }
}

