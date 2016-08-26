using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_T4
{
    class Shuffler
    {
        public string[,] Shuffle(string[,] input)
        {
            // Creates array for extra correct answer
            string[,] toShuffle = new string[input.GetLength(0), (input.GetLength(1) + 1)];

            // Loops through and copies the correct answer
            for (int i1 = 0; i1 < toShuffle.GetLength(0); i1++)
            {
                for (int i2 = 0; i2 < toShuffle.GetLength(1); i2++)
                {
                    if (i2 == 0 || i2 == 1)
                    {
                        toShuffle[i1, i2] = input[i1, i2];
                    }
                    else
                    {
                        toShuffle[i1, i2] = input[i1, (i2 - 1)];
                    }
                }
            }

            // Create random for shuffeling answers
            Random random = new Random();

            // Shuffles the answer alternatives
            for (int i1 = 0; i1 < toShuffle.GetLength(0); i1++)
            {
                // Creates array for answers to be shuffled
                string[] answerToShuffle = new string[toShuffle.GetLength(1) - 2];

                // Copies answers to be shuffled
                for (int i2 = 0; i2 < answerToShuffle.Length; i2++)
                {
                    answerToShuffle[i2] = toShuffle[i1, (i2 + 2)];
                }

                // Creates array for shuffled answers
                string[] answersShuffled = new string[answerToShuffle.Length];

                // Shuffles the answers
                answersShuffled = answerToShuffle.OrderBy(x => random.Next()).ToArray();

                // Copies the shuffled answers into the output array
                for (int i2 = 2; i2 < toShuffle.GetLength(1); i2++)
                {
                    toShuffle[i1, i2] = answersShuffled[i2 - 2];
                }
            }

            // Creates output array
            string[,] output = new string[toShuffle.GetLength(0), toShuffle.GetLength(1)];

            // Shuffles array
            for (int i = 0; i < output.GetLength(0); i++)
            {
                
            }
                        
            return output;
        }
    }
}
