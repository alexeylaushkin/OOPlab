using System;
using System.Collections.Generic;
using System.Text;

namespace KLADobj.DomainObjects
{
  public class kladobj : DomainObject
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string PaidService { get; set; }
        public string CloseFlag { get; set; }

    }
}
