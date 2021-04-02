namespace NWN.Framework.Lite.Enum
{
    public class AnimationType
    {
        public static readonly AnimationType Invalid = new(-1);
        // Looping animation constants.
        public static readonly AnimationType LoopingPause = new(0);
        public static readonly AnimationType LoopingPause2 = new (1);
        public static readonly AnimationType LoopingListen = new(2);
        public static readonly AnimationType LoopingMeditate = new(3);
        public static readonly AnimationType LoopingWorship = new(4);
        public static readonly AnimationType LoopingLookFar = new(5);
        public static readonly AnimationType LoopingSitChair = new(6);
        public static readonly AnimationType LoopingSitCross = new AnimationType(7);
        public static readonly AnimationType LoopingTalkNormal = new(8);
        public static readonly AnimationType LoopingTalkPleading = new(9);
        public static readonly AnimationType LoopingTalkForceful = new(10);
        public static readonly AnimationType LoopingTalkLaughing = new(11);
        public static readonly AnimationType LoopingGetLow = new(12);
        public static readonly AnimationType LoopingGetMid = new(13);
        public static readonly AnimationType LoopingPauseTired = new(14);
        public static readonly AnimationType LoopingPauseDrunk = new(15);
        public static readonly AnimationType LoopingDeadFront = new(16);
        public static readonly AnimationType LoopingDeadBack = new(17);
        public static readonly AnimationType LoopingConjure1 = new(18);
        public static readonly AnimationType LoopingConjure2 = new(19);
        public static readonly AnimationType LoopingSpasm = new(20);
        public static readonly AnimationType LoopingCustom1 = new(21);
        public static readonly AnimationType LoopingCustom2 = new(22);
        public static readonly AnimationType LoopingCustom3 = new(23);
        public static readonly AnimationType LoopingCustom4 = new(24);
        public static readonly AnimationType LoopingCustom5 = new(25);
        public static readonly AnimationType LoopingCustom6 = new(26);
        public static readonly AnimationType LoopingCustom7 = new(27);
        public static readonly AnimationType LoopingCustom8 = new(28);
        public static readonly AnimationType LoopingCustom9 = new(29);
        public static readonly AnimationType LoopingCustom10 = new(30);
        public static readonly AnimationType LoopingCustom11 = new(31);
        public static readonly AnimationType LoopingCustom12 = new(32);
        public static readonly AnimationType LoopingCustom13 = new(33);
        public static readonly AnimationType LoopingCustom14 = new(34);
        public static readonly AnimationType LoopingCustom15 = new(35);
        public static readonly AnimationType LoopingCustom16 = new(36);
        public static readonly AnimationType LoopingCustom17 = new(37);
        public static readonly AnimationType LoopingCustom18 = new(38);
        public static readonly AnimationType LoopingCustom19 = new(39);
        public static readonly AnimationType LoopingCustom20 = new(40);
        public static readonly AnimationType Mount1 = new(41);
        public static readonly AnimationType Dismount1 = new(42);

        // Fire and forget animation constants.
        public static readonly AnimationType FireForgetHeadTurnLeft = new(100);
        public static readonly AnimationType FireForgetHeadTurnRight = new(101);
        public static readonly AnimationType FireForgetPauseScratchHead = new(102);
        public static readonly AnimationType FireForgetPauseBored = new(103);
        public static readonly AnimationType FireForgetSalute = new(104);
        public static readonly AnimationType FireForgetBow = new(105);
        public static readonly AnimationType FireForgetSteal = new(106);
        public static readonly AnimationType FireForgetGreeting = new(107);
        public static readonly AnimationType FireForgetTaunt = new(108);
        public static readonly AnimationType FireForgetVictory1 = new(109);
        public static readonly AnimationType FireForgetVictory2 = new(110);
        public static readonly AnimationType FireForgetVictory3 = new(111);
        public static readonly AnimationType FireForgetRead = new(112);
        public static readonly AnimationType FireForgetDrink = new(113);
        public static readonly AnimationType FireForgetDodgeSide = new(114);
        public static readonly AnimationType FireForgetDodgeDuck = new(115);
        public static readonly AnimationType FireForgetSpasm = new(116);

        // Placeable animation constants
        public static readonly AnimationType PlaceableActivate = new(200);
        public static readonly AnimationType PlaceableDeactivate = new(201);
        public static readonly AnimationType PlaceableOpen = new(202);
        public static readonly AnimationType PlaceableClose = new(203);

        // Door animation constants
        public static readonly AnimationType DoorClose = new(204);
        public static readonly AnimationType DoorOpen1 = new(205);
        public static readonly AnimationType DoorOpen2 = new(206);
        public static readonly AnimationType DoorDestro7 = new(207);


        public int InternalValue { get; protected set; }

        public AnimationType(int internalValue)
        {
            InternalValue = internalValue;
        }

        public static explicit operator AnimationType(int internalValue) => new(internalValue);
    }
}