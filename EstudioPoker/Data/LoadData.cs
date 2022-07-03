using EstudioPoker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioPoker.Data
{
    public class LoadData
    {
        public List<Cards> LoadCards()
        {
            var cards = new List<Cards>();

            cards.Add(new Cards { Pareja = "AA", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaise4BetCall, Suited = false });
            cards.Add(new Cards { Pareja = "AK", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenShove, Suited = false });
            cards.Add(new Cards { Pareja = "AK", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseCallCall, Suited = true });
            cards.Add(new Cards { Pareja = "AQ", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenShove, Suited = false });
            cards.Add(new Cards { Pareja = "AQ", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseCallCall, Suited = true });
            cards.Add(new Cards { Pareja = "AJ", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaise4BetCall, Suited = false });
            cards.Add(new Cards { Pareja = "AJ", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseCallCall, Suited = true });
            cards.Add(new Cards { Pareja = "AT", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaise4BetCall, Suited = false });
            cards.Add(new Cards { Pareja = "AT", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseCallCall, Suited = true });
            cards.Add(new Cards { Pareja = "A9", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A9", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseCallCall, Suited = true });
            cards.Add(new Cards { Pareja = "A8", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A8", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = true });
            cards.Add(new Cards { Pareja = "A7", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A7", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = true });
            cards.Add(new Cards { Pareja = "A6", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A6", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = true });
            cards.Add(new Cards { Pareja = "A5", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A5", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = true });
            cards.Add(new Cards { Pareja = "A4", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A4", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = true });
            cards.Add(new Cards { Pareja = "A3", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A3", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = true });
            cards.Add(new Cards { Pareja = "A2", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = false });
            cards.Add(new Cards { Pareja = "A2", Blinds = BlindsEnum.bbs25, Postion = PositionEnum.BigBlind, Versus = VersusEnum.HeroOpenRaise, HeroAction = ActionEnum.OpenRaiseFoldFold, Suited = true });

            return cards;
        }

    }
}
