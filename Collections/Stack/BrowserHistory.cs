using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PageBH;

namespace BrowserHistoryManage
{
    public class BrowserHistory
    {
        private Stack<Page> history;

        public BrowserHistory()
        {
            history = new Stack<Page>();
        }

        public void VisitPage(Page page)
        {
            history.Push(page);
            Console.WriteLine($"{page.Title} visite successfully..");
        }

        public Page GetCurrentPage()
        {
            Page current = history.Peek();
            Console.WriteLine($"Title: {current.Title}");
            Console.WriteLine($"URL: {current.Url}");

           return null;
        }

        public Page GoBack()
        {
            if (history.Count > 0)
            {
                return history.Pop();
            }
            else
            {
                Console.WriteLine("No Page in history...");
            }
            return null;
        }

        public void CountPage()
        {
            Console.WriteLine($"Total Page is : {history.Count}");
        }
    }

}