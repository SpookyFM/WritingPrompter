using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingPrompter
{
    /// <summary>
    /// A grammar point, i.e. an explanation together with writing prompts
    /// </summary>
    public class GrammarPoint
    {
        /// <summary>
        /// The short name of the grammar point
        /// </summary>
        public String Name
        {
            get;
            set;
        }

        public Category Category
        {
            get;
            set;
        }

        /// <summary>
        /// A short (~1 sentence) summary of the grammar point
        /// </summary>
        public String ShortSummary
        {
            get;
            set;
        }

        /// <summary>
        /// A detailed summary of the grammar point, can be as long as required
        /// </summary>
        public String DetailedSummary
        {
            get;
            set;
        }

        /// <summary>
        /// Rules of the grammar point is formed
        /// </summary>
        public String Formation
        {
            get;
            set;
        }

        /// <summary>
        /// Pre-translated examples
        /// </summary>
        public List<Sentence> Examples
        {
            get;
            set;
        }

        public List<Sentence> Sentences
        {
            get;
            set;
        }

        public GrammarPoint()
        {
            Examples = new List<Sentence>();
            Sentences = new List<Sentence>();
        }

        public GrammarPoint(String InName) : this ()
        {
            Name = InName;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
