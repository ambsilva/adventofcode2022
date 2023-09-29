using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day2
{
    public class RockPaperScissorsGame
    {
        public static RockPaperScissorsPlayResult Play(RockPaperScissorsChoice opponentChoice, RockPaperScissorsChoice myChoice)
        {
            if (opponentChoice == myChoice) return RockPaperScissorsPlayResult.Draw;

            if ((opponentChoice == RockPaperScissorsChoice.Rock && myChoice == RockPaperScissorsChoice.Scissors)
               || (opponentChoice == RockPaperScissorsChoice.Scissors && myChoice == RockPaperScissorsChoice.Paper)
               || (opponentChoice == RockPaperScissorsChoice.Paper && myChoice == RockPaperScissorsChoice.Rock)
               )
            {
                return RockPaperScissorsPlayResult.OpponetWins;
            }
            else
            {
                return RockPaperScissorsPlayResult.IWin;
            }
        }

        public static int PlayScore(RockPaperScissorsPlayResult playResult)
        {
            return (int)playResult;
        }

        public static int ChoicePoints(RockPaperScissorsChoice choice)
        {
            return (int)choice;
        }

        public static int RoundScore(RockPaperScissorsChoice opponentChoice, RockPaperScissorsChoice myChoice)
        {
            return PlayScore(RockPaperScissorsGame.Play(opponentChoice, myChoice)) + ChoicePoints(myChoice);
        }

    }

    public enum RockPaperScissorsChoice
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3,
        Unknown
    }

    public enum RockPaperScissorsPlayResult
    {
        OpponetWins = 0,
        IWin = 6,
        Draw = 3
    }
}
