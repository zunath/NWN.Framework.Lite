using System;
using NWN.Framework.Lite.NWNX.Enum;

namespace NWN.Framework.Lite.NWNX
{
    public static class Administration
    {
        private const string NWNX_Administration = "NWNX_Administration";

        public static string GetPlayerPassword()
        {
            var sFunc = "GetPlayerPassword";

            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
            return NWNXCore.NWNX_GetReturnValueString();
        }

        public static void SetPlayerPassword(string password)
        {
            var sFunc = "SetPlayerPassword";

            NWNXCore.NWNX_PushArgumentString(password);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static void ClearPlayerPassword()
        {
            var sFunc = "ClearPlayerPassword";

            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static string GetDMPassword()
        {
            var sFunc = "GetDMPassword";

            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
            return NWNXCore.NWNX_GetReturnValueString();
        }

        public static void SetDMPassword(string password)
        {
            var sFunc = "SetDMPassword";

            NWNXCore.NWNX_PushArgumentString(password);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static void ShutdownServer()
        {
            var sFunc = "ShutdownServer";

            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static void DeletePlayerCharacter(uint oPC, bool bPreserveBackup = true, string sKickMessage = "")
        {
            var sFunc = "DeletePlayerCharacter";

            NWNXCore.NWNX_PushArgumentString(sKickMessage);
            NWNXCore.NWNX_PushArgumentInt(bPreserveBackup ? 1 : 0);
            NWNXCore.NWNX_PushArgumentObject(oPC);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static void AddBannedIP(string ip)
        {
            var sFunc = "AddBannedIP";

            NWNXCore.NWNX_PushArgumentString(ip);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }
        public static void RemoveBannedIP(string ip)
        {
            var sFunc = "RemoveBannedIP";

            NWNXCore.NWNX_PushArgumentString(ip);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }
        public static void AddBannedCDKey(string key)
        {
            var sFunc = "AddBannedCDKey";

            NWNXCore.NWNX_PushArgumentString(key);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }
        public static void RemoveBannedCDKey(string key)
        {
            var sFunc = "RemoveBannedCDKey";

            NWNXCore.NWNX_PushArgumentString(key);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }
        public static void AddBannedPlayerName(string playerName)
        {
            var sFunc = "AddBannedPlayerName";

            NWNXCore.NWNX_PushArgumentString(playerName);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }
        public static void RemoveBannedPlayerName(string playerName)
        {
            var sFunc = "RemoveBannedPlayerName";

            NWNXCore.NWNX_PushArgumentString(playerName);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }
        public static string GetBannedList()
        {
            var sFunc = "GetBannedList";

            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
            return NWNXCore.NWNX_GetReturnValueString();
        }

        public static void SetModuleName(string name)
        {
            var sFunc = "SetModuleName";

            NWNXCore.NWNX_PushArgumentString(name);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static void SetServerName(string name)
        {
            var sFunc = "SetServerName";

            NWNXCore.NWNX_PushArgumentString(name);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static string GetServerName()
        {
            var sFunc = "GetServerName";
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
            return NWNXCore.NWNX_GetReturnValueString();
        }

        public static int GetPlayOption(AdministrationOption option)
        {
            var sFunc = "GetPlayOption";

            NWNXCore.NWNX_PushArgumentInt((int)option);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);

            return NWNXCore.NWNX_GetReturnValueInt();
        }

        public static void SetPlayOption(AdministrationOption option, int value)
        {
            var sFunc = "SetPlayOption";

            NWNXCore.NWNX_PushArgumentInt(value);
            NWNXCore.NWNX_PushArgumentInt((int)option);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static int DeleteTURD(string playerName, string characterName)
        {
            var sFunc = "DeleteTURD";

            NWNXCore.NWNX_PushArgumentString(characterName);
            NWNXCore.NWNX_PushArgumentString(playerName);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);

            return NWNXCore.NWNX_GetReturnValueInt();
        }

        public static AdministrationDebugType GetDebugValue(int type)
        {
            var sFunc = "GetDebugValue";

            NWNXCore.NWNX_PushArgumentInt(type);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);

            return (AdministrationDebugType)NWNXCore.NWNX_GetReturnValueInt();
        }

        public static void SetDebugValue(AdministrationDebugType type, int state)
        {
            var sFunc = "SetDebugValue";

            NWNXCore.NWNX_PushArgumentInt(state);
            NWNXCore.NWNX_PushArgumentInt((int)type);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static void ReloadRules()
        {
            var sFunc = "ReloadRules";

            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static int GetMinLevel()
        {
            var sFunc = "GetMinLevel";
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
            return NWNXCore.NWNX_GetReturnValueInt();
        }

        public static void SetMinLevel(int nLevel)
        {
            var sFunc = "SetMinLevel";
            NWNXCore.NWNX_PushArgumentInt(nLevel);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }

        public static int GetMaxLevel()
        {
            var sFunc = "GetMaxLevel";
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
            return NWNXCore.NWNX_GetReturnValueInt();
        }

        public static void SetMaxLevel(int nLevel)
        {
            var sFunc = "SetMaxLevel";
            NWNXCore.NWNX_PushArgumentInt(nLevel);
            NWNXCore.NWNX_CallFunction(NWNX_Administration, sFunc);
        }
    }
}