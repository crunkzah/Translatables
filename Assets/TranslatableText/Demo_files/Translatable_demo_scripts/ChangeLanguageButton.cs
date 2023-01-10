using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguageButton : MonoBehaviour
{
    public void ChangeLanguageButton_Click()
    {
        Translatables.Translatable.IncrementLanguage();
        Translatables.Translatable.UpdateTextOnAllTranslatables();
    }
}
