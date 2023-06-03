using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEnhanced.Models
{
    public class FileCardEventArgs :EventArgs
    {
        public string FileName { get; set; }
        public string FullName { get; set; }
        public string DirPath { get; set; }
        public string FileType { get; set; }
        public string FileDesc { get; set; }
        public string[] Tags { get; set; }
        public string FileSize { get; set; }
        public string UpdatedDate { get; set; }
    }
}
