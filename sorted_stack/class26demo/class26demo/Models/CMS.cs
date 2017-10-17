using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class26demo.Models
{
    //we are building a content manage solution (very common in the industry)
    //this controls what the users/clients can access
    public class CMS
    {
        public int ID
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public string Content
        {
            get; set;
        }
        public bool IsPublished
        {
            get; set;
        }
    }
}
