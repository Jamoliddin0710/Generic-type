using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.Entities;

namespace Generic_type
{
    internal class User : BaseClass, IEntity
    {
        public int id { get; set; }
        public string name { get; set; }

    }
}
