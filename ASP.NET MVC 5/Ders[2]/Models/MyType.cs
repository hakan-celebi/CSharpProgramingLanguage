using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ders_2_.Models
{
    public class MyType
    {
        private object[] AllValues { get; set; } = new object[0];
        private string[] AllKeys { get; set; } = new string[0];
        public object this[string name]
        {
            get
            {
                int i = 0;
                while (i < AllKeys.Length)
                {
                    if (AllKeys[i] == name)
                        return AllValues[i];
                    else
                        i++;
                }
                return null;
            }
            set
            {
                if (AllKeys.Length != 0)
                {
                    if (!AllKeys.Contains(name))
                    {
                        string[] newKeys = new string[AllKeys.Length + 1];
                        AllKeys.CopyTo(newKeys, 0);
                        newKeys[newKeys.Length - 1] = name;
                        AllKeys = new string[newKeys.Length];
                        newKeys.CopyTo(AllKeys, 0);

                        object[] newValues = new object[AllKeys.Length + 1];
                        AllValues.CopyTo(newValues, 0);
                        newValues[newKeys.Length - 1] = value;
                        AllValues = new object[newKeys.Length];
                        newValues.CopyTo(AllValues, 0);
                    }
                    else
                    {
                        int i = 0;
                        while (i < AllKeys.Length)
                        {
                            if (AllKeys[i] == name)
                                break;
                            else
                                i++;
                        }
                        AllValues[i] = value;
                    }
                }
                else
                {
                    AllKeys = new string[1] { name };
                    AllValues = new object[1] { value };
                }
            }
        }
    }
}