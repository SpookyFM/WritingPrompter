using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingPrompter
{
    /// <summary>
    /// A (potentially hierarchical) Category
    /// </summary>
    public class Category
    {

        public Category()
        {
        }

        public Category(String InName)
        {
            Name = InName;
        }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// The name of the category
        /// </summary>
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// The parent category
        /// </summary>
        public Category Parent
        {
            get;
            set;
        }

    }
}
