//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Manager.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Manager model
//  </summary>
// 
//  <date>15-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;

namespace Nenov.LiskovSubstitutionPrincipleExample.ProjectLibrary
{
  public class Manager : Employee
  {

    /// <summary>
    /// Calculate per hour rate for manager
    /// </summary>
    /// <param name="rank"></param>
    public override void CalculatePerHourRate(int rank)
    {
      decimal baseAmount = 19.75M;
      Salary = baseAmount + (rank * 4);
    }

    /// <summary>
    /// Generate performance review for Manager
    /// </summary>
    public void GeneratePerformanceReview()
    {
      Console.WriteLine($"I am reviewing a direct reports performance.");
    }
  }
}
