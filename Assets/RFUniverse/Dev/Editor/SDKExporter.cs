﻿using UnityEditor;

namespace RFUniverse
{
    public class SDKExporter : Editor
    {
        [MenuItem("RFUniverse/Build Release/Unity Package SDK", false, 3)]
        public static void Export()
        {
            //string[] defines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone).Split(';');
            //PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, new string[0]);
            string[] filePaths = new[]
            {
                "Assets/AddressableAssetsData",
                "Assets/RFUniverse/Editor",
                "Assets/RFUniverse/Runtime",
                "Assets/Plugins/Editor",
                "Assets/Plugins/Demigiant",
                "Assets/Plugins/HeatMap",
                "Assets/Plugins/CoACD",
                "Assets/Plugins/URDF-Importer",
                "Assets/Plugins/BioIK/BioIK.asmref",
                "Assets/RFUniverse/Version.txt",
                "Assets/TextMesh Pro"
            };
            AssetDatabase.ExportPackage(filePaths, $"{BuildRelease.BUILD_PATH}/RFUniverse_Core_SDK_v{PlayerMain.VERSION}.unitypackage", ExportPackageOptions.Interactive | ExportPackageOptions.Recurse);
            //PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, defines);
        }
    }
}
