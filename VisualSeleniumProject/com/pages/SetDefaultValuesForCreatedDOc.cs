using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualSeleniumProject.com.pages.mappers;
using VisualSeleniumProject.tools;

namespace VisualSeleniumProject.com.pages
{

    class SetDefaultValuesForCreateDoc
    {
        String propertiesFileName = "blab";
        String docJson = "Test DocJson Name";
        //String id = "fc3d61a9-8e3a-427f-8def-102affd88210";

        //Returning the Properties object
        public Properties setDefaultProperties()
        {
            Properties properties = new Properties();
            properties.filename = propertiesFileName;
            return properties;
        }

        //Returning the whole mapper with values
        public CreateDocMapperRoot setCreateDocDefaultValues()
        {
            CreateDocMapperRoot createDoc = new CreateDocMapperRoot();
            Constants.GUID = Guid.NewGuid().ToString();
            createDoc.id = Constants.GUID;
            createDoc.docJson = docJson;
            createDoc.properties = setDefaultProperties();
            return createDoc;
        } 
    }
}
