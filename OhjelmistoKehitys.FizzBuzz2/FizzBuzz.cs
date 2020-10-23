using System;

namespace OhjelmistoKehitys.FizzBuzz2
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string Luku(int syöte)
        {
            if (OnkoJaollinenViidellätoista(syöte))
            {
                return "FizzBuzz";
            }

            if (OnkoJaollinenKolmella(syöte))
            {
                return "Fizz";
            }

            if (OnkoJaollinenViidellä(syöte))
            {
                return "Buzz";
            }


            return syöte.ToString();
        }

        private bool OnkoJaollinenViidellätoista(int syöte)
        {
            return OnkoJaollinenKolmella(syöte) && OnkoJaollinenViidellä(syöte);
        }

        private bool OnkoJaollinenKolmella(int syöte)
        {
            return syöte % 3 == 0;
        }

        private bool OnkoJaollinenViidellä(int syöte)
        {
            return syöte % 5 == 0;
        }
    }
}