using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

// Create new datatype and allocate memory
[StructLayout(LayoutKind.Explicit)]
public struct AbilityScore
{
    [FieldOffset(0)]
    public int roll1;

    [FieldOffset(4)]
    public int roll2;

    [FieldOffset(8)]
    public int roll3;

    [FieldOffset(12)]
    public int roll4;

    [FieldOffset(24)]
    public int ability_score;
}


namespace StatRollerApp
{
    class MainProgram
    {
        class RollScores
        {
            public static void Main()
            {
                AbilityScore Strength;
                AbilityScore Dexterity;
                AbilityScore Constitution;
                AbilityScore Intelligence;
                AbilityScore Wisdom;
                AbilityScore Charisma;

                Random rnd = new Random();

                // Strength rolls
                Strength.roll1 = rnd.Next(1, 7);
                Strength.roll2 = rnd.Next(1, 7);
                Strength.roll3 = rnd.Next(1, 7);
                Strength.roll4 = rnd.Next(1, 7);

                // Creates array holding results
                int[] StrList = { Strength.roll1, Strength.roll2, Strength.roll3, Strength.roll4 };
                string StrStr = string.Join(", ", StrList);


                // Sorts array and creates new array with final values:
                Array.Sort(StrList);

                // Sums the three highest values
                Strength.ability_score = 0;
                for (int i = 1; i < 4; i++)
                {
                    Strength.ability_score += StrList[i];
                }


                // Dexterity rolls
                Dexterity.roll1 = rnd.Next(1, 7);
                Dexterity.roll2 = rnd.Next(1, 7);
                Dexterity.roll3 = rnd.Next(1, 7);
                Dexterity.roll4 = rnd.Next(1, 7);

                // Creates array holding results
                int[] DexList = { Dexterity.roll1, Dexterity.roll2, Dexterity.roll3, Dexterity.roll4 };
                string DexStr = string.Join(", ", DexList);

                // Sorts array and creates new array with final values:
                Array.Sort(DexList);

                // Sums the three highest values
                Dexterity.ability_score = 0;
                for (int i = 1; i < 4; i++)
                {
                    Dexterity.ability_score += DexList[i];
                }

                // Constitution rolls
                Constitution.roll1 = rnd.Next(1, 7);
                Constitution.roll2 = rnd.Next(1, 7);
                Constitution.roll3 = rnd.Next(1, 7);
                Constitution.roll4 = rnd.Next(1, 7);

                // Creates array holding results
                int[] ConList = { Constitution.roll1, Constitution.roll2, Constitution.roll3, Constitution.roll4 };
                string ConStr = string.Join(", ", ConList);


                // Sorts array and creates new array with final values:
                Array.Sort(ConList);

                // Sums the three highest values
                Constitution.ability_score = 0;
                for (int i = 1; i < 4; i++)
                {
                    Constitution.ability_score += ConList[i];
                }


                /* Intelligence rolls */
                Intelligence.roll1 = rnd.Next(1, 7);
                Intelligence.roll2 = rnd.Next(1, 7);
                Intelligence.roll3 = rnd.Next(1, 7);
                Intelligence.roll4 = rnd.Next(1, 7);

                // Creates array holding results
                int[] IntList = { Intelligence.roll1, Intelligence.roll2, Intelligence.roll3, Intelligence.roll4 };
                string IntStr = string.Join(", ", IntList);


                // Sorts array and creates new array with final values:
                Array.Sort(IntList);

                // Sums the three highest values
                Intelligence.ability_score = 0;
                for (int i = 1; i < 4; i++)
                {
                    Intelligence.ability_score += ConList[i];
                }


                // Wisdom rolls 
                Wisdom.roll1 = rnd.Next(1, 7);
                Wisdom.roll2 = rnd.Next(1, 7);
                Wisdom.roll3 = rnd.Next(1, 7);
                Wisdom.roll4 = rnd.Next(1, 7);

                // Creates array holding results
                int[] WisList = { Wisdom.roll1, Wisdom.roll2, Wisdom.roll3, Wisdom.roll4 };
                string WisStr = string.Join(", ", WisList);


                // Sorts array and creates new array with final values:
                Array.Sort(WisList);

                // Sums the three highest values
                Wisdom.ability_score = 0;
                for (int i = 1; i < 4; i++)
                {
                    Wisdom.ability_score += WisList[i];
                }

                // Charisma rolls
                Charisma.roll1 = rnd.Next(1, 7);
                Charisma.roll2 = rnd.Next(1, 7);
                Charisma.roll3 = rnd.Next(1, 7);
                Charisma.roll4 = rnd.Next(1, 7);

                // Creates array holding results
                int[] ChaList = { Charisma.roll1, Charisma.roll2, Charisma.roll3, Charisma.roll4 };
                string ChaStr = string.Join(", ", ChaList);

                // Sorts array and creates new array with final values:
                Array.Sort(ChaList);

                // Sums the three highest values
                Charisma.ability_score = 0;
                for (int i = 1; i < 4; i++)
                {
                    Charisma.ability_score += ChaList[i];
                }

                if (Strength.ability_score + Dexterity.ability_score + Constitution.ability_score + Intelligence.ability_score + Wisdom.ability_score + Charisma.ability_score < 63)
                {
                    Main();
                }
                else
                {
                    // Strength Output
                    Console.WriteLine("Initial Strength Rolls: " + StrStr);
                    Console.WriteLine("Strength Score:" + Strength.ability_score + "\n");

                    // Dexterity Output
                    Console.WriteLine("Initial Dexterity Rolls: " + DexStr);
                    Console.WriteLine("Dexterity Score:" + Dexterity.ability_score + "\n");

                    // Constitution Output
                    Console.WriteLine("Initial Constitution Rolls: " + ConStr);
                    Console.WriteLine("Constitution Score:" + Constitution.ability_score + "\n");

                    // Intelligence
                    Console.WriteLine("Initial Intelligence Rolls: " + IntStr);
                    Console.WriteLine("Intelligence Score:" + Intelligence.ability_score + "\n");

                    // Wisdom
                    Console.WriteLine("Initial Wisdom Rolls: " + WisStr);
                    Console.WriteLine("Wisdom Score:" + Wisdom.ability_score + "\n");

                    // Charisma
                    Console.WriteLine("Initial Charisma Rolls: " + ChaStr);
                    Console.WriteLine("Charisma Score:" + Charisma.ability_score + "\n");


                    Console.WriteLine("Press enter to close ");
                    global::System.Object value = Console.ReadLine();
                }



            }




        }


    }
}
