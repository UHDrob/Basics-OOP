using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PointsAndLines;

namespace IntrotoOOP
{

   class EntryPoint
   {
      static void Main()
      {
         User user = new User("Vachev", Race.Earthing);

         User secondUser = new User();

         User thirdUser = new User();

         user.SayMyName();

         Utilities.ColorfulWriteLine(user.Username, ConsoleColor.DarkRed);

         Console.ForegroundColor = ConsoleColor.DarkRed;

         Console.WriteLine(user.ID);
         Console.WriteLine(secondUser.ID);
         Console.WriteLine(thirdUser.ID);

         Console.WriteLine(User.currentID);
      }
   }
}
