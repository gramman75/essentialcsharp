using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter01
{
    interface ITest1
    {
        void Test1();
    }

    interface ITest2 : ITest1
    {
        void Test2();
    }
    class GInterface: ITest2
    {
        void ITest1.Test1()
        {

        }

        public void Test2()
        { 

        }

    }

    interface IReadableSettingsProvider
    {
        string GetSetting(string name, string defaultValue);
    }

    interface ISettingsProvider : IReadableSettingsProvider
    {
        void SetSetting(string name, string value);
    }

    public class FileSettingProvider : IReadableSettingsProvider, ISettingsProvider
    {

        // 명시적 구현시 해당 Member가 속해 있는 Interface
        // 명시적 구현시에는 Modifier사용 불가
        string IReadableSettingsProvider.GetSetting(string name, string defaultValue)
        {
            return "a";
        }

        public void SetSetting(string name, string value)
        {
        }

    }


        

}
