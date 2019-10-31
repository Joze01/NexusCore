using System;
using System.Collections.Generic;

namespace TestProject.Models.Openf
{
    public partial class Oproyecto
    {
        public int ParamOwner { get; set; }
        public int ParamMember { get; set; }

        public virtual Otest ParamMemberNavigation { get; set; }
        public virtual Otest ParamOwnerNavigation { get; set; }
    }
}
