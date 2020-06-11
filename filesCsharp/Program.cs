using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:/myText";
            File.Copy(@"C:/file1", @"d:/file",true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo("..");
            fileInfo.CopyTo("..");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //]
            }
            Console.WriteLine(-------------------------------------);
            Directory.CreateDirectory(@"c:/temp/folfder");
            var files = Directory.GetFiles(@"c:/projects", "*.sln", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);
            //GetDirectorires
            var dir = Directory.GetDirectories(@"c:/projects", "*.*", SearchOption.AllDirectories);
            foreach(var di in dir)
                Console.WriteLine(di);

            var directoi = new DirectoryInfo("path");
            directoi.GetDirectories();
            //Path
            var path1 = @"c:/projects";
            Console.WriteLine("Extension"+Path.GetExtension(path1));
            Console.WriteLine("FileName"+ Path.GetFileName(path1));
            Console.WriteLine("File Name with out extension"+Path.GetFileNameWithoutExtension(path1));
            Console.WriteLine("Directory name"+Path.GetDirectoryName(path1));

        }
    }
}
