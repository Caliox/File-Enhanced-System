using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEnhanced.Common
{
    public class InfoMetaEntity
    {
        public InfoEntity Infos { get; set; }
        public MetaEntity Metas { get; set; }
    }

    public class InfoEntity
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string CreationTime { get; set; }
        public string LastWriteTime { get; set; }
        public string LastAccessTime { get; set; }
        public string Extension { get; set; }
        public string DirectoryName { get; set; }
        public string Size { get; set; }
    }

    public class MetaEntity
    {
        public string FileName { get; set; }
        public string DirPath { get; set; }
        public string FileType { get; set; }
        public string[] Tags { get; set; }
        public string FileDesc { get; set; }
    }
}
