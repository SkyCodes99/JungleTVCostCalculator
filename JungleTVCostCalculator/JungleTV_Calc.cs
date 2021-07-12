using System;

namespace JungleTVCostCalculator
{
    class JungleTV_Calc
    {
        static void Main(string[] args)
        {
            double videoLength = 0; //User enters the length of their video
            double lengthPenalty = 0; //Penalty assigned when video is a certain length
            double overallCost = 0;
            int queueLength = 0;
            int viewerCount;
            int queueSelection = 0;
            char skippable = ' ';

            Console.WriteLine("Enter the length of the video to the second (Ex. 10.31)");
            videoLength = Convert.ToDouble(Console.ReadLine());

            if (videoLength >= 25)
            {
                lengthPenalty = 100;
            }
            else if (videoLength >= 20)
            {
                lengthPenalty = 70;
            }
            else if (videoLength >= 17)
            {
                lengthPenalty = 50;
            }
            else if (videoLength >= 14)
            {
                lengthPenalty = 40;
            }
            else if (videoLength >= 10)
            {
                lengthPenalty = 20;
            }
            else if (videoLength >= 8)
            {
                lengthPenalty = 8;
            }
            else if (videoLength >= 4.5)
            {
                lengthPenalty = 4;
            }
            else
            {
                lengthPenalty = 0;
            }
            overallCost = videoLength + lengthPenalty;
            overallCost = Math.Round(overallCost, 2);

            Console.WriteLine("How many videos are in queue minus the one playing?");
            queueLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many active viewers are there?");
            viewerCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to make the video unskippable (Y or N)?");
            skippable = Convert.ToChar(Console.ReadLine());
            if(skippable == 'Y' || skippable == 'y')
            {
                overallCost = 0.5 * (1 + (queueLength / 10) + (viewerCount * 0.1) + lengthPenalty) * 19;
            }
            else if(skippable == 'N' || skippable == 'n')
            {
                overallCost = 0.5 * (1 + (queueLength / 10) + (viewerCount * 0.1) + lengthPenalty);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Which of the following are you wanting to queue at?\n1. Queue at the bottom\n2. Queue after the current video\n3. Skip current video and play");
            queueSelection = Convert.ToInt32(Console.ReadLine());
            if (queueSelection == 1)
            {
                overallCost = overallCost * 1;
            }
            else if (queueSelection == 2)
            {
                overallCost = overallCost * 3;
            }
            else if (queueSelection == 3)
            {
                overallCost = overallCost * 10;
            }
            Console.WriteLine($"The cost of your video is estimated to be {overallCost} BAN and the penalty was {lengthPenalty}");
        }
    }
}
