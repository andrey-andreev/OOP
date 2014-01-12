using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolHierarchy
{
    public abstract class IAnnotation
    {
        public string Comment { get; set; }

        public void AddComment(string comment)
        {
            this.Comment = comment;
        }

        public string PrintComment()
        {
            return this.Comment;
        }
    }
}
