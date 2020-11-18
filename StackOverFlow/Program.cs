using System;

namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
            {
                bool run = true;

                Console.Write("Title of your post: ");
                string postTitle = Console.ReadLine();

                Console.Write("Description: ");
                string postDescription = Console.ReadLine();

                Post newPost = new Post(postTitle, postDescription);

                while (run)
                {
                    Console.WriteLine("To up-vote this post press + (plus) or press - (minus) to down-vote this post.");
                    Console.Write("Please enter your vote or press enter to quit: ");
                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "+":
                            newPost.UpVote();
                            continue;

                        case "-":
                            newPost.DownVote();
                            continue;

                        case "":
                            newPost.ShowVotes();
                            run = false;
                            continue;

                        default:
                            newPost.ShowVotes();
                            continue;
                    }
                }

            }
    }
}
