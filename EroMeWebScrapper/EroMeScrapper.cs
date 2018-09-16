using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EroMeWebScrapper
{
    class EroMeScrapper
    {
        
        private WebClient WClient;
        public EroMeScrapper()
        {
            WClient = new WebClient();
            
        }

        public string InitScrapper(string URL)
        {
            WebClient WClient = new WebClient();
            return WClient.DownloadString(URL);
            
        }

        public List<string> GetLinks(string website)
        {
            website = website.Substring(website.IndexOf("<div id=\"album\""));
            int startIndex = website.LastIndexOf("class=\"clearfix\"");
            int endIndex = website.LastIndexOf(website);
            int length = endIndex - startIndex + 1;
            website = website.Remove(startIndex, website.Length - startIndex);
            //now put all the links in seperate strings.
            return website.Split(new string[] { "src=" }, StringSplitOptions.None).ToList();
            // -------------------------------------------------------------------------------->need to remove first string its trash
        }
        //cut out all the code before the class that handles the images and cut out after it

        public void ExtractLinks(List<string> links)
        {
            int startIndex = 0;
            //remove first one because that is allways stuff before the link
            links.RemoveAt(0);
            for (int i = 0; i < links.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(links[i]))
                {
                    
                    links.RemoveAt(i);
                    i--;
                    continue;
                }

                if (links[i].Contains(".jpeg"))
                {
                    startIndex = links[i].IndexOf(".jpeg") + 5;
                }
                else if (links[i].Contains(".mp4"))
                {
                    startIndex = links[i].IndexOf(".mp4") + 4;

                }
                else
                {
                    links.RemoveAt(i);
                    i--;
                    continue;
                }
                //delete all after link
                links[i] = links[i].Remove(startIndex, links[i].Length - startIndex);
                // removes the " at the start make later beeter code
                // links[i] = links[i].Remove(0, 1);
                links[i] = links[i].Replace("\"", "");
                links[i] = "https:" + links[i];
            }


            //remove every other link because they are a copy of each other


        }

        public bool DownloadLinks(List<string> links, string folder)
        {

           // folder 

            for (int i = 1; i < links.Count; i++)
            {

                string StoredName = links[i].Substring(links[i].LastIndexOf("/") + 1);
                //Console.WriteLine("DownloadLink: {0} and storedName: {1}", links[i], StoredName);
                WClient.DownloadFile(links[i], FileManager.CreateFolder(folder) + "\\" +  StoredName);
                
                
                
            }
            return true;
        }
        public bool DownloadLinks(string links, string folder)
        {
                string StoredName = links.Substring(links.LastIndexOf("/") + 1);
                //Console.WriteLine("DownloadLink: {0} and storedName: {1}", links[i], StoredName);
                WClient.DownloadFile(links, FileManager.CreateFolder(folder) + "\\" + StoredName);
            return true;
        }

    }
}



