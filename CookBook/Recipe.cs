using CookBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Domain;

public class Recipe : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TypeId { get; set; }
}

