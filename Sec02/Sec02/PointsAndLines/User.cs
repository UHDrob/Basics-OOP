using System;
using System.Collections.Generic;
using System.Text;
using Sec02;


namespace PointsAndLines
{
   class User
   {

      public readonly int HEIGHT;
      public readonly int ID;

      public static int currentID;

      public  Race race;

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
         get
         {
            return password;
         }

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
         currentID++;
         ID = currentID;
      }

      public User(string username, Race race)
      {
         currentID++;
         ID = currentID;
         this.username = username;
         this.race = race;
         if (this.race == Race.Martian)
         {
            HEIGHT = 100;
         }
         else if (this.race==Race.Earthing)
         {
            HEIGHT = 180;
         }
         race = Race.Martian;

      }
   }
}
