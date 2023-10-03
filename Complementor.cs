using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complement
{
    class Complementor
    {

        public  String doComplement(long number, long complement)
        {
            String result = "";
            String str = "";

            if (complement == 1)
            {
                while (number != 0)
                {
                    if (number % 10 == 0)
                    {
                        str += "1";
                    }
                    else
                    {
                        str += "0";
                    }
                    number /= 10;
                }

            }
            else if (complement == 2)
            {
                String isYak = "ni";
                while (number != 0)
                {
                    if (isYak.Equals("ni"))
                    {

                        str += (number % 10);
                        if (number % 10 == 1)
                            isYak = "bali";

                    }
                    else
                    {
                        if (number % 10 == 0)
                        {
                            str += "1";
                        }
                        else
                        {
                            str += "0";
                        }
                    }
                    number /= 10;
                }
            }




            for (int i = str.Length - 1; i >= 0; --i)
            {
                result += str[i];
            }
            return result;

        }

    }
}
