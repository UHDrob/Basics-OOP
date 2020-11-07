﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorWars
{
   static class Tools
   {
      public static void ColorfulWriteLine(string text, ConsoleColor color)
      {
         Console.ForegroundColor = color;
         Console.WriteLine(text);
         Console.ResetColor();
      }
   }
}
