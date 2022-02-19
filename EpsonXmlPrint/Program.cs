using EpsonXmlPrint.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel;
using System.Text.RegularExpressions;

namespace EpsonXmlPrint
{
    class Program
    {

        static void Main(string[] args)
        {

            List<itemLine> itemLines = new List<itemLine>() //Example list of items for receipt
            {
                new itemLine() {itemName = "LGM Crispy Chilli Oil", itemCode = "12345", chinese = "老干媽香辣脆油辣椒", qty = "3", price = "2.99"},
                new itemLine() {itemName = "GL Chinese Fortune Cookies (5 pcs)", itemCode = "6789", chinese = "金燈籠簽語餅", qty = "1", price = "0.99"},
                new itemLine() {itemName = "Akagi Joshu Soba (Buckwheat Noodle)", itemCode = "101112", chinese = "日本赤城蕎麥麵", qty = "8", price = "1.8"}
            };

            PrintReceiptWithImage(itemLines);
        }


        public static void PrintReceiptWithImage(List<itemLine> itemLines)
        {
            foreach(var line in itemLines)
            {
                line.chineseB64 = stringToImage.makeGray16Chinese(line.chinese); //convert text to Base64 binary images
            }
            XmlDocument xml = Models.EpsonTest.receiptDemo(itemLines);
            htClient.InvokeService(xml);
        }

        //public static void PrintTestWithImage(string chinese, string msg)
        //{
        //    var message = stringToImage.makeGray16Image(chinese);
        //    XmlDocument xml = Models.EpsonTest.imgTest(msg, message);
        //    htClient.InvokeService(xml);
        //}




    }

}
