using System;
using System.Collections.Generic;
using System.Text;


namespace PointsAndLines
{
   class User
   {
      private string username;
      private int password;

      public string Username
      {
         get
         {
            return username;
         }

      }

      public int Password
      {

         set
         {
            if (value > 4 && value < 10)
            {
               password = value;
            }
            else
            {
               System.Console.WriteLine("Oops, this is not a value password!\n Please enter a password between 4 and 10 digits");
            }
         }
      }

      public User()
      {

      }

      public User(string username)
      {
         this.username = username;

      }
   }
}
