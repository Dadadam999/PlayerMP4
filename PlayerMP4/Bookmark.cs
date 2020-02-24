using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMP4
{
    [Serializable]
    public class Bookmark
    {
        public Bookmark(string Name, double Position) {
            this.Name = Name;
            this.Position = Position;
        }
        public string Name { get; set; }
        public double Position { get; set; }
    }
}
