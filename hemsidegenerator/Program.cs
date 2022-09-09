// See https://aka.ms/new-console-template for more information


// DATA FRÅN API
string[] techniques = {"C#", "daTAbaser", "WebbuTVeCkling", "clean Code"};


//STATSIK DATA
string start = "<!DOCTYPE html>\n<html>\n<body\n<main>\n";
string welcome = "<h1>\nVälkomna!\n</h1>\n";
string kurser = "";

foreach (string technique in techniques)
{
    string tmp = technique.Trim();
  
    kurser += "<p>" + tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower() + "</p>\n";


}



string end = "</body>\n</html>";


Console.WriteLine($"{start}{welcome}{kurser}{end}");

//string kurser = "Kurs om C#\n Kurs om databaser";