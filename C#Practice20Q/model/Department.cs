
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice.Model
{
    class Department
    {
        public string Name { get; set; }
        public Manager Manager { get; set; }
        // Shallow Copy
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }
        // Deep Copy
        public Department DeepCopy()
        {
            Department clone = (Department)this.MemberwiseClone();
            clone.Manager = new Manager { Name = this.Manager.Name };
            return clone;
        }
    }
    class Manager
    {
        public string Name { get; set; }
    }
}
