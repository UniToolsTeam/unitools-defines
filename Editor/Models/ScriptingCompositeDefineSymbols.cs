using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace UniTools.Defines
{
    [CreateAssetMenu(
        fileName = nameof(ScriptingCompositeDefineSymbols),
        menuName = nameof(UniTools) + "/" + nameof(Defines) + "/" + nameof(ScriptingCompositeDefineSymbols)
    )]
    public sealed class ScriptingCompositeDefineSymbols : BaseScriptingDefineSymbols
    {
        [SerializeField] private List<ScriptingDefineSymbols> m_defines = new List<ScriptingDefineSymbols>();

        public override void Apply(BuildTargetGroup buildTargetGroup)
        {
            base.Apply(buildTargetGroup);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            int last = m_defines.Count - 1;

            for (int i = 0; i < last; i++)
            {
                builder.Append(m_defines[i].ToString()).Append(";");
            }

            builder.Append(m_defines[last].ToString());

            return builder.ToString();
        }
    }
}