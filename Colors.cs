using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskManager
{
    public class Colors
    {
        public int Id { get; set; }
        public string ColorName { get; set; }

        public Colors() { }
        public Colors(string data)
        {
            string[] values = data.Split('|');
            Id = int.Parse(values[0]);
            ColorName = values[1];
        }
    }
}
