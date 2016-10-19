using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Model
{
    /// <summary>
    /// Элемент словаря
    /// </summary>
    public class DictItem
    {
        public DictItem()
        {
            values = new List<string>();
            testStatistics = new List<TestStatistic>();
        }

        public string Caption { get; set; }

        public int ValuesCount { get { return values.Count; } }
        public int TestCount { get { return testStatistics.Count; } }
        public List<string> Values { get { return this.values; } }

        public string this[int index] 
        {
            get { return values[index]; }
        }
        
        public void UpdateValues(List<string> list)
        {
            values.Clear();
            for ( int i = 0; i < list.Count; i++)
            {
                values.Add(list[i]);
            }
        }

        public void Read(string inputData)
        {
            if (inputData.Length < 3)
                return;
            string[] parts = inputData.Split('=');
            Caption = parts[0].Trim();
            if (parts.Length > 1)
                ReadValues(parts[1]);

            if (parts.Length == 3)
            {
                ReadTestStatistics(parts[2]);
            }
            else
            {
                AddFakeTests();
            }
        }

        public void Write(System.IO.StreamWriter writer)
        {
            writer.Write(Caption);
            writer.Write("=");
            WriteValues(writer);
            writer.Write("=");
            WriteTestStatistics(writer);
            writer.WriteLine();
        }

        public void ReadValues(List<string> list)
        {
            values.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                values.Add(list[i]);
            }
        }

        public void AddTryToTest(bool isSuccess, string testName)
        {
            for (int i = 0; i < testStatistics.Count; i++)
            {
                if (testStatistics[i].GetTestName == testName)
                {
                    if (isSuccess)
                    {
                        testStatistics[i].AddSuccess();
                    }
                    else
                    {
                        testStatistics[i].AddFail();
                    }
                    break;
                }
            }
        }


        private void ReadValues(string line)
        {
            values.Clear();
            string[] items = line.Split('/');
            for (int i = 0; i < items.Length; i++)
            {
                values.Add(items[i].Trim());
            }        
        }
        
        private void WriteValues(System.IO.StreamWriter writer)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (i > 0)
                {
                    writer.Write("/");
                }
                writer.Write(values[i]);
            }
        }

        private void ReadTestStatistics(string line)
        {
            if (String.IsNullOrEmpty(line))
            {
                AddFakeTests();
                return;
            }

            string[] tests = line.Split('#');
            for ( int i = 0; i < tests.Length; i++)
            {
                ReadTest(tests[i]);
            }
        }

        private void WriteTestStatistics(System.IO.StreamWriter writer)
        {
            if (testStatistics.Count == 0)
            {
                AddFakeTests();
            }

            for (int i = 0; i < testStatistics.Count; i++)
            {
                if (i > 0)
                {
                    writer.Write("#");
                }
                writer.Write(testStatistics[i].ToString());
            }
        }

        private void AddFakeTests()
        {
            testStatistics.Add(new TestStatistic(0));
            testStatistics.Add(new TestStatistic(1));
            testStatistics.Add(new TestStatistic(2));
        }

        private void ReadTest(string line)
        {
            string[] parts = line.Split(';');
            if (parts.Length != 3)
                return;
            int tryCount = int.Parse(parts[1]);
            int successCount = int.Parse(parts[2]);
            TestStatistic ts = new TestStatistic(parts[0], tryCount, successCount);
            testStatistics.Add(ts);
        }

        //private string caption;
        private List<string> values;
        private List<TestStatistic> testStatistics;
    }
}
