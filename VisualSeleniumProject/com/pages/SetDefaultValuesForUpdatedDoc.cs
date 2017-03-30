using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualSeleniumProject.com.pages.mappers;

namespace VisualSeleniumProject.com.pages
{

    class SetDefaultValuesForUpdateDoc
    {
        String propertiesFileName = "blabla updated";
        String docJson = "test";
        String id = "fc3d61a9-8e3a-427f-8def-102affd88210";

        //Returning the Properties object
        public Properties updateProperties()
        {
            Properties properties = new Properties();
            properties.filename = propertiesFileName;
            return properties;
        }

        //Returning the whole mapper with values
        public CreateDocMapperRoot setUpdateDocDefaultValues()
        {
            CreateDocMapperRoot updateDoc = new CreateDocMapperRoot();
            updateDoc.id = id;
            updateDoc.docJson = docJson;
            updateDoc.properties = updateProperties();
            return updateDoc;
        }
    }
}
