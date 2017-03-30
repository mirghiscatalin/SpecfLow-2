using OpenQA.Selenium;
using System;
using RestSharp;
using VisualSeleniumProject.com.mappers;
using VisualSeleniumProject.com.pages.mappers;
using VisualSeleniumProject.com.pages;
using VisualSeleniumProject.tools;

namespace VisualSeleniumProject.pages
{
    class RestSharpPage : AbstractPage
    {


        //Selectors used to the page
        private By inputFieldSelector = By.Name("q");

        public DataFormat RequestFormat { get; private set; }

        //page constructor - extended with AbstractPage constructor
        public RestSharpPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public String restSharpTestMethod()
        {
            //Creating RestClient object
            var restObj = new RestClient();
            restObj.BaseUrl = new Uri("http://api.fixer.io/latest");

            //Execute Request 
            var request = new RestRequest(Method.GET);
            IRestResponse response = restObj.Execute(request);

            //Deserialising Request
            RestSharp.Deserializers.JsonDeserializer deserialiser = new RestSharp.Deserializers.JsonDeserializer();
            RootObject testMapper = deserialiser.Deserialize<RootObject>(response);

            //Working with objects
            String x = testMapper.rates.RON.ToString();
            return x;
        }

        public String ExecutePostWithDefaultValues()
        {
            //Creating RestClient object
            var restObj = new RestClient();
            restObj.BaseUrl = new Uri("http://editorservice1:8080/bcms/bcm/documents/");

            //Serialising
            var request = new RestRequest(Method.POST) { RequestFormat = DataFormat.Json };
            SetDefaultValuesForCreateDoc setDefault = new SetDefaultValuesForCreateDoc();
            request.AddJsonBody(setDefault.setCreateDocDefaultValues());

            //Execute Request 
            IRestResponse response = restObj.Execute(request);

            //Deserialising Request
           /* RestSharp.Deserializers.JsonDeserializer deserialiser = new RestSharp.Deserializers.JsonDeserializer();
            createDocDeserialiser createDocDeserialiser = deserialiser.Deserialize<createDocDeserialiser>(response);

            //Working with objects
            String bcmDocumentId = createDocDeserialiser.bcmDocumentId;
            return bcmDocumentId;*/

            int putResponseCode = (int)response.StatusCode;
            return putResponseCode.ToString();
        }


        public String ExecutePutMethod()
        {
            var restObj = new RestClient();
            restObj.BaseUrl = new Uri("http://editorservice1:8080/bcms/bcm/documents/" + Constants.GUID);

            var request = new RestRequest(Method.PUT);
            //{ RequestFormat = DataFormat.Json};

            request.AddParameter("text/plain", " {\"id\": \"" + Constants.GUID + "\",\"docJson\": \"test123\",\"properties\": {\"filename\": \"123\"}}", ParameterType.RequestBody);

            //SetDefaultValuesForUpdateDoc setDefault = new SetDefaultValuesForUpdateDoc();
            //request.AddJsonBody(setDefault.setUpdateDocDefaultValues());

            IRestResponse response = restObj.Execute(request);

            /*RestSharp.Deserializers.JsonDeserializer deserialiser = new RestSharp.Deserializers.JsonDeserializer();
            createDocDeserialiser updateDocDeserialiser = deserialiser.Deserialize<createDocDeserialiser>(response);*/

            int putResponseCode = (int)response.StatusCode;
            return putResponseCode.ToString();
        }



        public String ExecuteGetMethod()
        {
            var restObj = new RestClient();
            restObj.BaseUrl = new Uri("http://editorservice1:8080/bcms/bcm/documents/" + Constants.GUID);

            var request = new RestRequest(Method.GET);

            IRestResponse response = restObj.Execute(request);

            RestSharp.Deserializers.JsonDeserializer deserialiser = new RestSharp.Deserializers.JsonDeserializer();
            CreateDocMapperRoot CreateDocMapperRoot = deserialiser.Deserialize<CreateDocMapperRoot>(response);

            String docJsonName = CreateDocMapperRoot.docJson;
            return docJsonName;

            //String getResponseCode = response.StatusCode.ToString();
            //return getResponseCode;

        }

        public String ExecuteGetMethodAfterPost()
        {
            var restObj = new RestClient();
            restObj.BaseUrl = new Uri("http://editorservice1:8080/bcms/bcm/documents/" + Constants.GUID);

            var request = new RestRequest(Method.GET);

            IRestResponse response = restObj.Execute(request);

            /* RestSharp.Deserializers.JsonDeserializer deserialiser = new RestSharp.Deserializers.JsonDeserializer();
             CreateDocMapperRoot CreateDocMapperRoot = deserialiser.Deserialize<CreateDocMapperRoot>(response);*/

            String responseText = response.Content;
            return responseText;

        }


        public String ExecuteDeleteMethod()
        {
            var restObj = new RestClient();
            restObj.BaseUrl = new Uri("http://editorservice1:8080/bcms/bcm/documents/" + Constants.GUID);

            var request = new RestRequest(Method.DELETE);
            IRestResponse response = restObj.Execute(request);

            int deleteResponseCode = (int)response.StatusCode;
            return deleteResponseCode.ToString();
        }


        public long GetContentLength()
        {
            var restObj = new RestClient();
            restObj.BaseUrl = new Uri("http://editorservice1:8080/bcms/bcm/documents/" + Constants.GUID);

            var request = new RestRequest(Method.GET);

            IRestResponse response = restObj.Execute(request);

            /* RestSharp.Deserializers.JsonDeserializer deserialiser = new RestSharp.Deserializers.JsonDeserializer();
             CreateDocMapperRoot CreateDocMapperRoot = deserialiser.Deserialize<CreateDocMapperRoot>(response);*/

            long contentlength = response.ContentLength;
            return contentlength;

        }


    }
}
