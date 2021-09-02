using System;
using System.IO;
using System.Xml;

namespace ConsoleApp_ConfigurationCopyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Veeam_Software_C#\ConsoleApp_ConfigurationCopyFiles\ConsoleApp_ConfigurationCopyFiles\ConfigurationFilesCopy.xml");
            XmlElement xRoot = doc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 2)
                {
                    XmlNode source_path = xnode.Attributes.GetNamedItem("source_path");
                    XmlNode file_name = xnode.Attributes.GetNamedItem("file_name");
                    XmlNode destination_path = xnode.Attributes.GetNamedItem("destination_path");
                    try
                    {
                        File.Copy(Path.Combine(source_path.Value.ToString(), file_name.Value.ToString()), Path.Combine(destination_path.Value.ToString(), file_name.Value.ToString()), true);
                        Console.WriteLine("Файл " + file_name.Value + " перемещен");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Файл " + file_name.Value + " не найден");
                    }
                   
                }
            }
        }

    }
}
