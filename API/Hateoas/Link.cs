using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Hateoas
{
    public class Link
    {
        public string href{get; set;}
        public string rel{get; set;}
        public string method{get; set;}
        public Link(string href, string rel, string method){
            this.href = href;
            this.rel = rel;
            this.method = method;
        }
    }
}