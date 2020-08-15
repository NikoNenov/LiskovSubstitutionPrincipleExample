//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="CEO.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Search engine optimization model
//  </summary>
// 
//  <date>15-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;

namespace Nenov.LiskovSubstitutionPrincipleExample.ProjectLibrary
{
  public class CEO : Employee
  {
    /// <summary>
    /// Calculate per hour rate for CEO
    /// </summary>
    /// <param name="rank"></param>
    public override void CalculatePerHourRate(int rank)
    {
      decimal baseAmount = 150M;
      Salary = baseAmount * rank;
    }

    /// <summary>
    /// Generate performance review for CEO
    /// </summary>
    public void GeneratePerformanceReview()
    {
      Console.WriteLine($"I am reviewing a direct reports performance.");
    }

    /// <summary>
    /// Assign manager method
    /// </summary>
    /// <param name="manager"></param>
    public override void AssignManager(Employee manager)
    {
      throw new InvalidOperationException("The CEO has no manager!");
    }

    /// <summary>
    /// Fire someone
    /// </summary>
    public void FireSomeone()
    {
      Console.WriteLine("You are fired!");
    }
  }
}
