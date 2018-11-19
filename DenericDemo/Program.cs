using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new DocumentManage<Document>();
            dm.AddDocument(new Document("Title A", "Sample A"));
            dm.AddDocument(new Document("Title B", "Sample B"));

            dm.DisplayAllDocuments();

            if (dm.IsDocumentAvaible)
            {
                Console.WriteLine(dm.GetDocument().Content);
            }
            string[] s = { "aaa", "bbb", "ccc" };

            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                ss.Append(s[i]+Convert.ToChar(9));
            }


            Console.WriteLine(ss.ToString());

            Console.ReadLine();
        }
    }
}
