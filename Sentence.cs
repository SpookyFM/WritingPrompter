using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingPrompter
{
    /// <summary>
    /// A sentence to be translated.
    /// </summary>
    public class Sentence
    {
        public Sentence()
        {
        }

        public Sentence(String InOriginal)
        {
            Original = InOriginal;
        }

        public override string ToString()
        {
            return Original;
        }

        /// <summary>
        /// The string in the source language
        /// </summary>
        public String Original
        {
            get;
            set;
        }

        /// <summary>
        /// The first try of the user
        /// </summary>
        public String InitialTranslation
        {
            get;
            set;
        }

        /// <summary>
        /// The corrected version of the translation
        /// </summary>
        public String CorrectedTranslation
        {
            get;
            set;
        }

        /// <summary>
        /// Comments, e.g. additional notes
        /// </summary>
        public String Comments
        {
            get;
            set;
        }

    }
}
