using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WritingPrompter
{
    /// <summary>
    /// Global config values
    /// </summary>
    static class Config
    {
        /// <summary>
        /// The name of the database file
        /// </summary>
        public static String DatabaseFileName
        {
            get
            {
                return "WritingPrompts.xml";
            }
        }

        /// <summary>
        /// The folder in which the database is saved
        /// </summary>
        public static String DatabaseFolder
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
        }

        /// <summary>
        /// The full path of the database file
        /// </summary>
        public static String DatabaseFullPath
        {
            get
            {
                return Path.Combine(DatabaseFolder, DatabaseFileName);
            }
        }
    }
}
