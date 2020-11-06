using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PointsAndLines;

namespace Sec02
{

   class EntryPoint
   {
      static void Main()
      {
         User user = new User("Vachev");

         user.Password = 2;

         System.Console.WriteLine(user.Username);


      }
   }
}
