using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ORMApp.Model
{
    public class Investor5
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
