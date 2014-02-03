using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Rank
    {
        partial void FullBelt_Compute(ref string result)
        {
            result = "";
            if (this.Belt != null)
                result += this.Belt;

            if (this.Stripes!=null)
                if (this.Stripes.ToString().Length>1)
                    result += " - (" + this.Stripes + ")";
        }
    }
}
