﻿//-----------------------------------------------------------------------
// <copyright file="ITarget.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// creating interface for get employee details
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns> returns the employee data</returns>
        List<string> GetEmployeeList();
    }
}
