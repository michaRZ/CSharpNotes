using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while(total != 50) // Expression that is either true or false
            {
                //Console.WriteLine(total);
                // total = total + 1                        // All these do the same thing
                // total += 1 (or 5 or 20 or whatever)
                // total++
                // total++;
                // Console.WriteLine(total++);


                Console.WriteLine(++total); // this will run output through 50, starting with outputting 2, so it will add 1 to the prev total before output
            }

            total = 0;
            while (true) // infinite loop (bc there's no actual expression to match here)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached!");
                    break; // allows the loop to break if condtion is met
                }
                total++;
            }


            Random rand = new Random();
            int someNumber;
            bool keepLooping = true;


            while (keepLooping)
            {
                someNumber = rand.Next(0, 20); // random number between 0 and 20 - inlcudes 0 as possibility, EXCLUDES 20 - includes min, excludes max

                if (someNumber == 0 || someNumber == 13) // if someNumber is 0 or 13
                {
                    continue; // this pushes the loop to run again without outputting 0 or 13; skips to the next loop iteration
                }

                Console.WriteLine(someNumber);
                
                if (someNumber == 15)
                {
                    keepLooping = false;
                }

            }

        }


        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 26;

            // 1 - starting point, do this once at the very beginning (the i can be anything, we just use i for 'index' typically. It is the Loop Control Variable _LCV))
            // 2 - loop condition, keep looping if this condition == true
            // 3 - do this after each loop
            // 4 - the code excuted very loop

                // 1        // 2               // 3
            for (int i = 0; i < studentCount; i++)  // 'i < studentCount'  excludes 26 from output; 'i <= studentCount' includes 26
            {
                //4
                Console.WriteLine(i);
            }


            // can use 'i' multiple times in same doc bc the variable 'i' only exists within the loop
            // if Nesting for loops, must use different var name 

                
            for (int i = 0; i < 100; i += 5)  // adds 5 each loop while condition == true
            {
                Console.WriteLine(i);
            }


            // an array of student names
            string[] students = { "Kristen", "Doug", "Jordan", "Mitch", "David", "Dinara" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class, {students[i]}"); // Interpolation with $  // pulls name from string array of all 6 students in array order, starting at index  0,  then 1, 2, 3, 4, 5
            }


            // foreach 
            // 1 - decalre the type
            // 2 - name the item
            // 3 - "in" keyword
            // 4 - the list

            //      // 1    // 2   // 3   //4
            foreach (string student in students) // works how it reads, very simple
            {
                Console.WriteLine(student); // will output all names of students in the list 'students'
            }


            string myName = "MichaelaNicoleRainesZuber";
            foreach (char letter in myName)
            {
                if (letter != 'e') // prints every char 'letter' except for 'e'
                {
                Console.WriteLine(letter); // same as if we wrote Console.Write(letter + "\n") 
                // Console.Write(letter); outputs myName exactly as written, letter-by-letter on the same line
                }
            }


        }

        [TestMethod]
        public void DoWhileLoops()
        {

            // Do While is like a while loop, but backwards
            // it will DO, then check for while conditional to see if it should keep running

            // int iterator = 0; // Will run 5 times
            int iterator = 15; // even tho 5 is less then 15, it will still loop once and output "Hello!" before checking the "while" conditional

            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            } while (iterator < 5);
        }


        [TestMethod]
        public void ConditionalsAndLoopsChallenge()
        {
            string maryPoppins = "Supercalifragilisticexpialidocious";

            foreach (char letter in maryPoppins)
            {
                if (letter == 'i')
                { 
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine("L");
                }
                else
                {
                    Console.WriteLine("Not an i or an l");
                }
            }

            int letterCount = 0;
            foreach (char letter in maryPoppins)
            {
                ++letterCount;
            }
            Console.WriteLine(letterCount);

            Console.WriteLine(maryPoppins.Length);
            
        }
    }
}
