using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edible.Core.Models
{
    public class BaseEnity
    {
        public string Id { get; set; }
        public DateTimeOffset Created_At { get; set; }
        public BaseEnity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Created_At = DateTime.Now;
        }
    }
}
