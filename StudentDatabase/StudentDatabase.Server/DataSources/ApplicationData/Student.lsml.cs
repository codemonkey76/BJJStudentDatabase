﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Student
    {
        
        partial void FullName_Compute(ref string result)
        {
            result = this.LastName + ", " + this.FirstName;
        }

        partial void Age_Compute(ref short? result)
        {
            result = ((this.DateOfBirth==null)?(short?)null:(short)(DateTime.Today.Subtract((System.DateTime)this.DateOfBirth).TotalDays/365.25));

        }
    }
}
