using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorize.Model
{
    public enum TestType
    {
        Choice,
        Connector,
        Write
    }

    /// <summary>
    /// Статистика прохождения тестов
    /// </summary>
    public class TestStatistic
    {
        public TestStatistic()
        {
            testType = TestType.Choice;
            tryCount = 0;
            successCount = 0;
        }

        public TestStatistic(string name, int tryCount, int successCount)
        {
            switch (name)
            {
                case "choice": testType = TestType.Choice; break;
                case "connector": testType = TestType.Connector; break;
                case "write": testType = TestType.Write; break;
                default: testType = TestType.Choice; break;
            }

            this.tryCount = tryCount;
            this.successCount = successCount;
        }

        public TestStatistic(int testType)
        {
            switch(testType)
            {
                case 0: this.testType = TestType.Choice; break;
                case 1: this.testType = TestType.Connector; break;
                case 2: this.testType = TestType.Write; break;
                default: this.testType = TestType.Choice; break; 
            }
            this.tryCount = 0;
            this.successCount = 0;
        }

        public string TestName
        {
            get
            {
                string ret;
                switch (testType)
                {
                    case TestType.Choice: ret = "choice"; break;
                    case TestType.Connector: ret = "connector"; break;
                    case TestType.Write: ret = "write"; break;
                    default: ret = "choice"; break;
                }
                return ret;
            }
        }

        public override string ToString()
        {
            return TestName + ';' + tryCount.ToString() + ';' + successCount.ToString();
        }

        public int TryCount { get { return tryCount; } }
        public int SuccessCount { get { return successCount; } }
        public TestType GetTestType()
        {
            return testType;
        }

        private TestType testType;
        private int tryCount;
        private int successCount;
    }
}
