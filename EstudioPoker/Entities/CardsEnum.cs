using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioPoker.Entities
{
    public enum BlindsEnum
    {
        bbs25 = 25,
        bbs20 = 20,
        bbs12 = 12,
        bbs10 = 10,
        bbs8 = 8
    }

    public enum PositionEnum
    {
        Button,
        SmallBlind,
        BigBlind
    }

    public enum VersusEnum
    {
        HeroOpenRaise,
        SmallBlindOpenRaiseBigBlind,
        SmallBlindButtonLimp,
        SmallBlindButtonOpenRaise,
        SmallBlindButtonAllIn,
        BigBlindButtonOpenRaise_Fold,
        BigBlindButtonOpenRaise_Call,
        BigBlindButtonOpenRaise_3Bet,
        BigBlindButtonOpenRaise_AllIn,
        BigBlindButtonLimp_Fold,
        BigBlindButtonLimp_Call,
        BigBlindButtonLimp_3Bet,
        BigBlindButtonLimp_AllIn,
        BigBlindSmallBlindOpenRaise,
        BigBlindSmallBlindLimp,
        BigBlindSmallBlindAllIn,
        BigBlindButtonAllIn_Fold,
        BigBlindButtonAllIn_Call
    }

    public enum ActionEnum
    {
        OpenRaise4BetCall,
        OpenRaiseCallCall,
        OpenRaiseFoldFold,
        LimpCallFold,
        LimpFold,
        OpenShove
    }
}
