using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ConfigurationCopyFiles
{
    class GetFileData
    {
        public string Source_path { get; private set; }
        public string Destination_path { get; private set; }
        public string File_name { get; private set; }

        public GetFileData(string source_path, string destination_path, string file_name)
        {
            Source_path = source_path;
            Destination_path = destination_path;
            File_name = file_name;
        }

        public override string ToString()
        {
            return Source_path;
        }
    }
}
