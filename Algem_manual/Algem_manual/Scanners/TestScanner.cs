using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algem_manual.Scanners
{
    class TestScanner
    {
        private string path;

        public TestScanner(string startDirectory)
        {
            path = startDirectory;
        }

        public void TestWrite()
        {
            Tuple<Type, Object> answers = new Tuple<Type, object>(typeof(String), "This is first line");
            FileStream fs = new FileStream("Answers.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(fs, answers);

                answers = new Tuple<Type, object>(typeof(int), 789);
                formatter.Serialize(fs, answers);

                answers = new Tuple<Type, object>(typeof(double), 13.33);
                formatter.Serialize(fs, answers);
            }
            catch (SerializationException e)
            {
                Logs.WriteLine("Ошибка сериализации. Подробности: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public void TestRead()
        {
            Tuple<Type, Object> temp;
            FileStream fs = new FileStream("Answers.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            BinaryReader binReader = new BinaryReader(fs);

            try
            {
                temp = (Tuple<Type, Object>)formatter.Deserialize(fs);
                MessageBox.Show( temp.Item2.ToString() );
            }
            catch (SerializationException e)
            {
                Logs.WriteLine("Ошибка сериализации. Подробности: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
