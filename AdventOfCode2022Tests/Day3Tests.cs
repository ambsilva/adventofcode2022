using AdventOfCode2022.Day2;
using static AdventOfCode2022.Day2.RockPaperScissorsStrategyDecrypt;

namespace AdventOfCode2022Tests.Day2
{
    //public class Rucksack_items_are
    //{
    //    [Fact]
    //    public void Evenly_divided_into_the_two_compartments_of_the_rucksack()
    //    {
    //        var 

    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Rock, RockPaperScissorsChoice.Scissors));
    //    }

    //    [Fact]
    //    public void If_goes_with_scissors_and_opponent_goes_with_paper()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Scissors, RockPaperScissorsChoice.Paper));
    //    }

    //    [Fact]
    //    public void If_goes_with_paper_and_opponent_goes_with_rock()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Paper, RockPaperScissorsChoice.Rock));
    //    }
    //}

    //public class Second_player_wins_rock_paper_scissors_game
    //{
    //    internal RockPaperScissorsPlayResult expectedResult = RockPaperScissorsPlayResult.IWin;

    //    [Fact]
    //    public void If_goes_with_rock_and_opponent_goes_with_scissors()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Scissors, RockPaperScissorsChoice.Rock));
    //    }

    //    [Fact]
    //    public void If_goes_with_scissors_and_opponent_goes_with_paper()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Paper, RockPaperScissorsChoice.Scissors));
    //    }

    //    [Fact]
    //    public void If_goes_with_paper_and_opponent_goes_with_rock()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Rock, RockPaperScissorsChoice.Paper));
    //    }
    //}

    //public class Rock_paper_scissors_game_is_a_draw
    //{
    //    internal RockPaperScissorsPlayResult expectedResult = RockPaperScissorsPlayResult.Draw;

    //    [Fact]
    //    public void If_both_players_go_with_rock()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Rock, RockPaperScissorsChoice.Rock));
    //    }

    //    [Fact]
    //    public void If_both_players_go_with_paper()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Paper, RockPaperScissorsChoice.Paper));
    //    }

    //    [Fact]
    //    public void If_both_players_go_with_scissors()
    //    {
    //        Assert.Equal(expectedResult, RockPaperScissorsGame.Play(RockPaperScissorsChoice.Scissors, RockPaperScissorsChoice.Scissors));
    //    }
    //}

    //public class Rock_paper_scissors_game_play_score_is
    //{
    //    [Fact]
    //    public void Zero_if_I_lose()
    //    {
    //        Assert.Equal(0, RockPaperScissorsGame.PlayScore(RockPaperScissorsPlayResult.OpponetWins));
    //    }

    //    [Fact]
    //    public void Three_if_its_a_draw()
    //    {
    //        Assert.Equal(3, RockPaperScissorsGame.PlayScore(RockPaperScissorsPlayResult.Draw));
    //    }

    //    [Fact]
    //    public void Six_if_I_win()
    //    {
    //        Assert.Equal(6, RockPaperScissorsGame.PlayScore(RockPaperScissorsPlayResult.IWin));
    //    }
    //}

    //public class Rock_paper_scissors_game_round_score_is
    //{
    //    [Theory]
    //    [InlineData(RockPaperScissorsChoice.Rock, RockPaperScissorsChoice.Rock, 4)]
    //    [InlineData(RockPaperScissorsChoice.Rock, RockPaperScissorsChoice.Paper, 8)]
    //    [InlineData(RockPaperScissorsChoice.Rock, RockPaperScissorsChoice.Scissors, 3)]
    //    [InlineData(RockPaperScissorsChoice.Paper, RockPaperScissorsChoice.Rock, 1)]
    //    [InlineData(RockPaperScissorsChoice.Paper, RockPaperScissorsChoice.Paper, 5)]
    //    [InlineData(RockPaperScissorsChoice.Paper, RockPaperScissorsChoice.Scissors, 9)]
    //    [InlineData(RockPaperScissorsChoice.Scissors, RockPaperScissorsChoice.Scissors, 6)]
    //    [InlineData(RockPaperScissorsChoice.Scissors, RockPaperScissorsChoice.Rock, 7)]
    //    [InlineData(RockPaperScissorsChoice.Scissors, RockPaperScissorsChoice.Paper, 2)]

    //    public void The_sum_of_the_play_score_plus_my_choice_score(RockPaperScissorsChoice opponentChoice, RockPaperScissorsChoice myChoice, int expectedScore)
    //    {
    //        Assert.Equal(expectedScore, RockPaperScissorsGame.RoundScore(opponentChoice, myChoice));
    //    }
    //}

    //public class Rock_paper_scissors_game_choice_points_are
    //{
    //    [Fact]
    //    public void One_for_rock()
    //    {
    //        Assert.Equal(1, RockPaperScissorsGame.ChoicePoints(RockPaperScissorsChoice.Rock));
    //    }

    //    [Fact]
    //    public void Two_for_paper()
    //    {
    //        Assert.Equal(2, RockPaperScissorsGame.ChoicePoints(RockPaperScissorsChoice.Paper));
    //    }

    //    [Fact]
    //    public void Three_for_scissors()
    //    {
    //        Assert.Equal(3, RockPaperScissorsGame.ChoicePoints(RockPaperScissorsChoice.Scissors));
    //    }
    //}


    //public class Decrypted_opponent_choice_is
    //{
    //    [Fact]
    //    public void Rock_if_the_encrypted_value_is_A()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Rock, RockPaperScissorsStrategyDecrypt.DecryptOpponentChoice("A"));
    //    }

    //    [Fact]
    //    public void Paper_if_the_encrypted_value_is_B()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Paper, RockPaperScissorsStrategyDecrypt.DecryptOpponentChoice("B"));
    //    }

    //    [Fact]
    //    public void Scissors_if_the_encrypted_value_is_C()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Scissors, RockPaperScissorsStrategyDecrypt.DecryptOpponentChoice("C"));
    //    }

    //    [Fact]
    //    public void Unknown_if_the_encrypted_value_is_not_A_or_B_or_C()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Unknown, RockPaperScissorsStrategyDecrypt.DecryptOpponentChoice("K"));
    //    }
    //}

    //public class My_decrypted_choice_is
    //{
    //    [Fact]
    //    public void Rock_if_the_encrypted_value_is_X()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Rock, RockPaperScissorsStrategyDecrypt.DecryptMyChoice("X"));
    //    }

    //    [Fact]
    //    public void Paper_if_the_encrypted_value_is_Y()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Paper, RockPaperScissorsStrategyDecrypt.DecryptMyChoice("Y"));
    //    }

    //    [Fact]
    //    public void Scissors_if_the_encrypted_value_is_Z()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Scissors, RockPaperScissorsStrategyDecrypt.DecryptMyChoice("Z"));
    //    }

    //    [Fact]
    //    public void Unknown_if_the_encrypted_value_is_not_X_or_Y_or_Z()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Unknown, RockPaperScissorsStrategyDecrypt.DecryptMyChoice("A"));
    //    }
    //}

    //public class My_next_choice_is_rock
    //{
    //    [Fact]
    //    public void If_the_required_ending_is_lose_and_opponent_choice_is_paper()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Rock, 
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Lose,RockPaperScissorsChoice.Paper));
    //    }

    //    [Fact]
    //    public void If_the_required_ending_is_draw_and_opponent_choice_is_rock()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Rock, 
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Draw, RockPaperScissorsChoice.Rock));
    //    }

    //    [Fact]
    //    public void If_the_required_ending_is_win_and_opponent_choice_is_scissors()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Rock,
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Win, RockPaperScissorsChoice.Scissors));
    //    }
    //}

    //public class My_next_choice_is_scissors
    //{
    //    [Fact]
    //    public void If_the_required_ending_is_lose_and_opponent_choice_is_rock()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Scissors,
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Lose, RockPaperScissorsChoice.Rock));
    //    }

    //    [Fact]
    //    public void If_the_required_ending_is_draw_and_opponent_choice_is_scissors()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Scissors,
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Draw, RockPaperScissorsChoice.Scissors));
    //    }

    //    [Fact]
    //    public void If_the_required_ending_is_win_and_opponent_choice_is_paper()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Scissors,
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Win, RockPaperScissorsChoice.Paper));
    //    }
    //}


    //public class My_next_choice_is_paper
    //{
    //    [Fact]
    //    public void If_the_required_ending_is_lose_and_opponent_choice_is_scissors()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Paper,
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Lose, RockPaperScissorsChoice.Scissors));
    //    }

    //    [Fact]
    //    public void If_the_required_ending_is_draw_and_opponent_choice_is_paper()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Paper,
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Draw, RockPaperScissorsChoice.Paper));
    //    }

    //    [Fact]
    //    public void If_the_required_ending_is_win_and_opponent_choice_is_rock()
    //    {
    //        Assert.Equal(RockPaperScissorsChoice.Paper,
    //            RockPaperScissorsStrategyDecrypt.CalculateChoiceFromRequiredEnding(RoundEndingResult.Win, RockPaperScissorsChoice.Rock));
    //    }
    //}


    //public class Required_end_result_is
    //{
    //    [Fact]
    //    public void Lose_if_encrypted_value_is_X()
    //    {
    //        Assert.Equal(RoundEndingResult.Lose, RockPaperScissorsStrategyDecrypt.DecryptRequiredEnding("X"));
    //    }

    //    [Fact]
    //    public void Draw_if_encrypted_value_is_Y()
    //    {
    //        Assert.Equal(RoundEndingResult.Draw, RockPaperScissorsStrategyDecrypt.DecryptRequiredEnding("Y"));
    //    }

    //    [Fact]
    //    public void Win_if_encrypted_value_is_Z()
    //    {
    //        Assert.Equal(RoundEndingResult.Win, RockPaperScissorsStrategyDecrypt.DecryptRequiredEnding("Z"));
    //    }

    //    [Fact]
    //    public void Unknown_if_encrypted_value_is_not_X_Y_or_Z()
    //    {
    //        Assert.Equal(RoundEndingResult.Unknown, RockPaperScissorsStrategyDecrypt.DecryptRequiredEnding("Q"));
    //    }
    //}

}
