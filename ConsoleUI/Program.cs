//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Console application main
//  </summary>
// 
//  <date>15-08-2020</date>
//  <author>Nikolay Nenov</author>
//  -------------------------------------------------------------------------------------------------------------------- 
using System;
using Nenov.LiskovSubstitutionPrincipleExample.ProjectLibrary;

namespace Nenov.LiskovSubstitutionPrincipleExample.ConsoleUI
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("*** Design Patterns: Liskov Substitution Principle Explained Practically in C# (The L in SOLID) ***");

      var accountingVp = new Manager
      {
        FirstName = "Ema",
        LastName = "Stone"
      };
      accountingVp.CalculatePerHourRate(4);

      var emp = new CEO // declare as CEO and code does not work
      {
        FirstName = "Tim",
        LastName = "Mueller"
      };
      emp.AssignManager(accountingVp);
      emp.CalculatePerHourRate(2);

      Console.WriteLine($"{emp.FirstName} salary is {emp.Salary}/hour.");

      Console.ReadKey();
    }
  }
}
