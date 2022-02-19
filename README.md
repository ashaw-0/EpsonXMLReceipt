# EpsonXMLReceipt
Console app demo for  printing unsupported East Asian characters to Epson ePOS receipt printer

Epson receipt printer did not support printing East Asian characters. Solution was to convert text to correctly encoded Base64 binary strings and serialize the receipt object to XML. 
Image conversion methods were found on a Javascript example of Epson ePOS dev site and converted to C#.

Images can be converted to either Gray16, or monochrome, Epson printers do not allow for certain attributes to be specified depending on the image format. 

Project is structured around outputting a receipt for a Chinese supermarket, where they may want to produce receipts with Chinese product names on. 

Demo list of items is enumerated through, converting each Chinese text character to a bitmap, which is then encoded to Epson requirements, before being added to an XML document to be serialized and sent via POST on HTTPClient 
