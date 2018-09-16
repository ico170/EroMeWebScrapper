using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EroMeWebScrapper
{
    class FileManager
    {

        //"D://randomFolderForCode//siterip//random//" + StoredName); //return it when done commented to not download all the time...
        // Specify a name for your top-level folder.
        /*
         private static string folderName = @"D:\randomFolderForCode\siterip";
         private static string endFolder = "random";
         private static string downloadFolder = System.IO.Path.Combine(folderName, endFolder);
         */
        public static string CreateFolder(string downloadFolder)
        {
            bool exists = System.IO.Directory.Exists(downloadFolder);
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(downloadFolder);
                //Console.WriteLine("doesnt exist");
            }
            /*else
            {
                Console.WriteLine("folder exists");

            }
            */

            return downloadFolder;
        }


    }
}

//requeres a \ at the end of filepath otherwise it downloads to the folder above it





/*
// Create the subfolder. You can verify in File Explorer that you have this
// structure in the C: drive.
//    Local Disk (C:)
//        Top-Level Folder
//            SubFolder
System.IO.Directory.CreateDirectory(pathString);

        // Create a file name for the file you want to create. 
        string fileName = System.IO.Path.GetRandomFileName();

// This example uses a random string for the name, but you also can specify
// a particular name.
//string fileName = "MyNewFile.txt";

// Use Combine again to add the file name to the path.
pathString = System.IO.Path.Combine(pathString, fileName);

        // Verify the path that you have constructed.
        Console.WriteLine("Path to my file: {0}\n", pathString);

        // Check that the file doesn't already exist. If it doesn't exist, create
        // the file and write integers 0 - 99 to it.
        // DANGER: System.IO.File.Create will overwrite the file if it already exists.
        // This could happen even with random file names, although it is unlikely.
        if (!System.IO.File.Exists(pathString))
        {
            using (System.IO.FileStream fs = System.IO.File.Create(pathString))
            {
                for (byte i = 0; i< 100; i++)
                {
                    fs.WriteByte(i);
                }
            }
        }
        else
        {
            Console.WriteLine("File \"{0}\" already exists.", fileName);
            return;
        }

        // Read and display the data from your file.
        try
        {
            byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
            foreach (byte b in readBuffer)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();
        }
        catch (System.IO.IOException e)
        {
            Console.WriteLine(e.Message);
        }

        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }*/
