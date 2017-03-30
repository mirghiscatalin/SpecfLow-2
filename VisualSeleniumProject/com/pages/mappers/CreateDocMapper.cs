using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSeleniumProject.com.pages.mappers
{

    public class Properties
    {
        public string filename { get; set; }
    }

    public class CreateDocMapperRoot
    {
        public string id { get; set; }
        public string docJson { get; set; }
        public Properties properties { get; set; }
    }

}
 