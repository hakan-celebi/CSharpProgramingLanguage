using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__OOP_Uygulama
{
    class Admin
    {
        string adminkadi1 = "hknclb58";

        string adminkadi2 = "apoaltnkynk42";

        string adminkadi3 = "emreblbn42";

        string adminkadi4 = "ysfclb58";

        string adminkadi5 = "mvldclb58";

        string _adminkadi;

        public string adminkadi
        {
            get
            {

                return _adminkadi;
            }
            set
            {
                if (value == adminkadi1 | value == adminkadi2 | value == adminkadi3 | value == adminkadi4 | value == adminkadi5)
                {
                    _adminkadi = value;
                }
                else
                {
                    _adminkadi = null;
                }
            }
        }

    }
}
