using System;

namespace ReadWrightIni
{
    class Program
    {
        static void Main(string[] args)
        {
            INIFile settingsIni = new INIFile (@".\\Testdata.ini");
 
            string executionMode = settingsIni.Read ("BrowserName", "BrowserInfo").ToLower ();
            Console.WriteLine (executionMode);
 
            string WebdriverToUse = settingsIni.Read ("WebDriverLocation", "BrowserInfo").ToLower ();
            Console.WriteLine (WebdriverToUse);
            Console.WriteLine("Hello World!");

            settingsIni.Write("TimeOut","4000","BrowserInfo");

            string WebdriverToTimeOut = settingsIni.Read ("TimeOut", "BrowserInfo");
            Console.WriteLine (WebdriverToTimeOut);

            settingsIni.Write("BrowserName","IE","BrowserInfo");

            settingsIni.Write("URL","https://www.google.co.in/","AppUnderTest");


        }
    }
}
