using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrueFalseEditor
{
    public class TrueFalse
    {

        #region Fields

        private string fileName;
        private List<Question> list;

        public string FileName
        {
            set { fileName = value; }
        }

        #endregion

        #region Constructors

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        #endregion

        #region Public Properties

        public Question this[int index]
        {
            get { return list[index]; }
        }

        public int Count
        {
            get 
            {
                if (list != null) return list.Count;
                else return 0;
            }
        }

        #endregion

        #region Public Methods

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0)
                list.RemoveAt(index);
        }

        public void Load()
        {
            if (File.Exists(fileName))
            {
                FileInfo fileInfo = new FileInfo(fileName);
                if (fileInfo.Length < 10485760) //10Mb
                {
                    try
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
                        using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                        {
                            list = (List<Question>)xmlSerializer.Deserialize(stream);
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("Не могу прочитать файл базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Слишком большой файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, list);
            }
        }

        public void Save(string newFileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (Stream stream = new FileStream(newFileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, list);
            }
            this.FileName = newFileName;
        }

        #endregion

    }
}
