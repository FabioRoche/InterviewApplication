using System;
using System.Collections.Generic;
using System.Text;

namespace SystemWrappers
{
    using System.Threading.Tasks;

    public interface IWebClientWrapper
    {
        IEnumerable<string> GetFiles(string serverFolder);

        string GetFileContent(string fileName);
    }
}
