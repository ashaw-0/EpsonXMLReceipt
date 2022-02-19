﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsonXmlPrint.Utilities
{
    internal class constants
    {

        public const string logoBase64Mono = @"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD//////////6AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAOkkkkkkkkkkvAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAd//////////1wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA7VVVVVVVVVVegAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABu//////////r4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA7qqqqqqqqqq9QAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABtd3d3d3d3d3XoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABb3d3d3dXd3d64AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA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";
        public const string logoBase64Gray16 = @"//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////8AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA8P/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAPD/D/D/D/D/D/D/D/D/D/D/D/D/D/D/D/D/D/D/D/DwAA////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////8ADwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAPDwAP//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AA8A8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8AAPD//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDwAPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADw8AAA//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AA8ADw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PDw8PAADw8P/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDwDw8ADwAPAA8ADwAPAA8ADwAPAA8ADwAPAA8ADwAPAA8PAADw/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8A8AAPAA8ADwAPAA8ADwAPAA8ADw8PAA8ADwAPAA8ADwAA8PAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAPAPDwDwDw8A8A8PAPAPDwDwDw8P//8PAPAPDwDwDw8A8PAA8P//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////DwDwAA8A8AAPAPAADwDwAPAPAAAP//8ADwDwAA8A8AAPAADwAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAA8A8PAPAPDwDwDw8A8A///wDw8P//8A8A8A8PAPAPDwDw8A8PD////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8PAAAAAAAAAA8A8P8AAAD//wAAAP//8PAAAAAADwAAAA8AAPAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAADw8PDw8PDwAA////Dw///w8PD///AAAPDw8PAA8PDwAPDwDw//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Dw8AAAAPAA8A8P////8AAP//AA8P////////AA8PAA8A8AAA8A/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAPAPDw8ADwAPAAD///8PD//wDwD//////////wAADwAPAPDwAP/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8AAAAPAPAA8ADw8P//8AAP/wAA//////////8A8PAA8ADwAPDw/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDw8PDwDwDwDw8AAAAP/////w/w////AA8P//8PAADwDw8A8AAA//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AADwAA8A8A8AAPDw////////////8ADwAA8PAADw8A8AAPAPDw/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDw8A8PAAAPAPDwAAD/////////////////DwDw8AAPAPDwDwAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8AAAAADw8ADwAA8P///w8P/w8P/////////wAAAPDwAAAAAA8P/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAPDw8PAADw8A8PAAAAAAD/8ADw//////////Dw8AAA8PDw8PAA//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////DwAPAA8PAAAAAP//APAPD///AAD///8AD///AADw8PAA8AAADw//////////////////////////////////////////////////////////////////////////////////////////D///D///////////////Dw8PDw8PDw8P//////////////////AAAAAA/////////////////w8AAAAADw/////////////////wAA8ADwAA8PDw////8ADw//////AP//8P///wDw8ADwDwAPDw8A////////8AAAAAD/////////AAAAAA//////AAAAAAAP////////8AAAAA//////////8AAAAA////////////8AAAAAAAAAAAAAD/////////AAAAAAAAAAAAAA//////////////AADwAAAPAA/////////////wAAAAAAAAAAAP///////////////w8PAPAPDwAAAA/////w8P//////DwD/////8A8AAPAA8A8AAPAP/////////wAAAAAP////////AAAAAP//////AAAAAAAA////////8AAAAA//////////8AAAAP/////////////wAAAAAAAAAAAAAAD///////AAAAAAAAAAAAAAAP//////////8AAAAADwDwAAAP//////////8AAAAADwDw8AAP///////////////wAADwDwAPDw8PD////wD///////AAAP////APAPDwDwAPAPDwAA/////////wAAAAAP////////DwAAD//////wAAAAAAAP/////////wAAAA//////////8AAAAA/////////////wAAAAAAAAAAAAAAAP//////AAAAAAAAAAAAAAAA//////////AADwAAAAAAAAAAD////////wAADwAA8AAAAAD/////////////////Dw8A8A8AAPAAAPDw8P////AP/////w///////wAA8A8ADwAA8P//////////AAAAAP////////AADwD//////wAAAAAAAA////////8ADw8A//////////8AAAAP/////////////wAAAAAAAAAAAAAAAA//////AA8A8A8A8A8PDw8AD////////wAPAAAPAAAAAAAAD///////8AAAAADwAAAAAAAP///////////////wAPAAAAAPDwDw8AAAAP///wAP//////////////8PAPAPAA8PAA//////////AAAAAA///////wAAAA///////wDwAAAAAA////////8AAAAA//////////8AAAAP/////////////wAADwDwAPAAAADwDw//////AAAAAAAAAAAAAAAAAP//////8AAAAADwAA8AAAAAAA//////8AAA8AAAAAAAAA/////////////////w8ADw8PDwAA8ADw8P////8AD///////////////8ADwDwDwAADw//////////8A8A8A///////wAAAA//////8AAAD/DwDw/////////wAAAA//////////8PDw8P/////////////wAAAA8P////APAAAAD/////APAAD/////8AAAAAAP//////AAAAAAAP//AADw8PAAD/////AA8AAA///////wD////////////////wDw8ADwAA8PAPAAAA////APD/////DwD//w////APAAAA8A8PAA///////////wAAAA//////8AAA8P//////8PAADwAAAAD///////8ADwAA//////////8AAAAP/////////////wAPAA//////8AAAAAD/////AAAAD///////AAAA8P/////wAAAADw//////8AAAAAD/////AAAAAP//////////////////////////AAAPAA8PAAAADw8P///wDw//8PAAAA8P/wAP8ADwDw8PAPAA8P///////////wAAAAD/////8AAAAP//////8AAAD/AAAAD///////8AAADw///////////wAAAA/////////////wAAAA///////wAAAAD/////DwAPD///////AA8AAA////8AAAAPAP//////8AAAAPAP////AAAA///////////////////////////wDw8ADwAADw8PAPAP//8A8P//8ADw8PD//wDwAPAA8AAAAADwAA////////////AA8AAP////AADwD///////AAAPD/AADwD////////w8AAA//////////8AAAAP/////////////wAAAP///////wAPDwD/////AAAAD///////8PAAAP////8AAADwD/////////AAAAAA///wAA8AD//////////////////////////w8ADw8A8PAADwDwDwAAAPD///APAAAAAP/w8ADwDwAPDw8PAA8P////////////AAAAAP////AAAA////////AAAA//APAAAP//////8AAAAA//////////8AAPAP/////////////wAAAA////////AAAAD/////AAAAAP//////8AAAAP////AAAPAA//////////AA8AAA////AAAAD//////////////////////////wAPAAAPAA8PAA8AAA//8A///wDwDw8PD//wAPAA8A8P//AA8PAA////////////8PAA8P///wAA8P////////APAA//8AAAAP///////wAADw///////////wAAAP/////////////wAA8A///////wAAAAD/////8ADwD////////wAA8P////AA8AAP//////////8AAAAPD//wAAAAAP//////////////////////////DwDw8ADwAA8PAPD///8P///w8AAADw///wDwDwAPD/AA8PAADw/////////////wAAAA///wAPAP///////wAAAP//8AAAAP//////8AAAAA//////////8ADwAP/////////////wAAAA////////APAA//////AA8AD///////8AAAAP///wAAAAD////////////wAA8AD///APAPAP/////////////////////////wAA8ADw8A8PAAAA////AP//8AAA8PAA//8A8A8A8A8AAPDwDw8A/////////////wAAAA///wAAD////////wAAAA//8AAPAA///////wAPAA//////////8AAAAP/////////////wAAAA///////wAAAA//////AAAAAP//////8AAPAP///wAAAAD////////////wAAAAD///AAAAAAAP///////////////////////w8PAPAAAPAADw8P///wD///AA8P//////8PAAAPAP8PDwAA8AAP//////////////AA8AD/8ADwD////////wDwD////wDwAA//////8AAAAA///////////wAAAP/////////////wAPAA//////8AAAAP//////DwAAD///////8AAAD////wDwDwD////////////wDwAAD///AAAAAAAA///////////////////////wAADwDw8ADw8AD///8PAAAAAPAP//////8ADw8AD/AP8A8PAPDw//////////////AAAAD/8AAA////////8AAAAP///wAAAAD//////wAAAP//////////8ADwAP/////////////wAAAPD////wAAAA////////AAAAD///////AA8AD///8AAAAA//////////////AAAPD///8ADwDwAAAA//////////////////////Dw8A8ADw8AAPAP//8ADw8PDwAA//////APAAAPDwD/D/AAAAAA//////////////8AAAAPAAAP////////8AAAD////wAAAPD/////8ADwDw///////////wAADw/////////////wAAAADwAAAAAAD/D///////8AAPAP/////wAAAP/////wAAAAD////////////wAAAAAP//8AAAAAAPAAAP///////////////////wAPAAAPAAAP/w8P//APAAAAAA8PD////wAADw/w/w8A8P8PDw8P//////////////8A8A8PAAAP////////AAAAD////wAAAAD//////wAAAA//////////8AAAAP/////////////wAPAAAADwAAAAD/////////AADwD////wAAAAD/////8AAA8A//////////////AADwD/////AAAAAAAAAAD//////////////////w8ADw8ADw/wAA/wAADwDw8PDwAAAAAAAADw8P8A8ADwAAAAAPAA///////////////wAAAPAA//////////APDw//////DwDwAP////8AAAAA//////////8AAPAP/////////////wAAAPAAAAAA8A8AD///////AAAAAAAAAAAAAP//////8ADwAA//////////////AA8AAP////AA8A8AAAAAAA/////////////////wDw8AAPAAAPD/8ADwAA8AAAAA8PDwDw8A8ADwD/AA8PDw8PDwDw///////////////wAAAAAAD/////////AAAAD/////AAAAAP/////wAA8A///////////wDwAP/////////////wDwAAAPAADwAAAAAA//////APAAAAAAAAAAD///////8AAAAAD/////////////AAAAD//////wAAAAAA8AAA//////////////////AAAPDwDw/w/wDw8A8PAPDw8PAA8A8AAPAP8PAA8PD/APAA8AAA////////////////AA8ADw/////////wAAAA//////8AAAAP////8ADwAA//////////8AAAAP/////////////wAAAAAAAAAAAAAAAAD/////8AAAAAAAAAAPAA//////8A8AAA//////////////AAAAAP//////AAAA8AAADwAP///////////////wDw8AAA8PAA8A8AAAAAAAAPAADwAPAPDwDwDw/w8A/w/wDwAPDw////////////////AAAAAA/////////wDwAA//////AADwDw/////wAAAA///////////wAAAP/////////////wAAAPDw//8AAA8AAPAP////AAAPAAAAAAAAAAD/////8PAADw/////////////wAA8AD////////w8AAAAA8AAP///////////////w8AAPDwAPD/8PAPD//////wDw8A8AAAAA8A8AAPAPAA8AAA8AAP////////////////APAA8A////////8AAADwAAAAAAAAAAAA////8AAAAP//////////8AAAAP/////////////wAA8A///////wAADwAP////AAAAAPDwAA8AAAAP////8AAAAAD/////////////AAAAD/////////8AAA8AAAAA///////////////wAPDw//8PAAAP8AD///////AAAPAPDw8PAA8A8PDw//APDwDw8A////////////////8AAAAP////////8AAAAAAAAAAAAPAAAA/////wAAAA//////////8ADwAP/////////////wDwAA////////AAAAAA////8A8AD/////AADwAA/////wAAAAD////////////wAPAAD///////////8AAAAAAA////////////////DwAPAADwD//wAPD//////wDw8ADwAPAAAPAPD/AAAADwAPAADw////////////////AAAAAP////////8A8AAADwAAAAAAAA8AD///8ADw8A//////////8AAAD//////////////wAAAAD///////8A8AAA////AAAAAP////AAAADw////8AAA8AD////////////wAAAA//////////////AAAADw///////////////wAA8PD/8PDwAP8ADw/w8AAPAPAPAA8ADw//Dw/w8PDw8A8ADw8A////////////////8AAPAP////////AAAA8AAAAAAADwAPAAD////wAAAA//////////8A8AAP/////////////wAAAA////////8AAAAA////AAAA///////wAAAAD////wAAAA8P///////////wDwAAD/////////////8A8A8AD//////////////w8PAPAADwD/8AAPAAAAAPDwDwD///D///AAAP8PDw8AD///AAAP////////////////8A8AAP////////AAAAAA8ADwDwAAAAAAD////wAAAA//////////8AAAD//////////////wAADw/////////wAADw////APAAAP/////wDwAAD////wDwAAAP//////////8AAAAP///////////////wAAAAD//////////////wAADwD/8A/wDw//////////8A////////8PDwD/8PAP/w/wDw8A////////////////8AAAAP///////wAA8AD////////wDwAAAP///wAAAAD/////////AAAAAP/////////////wAPAA/////////wAAAA////AAAPD///////AADwAP///wAAAPAP//////////8A8AAA///////////////wAAAAD///////////////Dw8PAAAPAADw///////////w////////8P8P//Dw//AAAPAPAPD///////////////AAAAAP///////wAAAA//////////AAAA8P///wDwDwD/////////AAAPD//////////////wAAAAD///////8ADw8A////DwAAAP//////AAAAAP////AADwAA//////////AAAADw///////////////wAPAAD//////////////wAADwDwDw//8P//////////8A///w8P//8A8A8P//8ADw/wDwDw////////////////8AAA8P///////wDwAAD/////////AAAAAA////AAAAD/////////APAAD//////////////wAAAA////////8AAAAA////AAAAD///////8AAAAP////AAAAAAD////////wAAAAAP////////////////AAAA///////////////w8P8PAP8A8ADwD//w/w8PAPAPAAAAAP//APDw/w8A8PAP8A8A8A////////////////AADwAP//////8AAAAP//////////AADwAP////AAAAAP///////wAAAA///////////////wAAAA////////AAAAAA////AADwAP//////8A8A8A////8A8AAAAP//////8A8A8A/////////////////wAAAPD//////////////wDwDw/wAPAA8A8AAPAPAA/wDwDw8P/////w8PAPDwAA//8PAPAP////////////////8A8AAP//////8AAADw//////////8A8AAA////AADwAA//////8AAAAA//////////////8AAPDw///////wAPAAAP////AAAAD///////8AAAAA////8AAAAPAAD/////APAAAAD/////D/////////8AAA8A////////////////AA8AAA//DwAPAP////////AAAPD/8P//DwAA///wD/AADwDw//////////////////AAAAAP//////8ADwAA//////////8AAAAAD///8AAADwD/////AADwDw///////////////wAAAAD///DwAAAAAPD/////APAAAP///////wAAAAD////wAAAAAAAA8PAAAAAAAA//////AAAPD///DwAAAPAA///////////////wDwD/8PAPAPDwDw////////AP////////8A8PDw8A8ADw/wDwAA////////////////8AAAAP//////AAAAAP//////////8AAADw////8A8AAAAAAAAAAA8AAP///////////////wAAAAAAAAAAAAAAAAD/////AAAA8P///////wAAAAD/////AA8AAPAAAAAAAAAAD//////wAAAAAAAAAAAAAAAP////////////////AA8PD/Dw/w8A8P///////wD/////////APAP8A/w8P//APDw/w////////////////AA8AAP//////AAAAAP//////////8AAAAAD////wAAAAAAAAAAAAAAD///////////////8ADwAAAAAAAAAADwDw//////AAAPAP///////wAPDwAP////8AAAAAAPAAAPAAAA///////wAAAAAAAAAAAPDwAP///////////////w/wDwDw8AAAAP/wAAAAAAAA/////////w8ADwAP8AD/AA/w8A8P////////////////8AAA8P/////wAA8A8P///////////wDwAAAP////AADwAAAA8AAAAA/////////////////wAADwAAAAAADwAAD///////APAAD/////////AAAAD//////wAA8AAAAA8AAPDw///////wAAAAAAAAAAAAAAD////////////////wAPDw8PD/Dw//AA8P8P8PD/8A////8PAADw8PD/8P8ADw8A8PAPD///////////////AAAAAA/////wAAAAAP//////////8AAADwD/////8A8ADwAPAADwD//////////////////wAAAADwAAAPAAD/////////AAAAAP////////AAAAAA//////8AAADwAAAAAAAP///////wDwDw8AAAAPAAAP///////////////////w8A/wAP8A8A8PD///////AP//8AAA8PDwAA//DwAPDw8PAP/w////////////////APDwAP/////w8PAPD/////////////Dw8AAP//////AAAADwAAAA//////////////////8ADwAAAADwDwD///////////Dw8PD/////////Dw8PAP////////AA8AAPAADw/////////wAAAAAA8A8AAP///////////////////wDwAPAA8PAP8AAP////////Dw///w//Dw8P/w8P/////wDw/wAA///////////////////////////////////////////////////////////w8AAAAP//////////////////////////////////////////////////////////////////////////AAAAAP//////////////8AAPAPAP//////////////////////AP8A8P8PD/AP8A///////w8PD/8AAA8AAAAPDwDw8AAPDwDw///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w/wAPAPDwAADw//Dw8AAA8A8A//8P//AP//8AD/8PAP8A8A8PAP/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8A8AD/D/8P8ADwAAAPD/APDw//APAAD/AAAPAA8P/wD/AP8PDwD////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAAAP8AAA8A//8P8P//8PDw8P//DwDw8AD/DwD/8PAADwD/Dw8A//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////D/DwDw//D/AA8A////////Dw//8A8PD/8A8A//8A8P8P8A8PAP/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8P8PAA8A8AAPD/////////AA////DwAAD/D///8PAPAAD/DwD///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AADw//8PAP/w8A////////////////////////8AD/D/8A8A8A/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDwAA8A8A8PAA8P//8AAP//AAD/////////////APDw/wD/APDw/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8P//AAD/DwDwAA//8P8P//D/AA////////////DwDwAP8ADw8P/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDwAAAPAAD///Dw//DwD///AA/wAA/////////wAA8P8AAA8ADw//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////8A8P8ADw8A/wAP///////wD/AP/wAPD/////8PDwAA8PD/D/8A//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////APDwD/8AAPDw/wD///////8A8AAP/wAAAPAPDw8PDwDw8A8AAP/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wDw8A8ADw8PAP8A///////wD/D//wD//w/w/wAADw8A8PAPAPDw/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8PAPDw8AAA//AP///wDwAP8A8AAA8AAPAPAA//8ADw8PDw8PAA//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Dw/w8PAPD/AA//AP8A8PDwDw8P8P//8A/wD/AAAPAAAA8AAAD///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////APAAAA8AAADwAADwAP8ADw8PAADwAADwAA8AD/DwDw8PAP//8P//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////DwD///D/8PD///8PD/AP8PDwD/8P//AP8PAP8A8AAADwDwAADw///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8AAAAADw8PAAAA/wAADw8A8ADw8A8PDw/wDwAP/w8AAA8P8P///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////w8PDw//APDw8P//AAD/8PAPD/8PDwDwDwDw8P8AAPAPDwDw//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////8P8PAA/w8PD/AA///w8PDw8AD/8P8P8P8P8PD/8PDw8P8P////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////";
        public const string printerURL = @"http://PRINTERIPADDRESS/cgi-bin/epos/service.cgi?devid=local_printer&timeout=90000"; 
    }
}