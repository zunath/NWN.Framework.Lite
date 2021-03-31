namespace NWN.Framework.Lite.Enum
{
    public class SkillType : NWEnumBase<int>
    {
        public static readonly SkillType Invalid = new(-1);
        public static readonly SkillType AnimalEmpathy = new(0);
        public static readonly SkillType Concentration = new(1);
        public static readonly SkillType DisableTrap = new(2);
        public static readonly SkillType Discipline = new(3);
        public static readonly SkillType Heal = new(4);
        public static readonly SkillType Hide = new(5);
        public static readonly SkillType Listen = new(6);
        public static readonly SkillType Lore = new(7);
        public static readonly SkillType MoveSilently = new(8);
        public static readonly SkillType OpenLock = new(9);
        public static readonly SkillType Parry = new(10);
        public static readonly SkillType Perform = new(11);
        public static readonly SkillType Persuade = new(12);
        public static readonly SkillType PickPocket = new(13);
        public static readonly SkillType Search = new(14);
        public static readonly SkillType SetTrap = new(15);
        public static readonly SkillType Spellcraft = new(16);
        public static readonly SkillType Spot = new(17);
        public static readonly SkillType Taunt = new(18);
        public static readonly SkillType UseMagicDevice = new(19);
        public static readonly SkillType Appraise = new(20);
        public static readonly SkillType Tumble = new(21);
        public static readonly SkillType CraftTrap = new(22);
        public static readonly SkillType Bluff = new(23);
        public static readonly SkillType Intimidate = new(24);
        public static readonly SkillType CraftArmor = new(25);
        public static readonly SkillType CraftWeapon = new(26);
        public static readonly SkillType Ride = new(27);
        public static readonly SkillType AllSkills = new(255);

        public SkillType(int internalValue) : base(internalValue) { }
    }
}