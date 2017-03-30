using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSeleniumProject.com.pages.mappers
{
    public class Link
    {
        public string fileId { get; set; }
        public string operation { get; set; }
        public string method { get; set; }
        public string url { get; set; }
    }

    public class createDocDeserialiser
    {
        public string bcmDocumentId { get; set; }
        public List<Link> links { get; set; }
    }
}
