using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day2
{
    public class RockPaperScissorsStrategyDecrypt
    {
        public static RockPaperScissorsChoice DecryptOpponentChoice(string encryptedChoice)
        {
            return (encryptedChoice == "A") ? RockPaperScissorsChoice.Rock 
                : (encryptedChoice == "B") ? RockPaperScissorsChoice.Paper
                : (encryptedChoice == "C") ? RockPaperScissorsChoice.Scissors
                : RockPaperScissorsChoice.Unknown;
            
        }

        public static RockPaperScissorsChoice DecryptMyChoice(string encryptedChoice)
        {
            return (encryptedChoice == "X") ? RockPaperScissorsChoice.Rock
                : (encryptedChoice == "Y") ? RockPaperScissorsChoice.Paper
                : (encryptedChoice == "Z") ? RockPaperScissorsChoice.Scissors
                : RockPaperScissorsChoice.Unknown;
        }

        public static RoundEndingResult DecryptRequiredEnding(string encryptedRequiredEnding)
        {
            return (encryptedRequiredEnding == "X") ? RoundEndingResult.Lose
                    : (encryptedRequiredEnding == "Y") ? RoundEndingResult.Draw
                    : (encryptedRequiredEnding == "Z") ? RoundEndingResult.Win
                    : RoundEndingResult.Unknown;
        }

        public static RockPaperScissorsChoice CalculateChoiceFromRequiredEnding(RoundEndingResult requiredRroundEnding, RockPaperScissorsChoice opponentChoice)
        {
            if ((requiredRroundEnding == RoundEndingResult.Lose && opponentChoice == RockPaperScissorsChoice.Paper)
                || (requiredRroundEnding == RoundEndingResult.Draw && opponentChoice == RockPaperScissorsChoice.Rock)
                || (requiredRroundEnding == RoundEndingResult.Win && opponentChoice == RockPaperScissorsChoice.Scissors))
            { 
               return RockPaperScissorsChoice.Rock;
            }

            if ((requiredRroundEnding == RoundEndingResult.Lose && opponentChoice == RockPaperScissorsChoice.Scissors)
                || (requiredRroundEnding == RoundEndingResult.Draw && opponentChoice == RockPaperScissorsChoice.Paper)
                || (requiredRroundEnding == RoundEndingResult.Win && opponentChoice == RockPaperScissorsChoice.Rock))
            {
                return RockPaperScissorsChoice.Paper;
            }

            return RockPaperScissorsChoice.Scissors;

        }


        public static List<(RockPaperScissorsChoice opponentChoice, RockPaperScissorsChoice myChoice)> Decrypt(string[]? sourceData)
        {
            var returnValue = new List<(RockPaperScissorsChoice, RockPaperScissorsChoice)>();
            if (sourceData != null)
            {
                for (int i = 0; i < sourceData.Length; i++)
                {
                    var opponentEncryptedChoice = sourceData[i].Split(" ")[0];
                    var myEncryptedChoice = sourceData[i].Split(" ")[1];
                    returnValue.Add((DecryptOpponentChoice(opponentEncryptedChoice), DecryptMyChoice(myEncryptedChoice)));
                }
            }
            return returnValue;
        }

        public static List<(RockPaperScissorsChoice opponentChoice, RockPaperScissorsChoice myChoice)> DecryptAndCalculateNextChoice(string[]? sourceData)
        {
            var returnValue = new List<(RockPaperScissorsChoice, RockPaperScissorsChoice)>();
            if (sourceData != null)
            {
                for (int i = 0; i < sourceData.Length; i++)
                {
                    var opponentEncryptedChoice = sourceData[i].Split(" ")[0];
                    var encryptedEnding = sourceData[i].Split(" ")[1];
                    var decryptedOpponentChoice = DecryptOpponentChoice(opponentEncryptedChoice);
                    returnValue.Add((decryptedOpponentChoice, CalculateChoiceFromRequiredEnding(DecryptRequiredEnding(encryptedEnding), decryptedOpponentChoice)));
                }
            }
            return returnValue;
        }

        public enum RoundEndingResult
        {
            Lose = 'X',
            Draw = 'Y',
            Win = 'Z',
            Unknown
        }
    }
}
