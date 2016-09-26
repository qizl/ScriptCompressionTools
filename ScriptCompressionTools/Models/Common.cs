using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ScriptCompressionTools.Models
{
    public class Common
    {
        /// <summary>
        /// jsmin.exe路径
        /// </summary>
        public static string JSMinPath = Path.Combine(Environment.CurrentDirectory, "jsmin.exe");

        /// <summary>
        /// 脚本文件格式集合
        /// </summary>
        public static List<string> ScriptFiles = new List<string>() { ".js", ".css" };
    }
}
