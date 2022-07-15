using CookBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Domain.Entity
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }
        public int TypeId { get; set; }

    }
}

