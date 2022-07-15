using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Domain.Common;

namespace CookBook.Domain.Entity
{
    public class BaseEntity : AuditableModel
    {
        public int Id { get; set; }
    }
}
