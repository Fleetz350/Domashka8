using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dz8._2
{
    

    public class TrueFalse
    {
        private string fileName;
        private List<Question> list;


        public Question this[int index]
        {
            get { return list[index]; }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public TrueFalse(string filename)
        {
            this.fileName = filename;
            list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }


        public void Remove (int index)
        {
            if (index >= 0 && index < list.Count) list.RemoveAt(index);
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                list = (List<Question>)xmlSerializer.Deserialize(fileStream);
            }
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, list);
            }
        }
        public void SaveAs(string newFileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (var fileStream = new FileStream(newFileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, list);
            }
        }


    }
}
