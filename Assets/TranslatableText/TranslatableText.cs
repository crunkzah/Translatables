using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TranslatableText_ScriptableObject", menuName = "Translatable/New Translatable Text")]
public class TranslatableText : ScriptableObject
{
    [TextArea(1, 5)]public string eng_str;
    [TextArea(1, 5)]public string spanish_str;
    [TextArea(1, 5)]public string russian_str;
    [TextArea(1, 5)]public string polish_str;
}
