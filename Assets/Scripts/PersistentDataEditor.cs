using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PersistentData), true)]
public class PersistentDataEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		EditorGUI.BeginDisabledGroup(serializedObject.isEditingMultipleObjects);

		if (GUILayout.Button("Save"))
        {
			((PersistentData)target).Save();
			EditorGUILayout.Space();
		}

		EditorGUI.EndDisabledGroup();
	}
}
