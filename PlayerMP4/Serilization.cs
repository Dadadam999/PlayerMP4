using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMP4 {
    [Serializable]
    public class Serilization {
        public VideoProject vp { get; set; }
        public List<Bookmark> bm { get; set; }
    }
}
