using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class AdvanceCSharpTest
    {
        public void test()
        {
            string folderPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString()+"/Data";
            MainProcess mainProcess = new MainProcess();
            mainProcess.findInFile("trang", folderPath+"/data.txt");
        }
    }
}
