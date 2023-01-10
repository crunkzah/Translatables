using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeLanguage_Dropdown : MonoBehaviour
{
    void Awake()
    {
        int lang_int = (int)Translatables.Translatable.CURRENT_LANGUAGE;
        GetComponent<TMP_Dropdown>().SetValueWithoutNotify(lang_int);
    }

    public void OnValueChanged(int x)
    {
        Debug.Log("OnValueChanged(): " + x);
        Translatables.Language lang = (Translatables.Language)x;
        Translatables.Translatable.SetLanguageAndUpdateAll(lang);
    }
}
