using System;
using System.Collections.Generic;

namespace Uppgift3_4

//11. F: Varför är polymorfism viktigt att behärska?
//    S: Det är viktigt för att undvika att duplicera kod och att kunna återanvända den.
//12. F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
//    S: Bättre struktur, blir lättare att begripa och överblicka koden.
//13. F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
//    S: En abstrakt klass är en klass som man inte kan instansiera.
//       Ett interface är ett API till ett objekt. Man kan implementera ett interface 
//       hur många gånger man vill men en abstrakt klass kan bara ärva från en basklass.

{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> ue = new List<UserError>();
            ue.Add(new NumericInputError());
            ue.Add(new TextInputError());
            ue.Add(new NumericInputStatus());
            ue.Add(new TextToLongError());        

            foreach (UserError userError in ue)
            {
                Console.WriteLine(userError.UEMessage());
            }
        }
    }
}
