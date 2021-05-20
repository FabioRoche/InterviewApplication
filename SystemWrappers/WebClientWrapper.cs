// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="WebClientWrapper.cs" company="Roche Diagnostics International Ltd">
//    Copyright (c) 2020 Roche Diagnostics International Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SystemWrappers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class WebClientWrapper : IWebClientWrapper
    {
        public IEnumerable<string> GetFiles(string folder)
        {
            return new string[] { @"http://MyServer/WebFile.txt", @"http://MyServer/WebFile2.txt", @"http://MyServer/WebFile3.txt" };
        }

        public string GetFileContent(string uri)
        {
            return "Content of web file: " + uri;
        }
    }
}