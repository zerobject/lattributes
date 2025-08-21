#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Zerobject.Lattributes.Editor.Drawers
{
    [CustomPropertyDrawer(typeof(ReadonlyAttribute))]
    public class ReadonlyAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
        {
            EditorGUI.BeginDisabledGroup(true);
            EditorGUI.LabelField(pos, label, new GUIContent(prop.boxedValue.ToString()));
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif