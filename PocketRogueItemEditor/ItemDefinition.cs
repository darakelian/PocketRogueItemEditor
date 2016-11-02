using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRogueItemEditor
{
    public class ItemDefinition
    {
        public string name { get; set; }
        public int[] icon { get; set; }
        public bool stackable { get; set; }
        public string slot { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}
