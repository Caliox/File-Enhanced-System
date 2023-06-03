using FileEnhanced.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileEnhanced.Common
{
    public class Global
    {
        //私有化构造方法，外界无法实例化此类
        private Global()
        {
        }

        //获取单例实例
        private static Global _instance = null;
        public static Global Instance
        {
            get
            {
                if (_instance == null)
                    return _instance = new Global();
                return _instance;
            }
        }

        public FileEnhancedForm mainForm = null;

        // 获取子控件的指定类型父控件
        public static T GetParentByType<T>(Control ctrl)
        {
            if (ctrl.Parent == null)
                return default(T);
            if (ctrl.Parent is T parentControl)
                return parentControl;
            return GetParentByType<T>(ctrl.Parent);
        }

        // 根据根节点合并XML文件
        public static XElement MergeXmlByRoot(string[] files, string rootName, string targetNodeName)
        {
            if (files == null) return null;

            XElement result = new XElement(rootName);
            foreach (string file in files)
            {
                if (!File.Exists(file)) continue;
                IEnumerable<XElement> targetNodes = XElement.Load(file).Elements(targetNodeName);
                if (targetNodes.Count() > 0)
                {
                    result.Add(targetNodes);
                }
            }
            return result;
        }
    }
}
