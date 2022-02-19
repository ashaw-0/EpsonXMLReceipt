using EpsonXmlPrint.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace EpsonXmlPrint.Models
{
    public class EpsonTest
    {
        public static XmlDocument model()
        {
            XmlDocument Body = new XmlDocument(); //Example document
            Body.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>  
            <s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"">  
                 <s:Body>  
                    <epos-print xmlns=""http://www.epson-pos.com/schemas/2011/03/epos-print"">
                      <text lang=""en"" smooth=""true"">Test&#10;</text>
                      <feed unit=""24""/>
                      <image width=""512"" height=""512"" color=""color_1"" mode=""mono"">8PDw8A8PDw/w8PDwDw8PD/Dw8PAPDw8P8PDw8A8PDw/w8PDwDw8PD/Dw8PAPDw8P</image>
                      <cut/>
                    </epos-print>
                  </s:Body>  
            </s:Envelope>");

            Console.WriteLine(Body.ToString());
            return Body;
        }

        public static XmlDocument imgTest(string Msg, attributes a)
        {
            using (Utf8StringWriter xmlOutput = new Utf8StringWriter())
            using (XmlTextWriter xmlWriter = new XmlTextWriter(xmlOutput))
            {
                XmlTextWriter w = new XmlTextWriter(xmlOutput);
                w.Formatting = Formatting.Indented;
                w.WriteStartDocument();
                w.WriteStartElement("s", "Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
                w.WriteStartElement("s:Body");
                w.WriteStartElement("epos-print", "http://www.epson-pos.com/schemas/2011/03/epos-print");
                w.WriteStartElement("image");
                w.WriteAttributeString("width", "256");
                w.WriteAttributeString("height", "34");
                w.WriteAttributeString("color", "none");
                w.WriteAttributeString("mode", "gray16");
                w.WriteString(a.b64);
                w.WriteEndElement();
                w.WriteStartElement("text");
                w.WriteString(Msg + "\n");
                w.WriteEndElement();
                w.WriteStartElement("cut");
                w.WriteEndElement();
                w.WriteEndElement();
                w.WriteEndElement();
                w.WriteEndElement();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlOutput.ToString());
                w.Flush();
                return xmlDocument;
            }
        }


        public static XmlDocument receiptDemo(List<itemLine> lines)
        {
            using (Utf8StringWriter xmlOutput = new Utf8StringWriter())
            using (XmlTextWriter xmlWriter = new XmlTextWriter(xmlOutput))
            {
                XmlTextWriter w = new XmlTextWriter(xmlOutput);
                w.Formatting = Formatting.Indented;
                w.WriteStartDocument();
                w.WriteStartElement("s", "Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
                w.WriteStartElement("s:Body");
                w.WriteStartElement("epos-print", "http://www.epson-pos.com/schemas/2011/03/epos-print");
                w.WriteStartElement("text"); //center logo
                w.WriteAttributeString("align", "left");
                w.WriteEndElement();
                w.WriteStartElement("image"); //create logo object
                w.WriteAttributeString("width", "360");
                w.WriteAttributeString("height", "104");
                w.WriteAttributeString("color", "color_1");
                w.WriteAttributeString("mode", "gray16");
                w.WriteString(constants.logoBase64Gray16);
                w.WriteEndElement();

                w.WriteStartElement("text");
                w.WriteString("Thanks for your purchase" + "\n");
                w.WriteEndElement();
                w.WriteStartElement("text");
                w.WriteString("Purchase Date: " + DateTime.Now.ToString() + "\n");
                w.WriteEndElement();
                w.WriteStartElement("feed");
                w.WriteEndElement();
                w.WriteStartElement("feed");
                w.WriteEndElement();

                foreach (var l in lines)
                {
                    w.WriteStartElement("text");
                    w.WriteString(l.itemCode + "-" + l.itemName + "\n");
                    w.WriteEndElement();
                    w.WriteStartElement("text");
                    w.WriteString(l.qty + "x £" + l.price  + "\n");
                    w.WriteEndElement();
                    w.WriteStartElement("image");
                    w.WriteAttributeString("width", "256");
                    w.WriteAttributeString("height", "34");
                    w.WriteAttributeString("color", "color_1");
                    w.WriteAttributeString("mode", "gray16");
                    w.WriteString(l.chineseB64);
                    w.WriteEndElement();
                    w.WriteStartElement("feed");
                    w.WriteEndElement();
                }
                w.WriteStartElement("cut");
                w.WriteEndElement();
                w.WriteStartElement("feed");
                w.WriteEndElement();
                w.WriteStartElement("feed");
                w.WriteEndElement();
                w.WriteStartElement("cut");
                w.WriteAttributeString("type", "feed");
                w.WriteEndElement();
                w.WriteEndElement();
                w.WriteEndElement();
                w.WriteEndElement();



                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlOutput.ToString());
                w.Flush();
                return xmlDocument;
            }
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }

    }
}
