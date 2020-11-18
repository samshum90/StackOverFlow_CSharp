using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverFlow
{
    public class Post
    {
        private string title;
        private string description;
        private DateTime created;
        private int upVotes;
        private int downVotes;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Created { get => created; set => created = value; }
        public int UpVotes { get => upVotes; set => upVotes = value; }
        public int DownVotes { get => downVotes; set => downVotes = value; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
                throw new ArgumentNullException("Title and/or Description cannot be empty");
            else
                ShowVotes();
        }
        public void UpVote()
        {
            ++upVotes;
            ShowVotes();
        }        public void DownVote()
        {
            ++DownVotes;
            ShowVotes();
        }
        public void ShowVotes()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("*-*-*-*-*-*-*-*-*");

            Console.WriteLine("Title: " + Title);
            Console.WriteLine("-");

            Console.WriteLine("Description:");
            Console.WriteLine(Description);

            Console.WriteLine("-");
            Console.WriteLine("Up-Votes:   " + upVotes);
            Console.WriteLine("Down-Votes: " + downVotes);

            Console.WriteLine("-");
            Console.WriteLine("Date created: " + created);

            Console.WriteLine();
            Console.WriteLine("*-*-*-*-*-*-*-*-*");
        }
    }
}
