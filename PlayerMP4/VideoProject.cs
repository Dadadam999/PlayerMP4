using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMP4
{
    [Serializable]
    public class VideoProject
    {
        public VideoProject(string FilePath) {
            this.FilePath = FilePath;
        }
        public string FilePath { get; set; }
        public string Name { get { return Path.GetFileNameWithoutExtension(FilePath); } }
        public List<Bookmark> Bookmarks = new List<Bookmark>();
    }
}
