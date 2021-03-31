namespace NWN.Framework.Lite.Enum
{
    public class CreatureType: NWEnumBase<int>
    {
        // the thing after CREATURE_TYPE_ should refer to the
        // actual "subtype" in the lists given above.
        public static readonly CreatureType RacialType = new(0);
        public static readonly CreatureType PlayerCharacter = new(1);
        public static readonly CreatureType Class = new(2);
        public static readonly CreatureType Reputation = new(3);
        public static readonly CreatureType IsAlive = new(4);
        public static readonly CreatureType HasSpellEffect = new(5);
        public static readonly CreatureType DoesNotHaveSpellEffect = new(6);
        public static readonly CreatureType Perception = new(7);

        public CreatureType(int internalValue) : base(internalValue)
        {
        }
    }
}