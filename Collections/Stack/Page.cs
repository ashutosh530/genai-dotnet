using System;

namespace PageBH
{
    public class Page
    {
        public int Id { get; set;}
        public string Title { get; set; }
        public string Url { get; set; }

        public Page(int id, string title, string url)
        {
            Id = id;
            Title = title;
            Url = url;
        }
    }
}