using UnityEditor;
using UnityEngine;

namespace UniTools.Defines
{
    public abstract class BaseScriptingDefineSymbols : ScriptableObject
    {
        public virtual void Apply(BuildTargetGroup buildTargetGroup)
        {
            PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup, ToString());
        }
    }
}