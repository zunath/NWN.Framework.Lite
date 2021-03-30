﻿
namespace NWN.Framework.Lite.NWNX
{
    public static class NWNXCore
    {
        private static string NWNX_INTERNAL_BuildString(string pluginName, string functionName, string operation)
        {
            return "NWNXEE!ABIv2!" + pluginName + "!" + functionName + "!" + operation;
        }

        public static void NWNX_CallFunction(string pluginName, string functionName)
        {
            NWScript.PlaySound(NWNX_INTERNAL_BuildString(pluginName, functionName, "CALL"));
        }

        public static void NWNX_PushArgumentInt(string pluginName, string functionName, int value)
        {
            NWScript.SetLocalInt(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "PUSH"), value);
        }

        public static void NWNX_PushArgumentFloat(string pluginName, string functionName, float value)
        {
            NWScript.SetLocalFloat(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "PUSH"), value);
        }

        public static void NWNX_PushArgumentObject(string pluginName, string functionName, uint value)
        {
            NWScript.SetLocalObject(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "PUSH"), value);
        }

        public static void NWNX_PushArgumentString(string pluginName, string functionName, string value)
        {
            NWScript.SetLocalString(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "PUSH"), value);
        }

        public static void NWNX_PushArgumentEffect(string pluginName, string functionName, Lite.Effect value)
        {
            NWScript.TagEffect(value, NWNX_INTERNAL_BuildString(pluginName, functionName, "PUSH"));
        }

        public static void NWNX_PushArgumentItemProperty(string pluginName, string functionName, Lite.ItemProperty value)
        {
            NWScript.TagItemProperty(value, NWNX_INTERNAL_BuildString(pluginName, functionName, "PUSH"));
        }

        public static int NWNX_GetReturnValueInt(string pluginName, string functionName)
        {
            return NWScript.GetLocalInt(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "POP"));
        }

        public static float NWNX_GetReturnValueFloat(string pluginName, string functionName)
        {
            return NWScript.GetLocalFloat(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "POP"));
        }

        public static uint NWNX_GetReturnValueObject(string pluginName, string functionName)
        {
            return NWScript.GetLocalObject(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "POP"));
        }

        public static string NWNX_GetReturnValueString(string pluginName, string functionName)
        {
            return NWScript.GetLocalString(NWScript.OBJECT_INVALID, NWNX_INTERNAL_BuildString(pluginName, functionName, "POP"));
        }

        public static Lite.Effect NWNX_GetReturnValueEffect(string pluginName, string functionName)
        {
            var e = NWScript.EffectBlindness();
            return NWScript.TagEffect(e, NWNX_INTERNAL_BuildString(pluginName, functionName, "POP"));
        }

        public static Lite.ItemProperty NWNX_GetReturnValueItemProperty(string pluginName, string functionName)
        {
            var ip = NWScript.ItemPropertyTrueSeeing();
            return NWScript.TagItemProperty(ip, NWNX_INTERNAL_BuildString(pluginName, functionName, "POP"));
        }
    }
}
