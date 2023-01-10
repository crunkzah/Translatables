using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

namespace Translatables
{
    [CustomEditor(typeof(Translatable))]
    public class TranslatableEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            Translatable t = (Translatable)target;

            GUIStyle style = GUIStyle.none;
            style.fontStyle = FontStyle.Bold;
            style.normal.textColor = Color.yellow;
            style.alignment = TextAnchor.MiddleCenter;

            GUILayout.Label("Current language: <color=yellow>" + Translatable.CURRENT_LANGUAGE + "</color>", style);

            if (GUILayout.Button("Change language"))
            {
                Translatable.IncrementLanguage();
                Translatable.UpdateTextOnAllTranslatables();

                EditorUtility.SetDirty(target);
                UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene());
                Debug.Log("New language " + Translatable.CURRENT_LANGUAGE);
            }

            if (GUILayout.Button("Read from TranslatableText (this only)"))
            {
                t.UpdateText();
                
                EditorUtility.SetDirty(target);
                UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene());

                Debug.Log("Read from TranslatableText on <color=yellow>" + t.gameObject.name + "</color>");
            }

        }
    }
}
