//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Employee.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Employee model
//  </summary>
// 
//  <date>15-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

namespace Nenov.LiskovSubstitutionPrincipleExample.ProjectLibrary
{
  public class Employee
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Employee Manager { get; set; }
    public decimal Salary { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public Employee()
    {
      Manager = null;
    }

    /// <summary>
    /// Assign manager method
    /// </summary>
    /// <param name="manager"></param>
    public virtual void AssignManager(Employee manager)
    {
      // Simulate doing other tasks here - otherwise,
      // this should be a property set statement, not a method.
      Manager = manager;
    }

    /// <summary>
    /// Calculate per hour rate
    /// </summary>
    /// <param name="rank"></param>
    public virtual void CalculatePerHourRate(int rank)
    {
      decimal baseAmount = 12.50M;
      Salary = baseAmount + (rank * 2);
    }
  }
}
