namespace NWN.Framework.Lite.Enum
{
    public class DiseaseType: NWEnumBase<int>
    {
        // these constants match those in disease.2da
        public static readonly DiseaseType Blinding_Sickness = new(0);
        public static readonly DiseaseType Cackle_Fever = new(1);
        public static readonly DiseaseType Devil_Chills = new(2);
        public static readonly DiseaseType Demon_Fever = new(3);
        public static readonly DiseaseType Filth_Fever = new(4);
        public static readonly DiseaseType Mindfire = new(5);
        public static readonly DiseaseType Mummy_Rot = new(6);
        public static readonly DiseaseType Red_Ache = new(7);
        public static readonly DiseaseType Shakes = new(8);
        public static readonly DiseaseType Slimy_Doom = new(9);
        public static readonly DiseaseType Red_Slaad_Eggs = new(10);
        public static readonly DiseaseType Ghoul_Rot = new(11);
        public static readonly DiseaseType Zombie_Creep = new(12);
        public static readonly DiseaseType Dread_Blisters = new(13);
        public static readonly DiseaseType Burrow_Maggots = new(14);
        public static readonly DiseaseType Soldier_Shakes = new(15);
        public static readonly DiseaseType Vermin_Madness = new(16);

        public DiseaseType(int internalValue) : base(internalValue)
        {
        }

        public static explicit operator DiseaseType(int internalValue) => new(internalValue);
    }
}