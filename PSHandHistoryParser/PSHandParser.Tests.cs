using NUnit.Framework;

namespace PSHhParser.Tests
{
    public  class PSHandParserTests
    {
        [Test]
        public void ParseSingleHand_ShouldReturnCorrectResults()
        {

            var handText = @"PokerStars Hand #93405882771:  Hold'em No Limit ($0.10/$0.25 USD) - 2013/02/03 1:16:19 EET [2013/02/02 18:16:19 ET]
           Table 'Stobbe III' 6-max Seat #4 is the button
           Seat 1: VakaLuks ($26.87 in chips) 
           Seat 2: BigBlindBets ($29.73 in chips) 
           Seat 3: Jamol121 ($17.66 in chips) 
           Seat 4: ubbikk ($26.06 in chips) 
           Seat 5: RicsiTheKid ($25 in chips) 
           Seat 6: angrypaca ($26.89 in chips) 
           RicsiTheKid: posts small blind $0.10
           angrypaca: posts big blind $0.25
           *** HOLE CARDS ***
           Dealt to angrypaca [6d As]
           VakaLuks: folds 
           BigBlindBets: folds 
           Jamol121: calls $0.25
           ubbikk: folds 
           RicsiTheKid: folds 
           angrypaca: checks 
           *** FLOP *** [5s Qs 3c]
           angrypaca: checks 
           Jamol121: checks 
           *** TURN *** [5s Qs 3c] [8d]
           angrypaca: checks 
           Jamol121: bets $0.25
           angrypaca: folds 
           Uncalled bet ($0.25) returned to Jamol121
           Jamol121 collected $0.57 from pot
           *** SUMMARY ***
           Total pot $0.60 | Rake $0.03 
           Board [5s Qs 3c 8d]
           Seat 1: VakaLuks folded before Flop (didn't bet)
           Seat 2: BigBlindBets folded before Flop (didn't bet)
           Seat 3: Jamol121 collected ($0.57)
           Seat 4: ubbikk (button) folded before Flop (didn't bet)
           Seat 5: RicsiTheKid (small blind) folded before Flop
           Seat 6: angrypaca (big blind) folded on the Turn";

            // act
            var result = PSHandParser.ParseHand(handText);

            // assert / вывод
            TestContext.WriteLine($"Hand #{result.handNumber}");
            foreach (var player in result.playerInfos)
            {
                TestContext.WriteLine($"Seat {player.seatNumber}: {player.nickName}");
            }

            Assert.That(result.playerInfos.Count, Is.EqualTo(6));
        }
    }
}