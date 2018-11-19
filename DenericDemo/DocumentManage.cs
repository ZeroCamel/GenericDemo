using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    /// <summary>
    /// 文件管理泛型类
    /// 增加约束-将T转换为IDocument
    /// where字句的一个重要限制 只能定义基类 接口 默认构造函数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DocumentManage<TDocument> where TDocument : IDocument
    {
        private readonly Queue<TDocument> documentQueue = new Queue<TDocument>();

        public void AddDocument(TDocument doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public bool IsDocumentAvaible
        {
            get { return documentQueue.Count > 0; }
        }

        public TDocument GetDocument()
        {
            //T doc = default(T);
            TDocument doc = default(TDocument);
            lock (this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach (var doc in documentQueue)
            {
                //Console.WriteLine(((IDocument)doc).Title);
                Console.WriteLine(doc.Title);
            }
        }
    }
}
