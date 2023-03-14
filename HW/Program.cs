using System.Linq;
using System.Text;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputS = "To be, or not to be, that is the question,\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\nNo more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep";
            string outputS = inputS.Replace("die", "***");
            Console.WriteLine(outputS);
            Console.WriteLine("Stat: " + (outputS.Split("***").Length-1));
            //================================================================================

            string inputS1 = "today is a good day for walking. i will try to walk near the sea";
            string[] inputM = inputS1.Split(". ");

            Console.WriteLine(inputS1);

            StringBuilder stringBuilder;        

            for (int i = 0; i < inputM.Length; i++)
            {
                stringBuilder = new StringBuilder(inputM[i]);
                stringBuilder[0] = Char.ToUpper(stringBuilder[0]);                
                
                inputM[i] =stringBuilder.ToString();                   
            } 

            Console.WriteLine(String.Join(". ", inputM));

        }
    }
}