using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wusing System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FILE
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\somefile.jpg", @"f:\myfile.jpg", true);
            //File.Delete(path);

            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            // FILEINFO
            var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("...", true);
            //fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            // OTHERS USE
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: {0}", Path.GetExtension(path));
            Console.WriteLine("FileName: {0}", Path.GetFileName(path));
            Console.WriteLine("FileNameNoExtension: {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("DirectoryName: {0}", Path.GetDirectoryName(path));

        }
    }
}
File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FILE
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\somefile.jpg", @"f:\myfile.jpg", true);
            //File.Delete(path);

            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            // FILEINFO
            var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("...", true);
            //fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            // OTHERS USE
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: {0}", Path.GetExtension(path));
            Console.WriteLine("FileName: {0}", Path.GetFileName(path));
            Console.WriteLine("FileNameNoExtension: {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("DirectoryName: {0}", Path.GetDirectoryName(path));

        }
    }
}
