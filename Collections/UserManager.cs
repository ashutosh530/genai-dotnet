using System;
using System.Collections.Generic;

namespace UserManager
{
    public class User
    {
        private HashSet<string> _user;

        public User()
        {
            _user = new HashSet<string>();

        }

        public void RegisterUser(string emailId)
        {
            if (_user.Add(emailId))
            {
                Console.WriteLine($"Register Email Id : {emailId}");
            }
            else
            {
                Console.WriteLine($"Email Id is {emailId} already exists.");
            }
        }

        public void RemoveUser(string emailId)
        {
            if (_user.Remove(emailId))
            {
                Console.WriteLine($"User is {emailId} removed successfully.");
            }
            else
            {
                Console.WriteLine("Email Id not found.");
            }
        }

        public string SearchUser(string emailId)
        {
            if (_user.Contains(emailId))
            {
                return emailId;
            }

            return "Email Id is not found.";
        }

        public void DisplayUser()
        {
            if(_user.Count == 0)
            {
                Console.WriteLine("User is not available");
            }
            foreach(string user in _user)
            {
                Console.WriteLine(user);
            }
        }
    }
}