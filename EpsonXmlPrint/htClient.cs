using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EpsonXmlPrint
{
    public  class htClient
    {
        public static HttpWebRequest CreateSOAPWebRequest(long ConLeng)
        {
            HttpWebRequest request;

            //Making Web Request    
            request = (HttpWebRequest) WebRequest.Create(Utilities.constants.printerURL);
            request.Method = "POST";
            request.ContentType = "text/xml; charset=utf-8";
            request.ContentLength = ConLeng;
            request.Headers.Set("SOAPAction", "\"\"");
            return request;
        }

        public static void InvokeService(XmlDocument xml)
        {
            var ConLeng = Encoding.UTF8.GetByteCount(xml.OuterXml);


            HttpWebRequest request = CreateSOAPWebRequest(ConLeng);


            using (Stream stream = request.GetRequestStream())
                    {
                        xml.Save(stream);
                    }

            using (WebResponse Services = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Services.GetResponseStream()))
                {
                    var ServiceResult = rd.ReadToEnd();
                    Console.WriteLine(ServiceResult);
                }
            }
        }

        
        

    }
}
