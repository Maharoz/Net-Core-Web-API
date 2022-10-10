using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.LinkModels
{
    public class LinkResourceBase
    {
        public LinkResourceBase() { }
        public List<Link> Links { get; set; } = new List<Link>();
    }


    public class LinkCollectionWrapper<T> : LinkResourceBase {
        public List<T> Value { get; set; } = new List<T>(); 
        public LinkCollectionWrapper() { 
        }
        public LinkCollectionWrapper(List<T> value) => Value = value; }
}
