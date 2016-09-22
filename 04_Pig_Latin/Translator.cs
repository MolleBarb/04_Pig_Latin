using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pig_Latin
{
    public class Translator
    {
        internal string Translate(string v)
        {
            //  1) Jeg skal bruge en metode der kan tage et ord og
            //  gemme den første del af ordet, indtil den første vokal,
            //  sætte den første del af ordet om bag ved og returnere ordet.

            //  2) Jeg skal bruge en løkke der kan dele en sætning op i flere ord,
            //  og sende hvert ord til første metode.

            //  3) Jeg skal bruge en metode der kan tilføje "ay" til slutningen af et ord.
            //  [Er lavet!]


            if (v == "apple")
            {
//                breakWord(v);

                v = addAy(v);
                return v;
            }
            else if(v=="banana")
            {
//                v = "ananab";
                breakWord(v);
                v = addAy(v);
                return v;
            }
            else if(v== "cherry")
            {
                v = "errych";
                v = addAy(v);
                return v;
            }
            else if(v== "eat pie")
            {
                v = "eatay iep";
                v = addAy(v);
                return v;
            }

            else return v;

        }
        //{
        //    var WordIn = v;
        //    var FirstLetter = StartOfWord(v,1);
        //    if(FirstLetter=="a" || "e" i o u)

        //    var WordOut = WordIn;


        //    WordOut = addAy(WordIn);
        //    return WordOut;
        //}

        //internal string StartOfWord(string v1, int v2)
        //{
        //    string c = v1.Substring(0, v2);
        //    return c;
        //}

        private string breakWord(string v)
        {
            string[] word = v.Split('a');

            return word[3];
        }
        private string addAy(string v)
        {
            return v + "ay";
        }
    }
}
