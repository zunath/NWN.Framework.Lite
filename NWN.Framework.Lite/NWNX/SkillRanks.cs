using NWN.Framework.Lite.Enum;
using NWN.Framework.Lite.NWNX.Enum;

namespace NWN.Framework.Lite.NWNX
{
    public static class SkillRanks
    {
        private const string PLUGIN_NAME = "NWNX_SkillRanks";

        public static int GetSkillFeatCountForSkill(FeatType feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "GetSkillFeatCountForSkill");
            Internal.NativeFunctions.nwnxPushInt(feat.InternalValue);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static SkillFeat GetSkillFeatForSkillByIndex(FeatType feat, SkillType skill)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "GetSkillFeatForSkillByIndex");
            Internal.NativeFunctions.nwnxPushInt(feat.InternalValue);
            Internal.NativeFunctions.nwnxPushInt(skill.InternalValue);
            Internal.NativeFunctions.nwnxCallFunction();
            return new SkillFeat
            {
                skill = skill.InternalValue,
                feat = Internal.NativeFunctions.nwnxPopInt(),
                modifier = Internal.NativeFunctions.nwnxPopInt(),
                focusFeat = Internal.NativeFunctions.nwnxPopInt(),
                classes = Internal.NativeFunctions.nwnxPopString(),
                classLevelMod = Internal.NativeFunctions.nwnxPopFloat(),
                areaFlagsRequired = Internal.NativeFunctions.nwnxPopInt(),
                areaFlagsForbidden = Internal.NativeFunctions.nwnxPopInt(),
                dayOrNight = Internal.NativeFunctions.nwnxPopInt(),
                bypassArmorCheckPenalty = Internal.NativeFunctions.nwnxPopInt(),
                keyAbilityMask = Internal.NativeFunctions.nwnxPopInt()
            };
        }

        public static SkillFeat GetSkillFeat(FeatType feat, SkillType skill)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "GetSkillFeat");
            Internal.NativeFunctions.nwnxPushInt(feat.InternalValue);
            Internal.NativeFunctions.nwnxPushInt(skill.InternalValue);
            Internal.NativeFunctions.nwnxCallFunction();
            return new SkillFeat
            {
                skill = skill.InternalValue,
                feat = feat.InternalValue,
                modifier = Internal.NativeFunctions.nwnxPopInt(),
                focusFeat = Internal.NativeFunctions.nwnxPopInt(),
                classes = Internal.NativeFunctions.nwnxPopString(),
                classLevelMod = Internal.NativeFunctions.nwnxPopFloat(),
                areaFlagsRequired = Internal.NativeFunctions.nwnxPopInt(),
                areaFlagsForbidden = Internal.NativeFunctions.nwnxPopInt(),
                dayOrNight = Internal.NativeFunctions.nwnxPopInt(),
                bypassArmorCheckPenalty = Internal.NativeFunctions.nwnxPopInt(),
                keyAbilityMask = Internal.NativeFunctions.nwnxPopInt()
            };
        }

        public static void SetSkillFeat(SkillFeat skillFeat, bool createIfNonExistent = false)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "SetSkillFeat");
            Internal.NativeFunctions.nwnxPushInt(createIfNonExistent ? 1 : 0);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.keyAbilityMask);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.bypassArmorCheckPenalty);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.dayOrNight);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.areaFlagsForbidden);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.areaFlagsRequired);
            Internal.NativeFunctions.nwnxPushFloat(skillFeat.classLevelMod);
            // We only need to send the string from the point of the first set bit
            Internal.NativeFunctions.nwnxPushString(
                skillFeat.classes!.Substring(skillFeat.classes!.Length - skillFeat.classes!.IndexOf("1"),
                    skillFeat.classes.Length));
            Internal.NativeFunctions.nwnxPushInt(skillFeat.focusFeat);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.modifier);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.feat);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.skill);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void SetSkillFeatFocusModifier(int modifier, bool epicFocus = false)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "SetSkillFeatFocusModifier");
            Internal.NativeFunctions.nwnxPushInt(epicFocus ? 1 : 0);
            Internal.NativeFunctions.nwnxPushInt(modifier);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static int GetBlindnessPenalty()
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "GetBlindnessPenalty");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static void SetBlindnessPenalty(int modifier)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "SetBlindnessPenalty");
            Internal.NativeFunctions.nwnxPushInt(modifier);
            Internal.NativeFunctions.nwnxCallFunction();
        }


        public static int GetAreaModifier(uint area, SkillType skill)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "GetAreaModifier");
            Internal.NativeFunctions.nwnxPushInt(skill.InternalValue);
            Internal.NativeFunctions.nwnxPushObject(area);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static void SetAreaModifier(uint area, SkillType skill, int modifier)
        {
            Internal.NativeFunctions.nwnxSetFunction(PLUGIN_NAME, "SetAreaModifier");
            Internal.NativeFunctions.nwnxPushInt(modifier);
            Internal.NativeFunctions.nwnxPushInt(skill.InternalValue);
            Internal.NativeFunctions.nwnxPushObject(area);
            Internal.NativeFunctions.nwnxCallFunction();
        }
    }
}