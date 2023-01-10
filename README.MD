# Lightweight library that allows easily change language using ScriptableObject.

![](qwe.PNG)

## Prerequisites: TextMeshPro and Unity

Consists of 3 (2 runtime and 1 editor) scripts:
1. Translatable.cs       (MonoBehaviour)
2. TranslatableText.cs   (ScriptableObject)
3. TranslatableEditor.cs (Editor)

## Launch a beautiful demo scene "TranslatableSampleScene" to see lib in action

### Usage:
* Add *Translatable* on *GameObject* that has either *TextMeshProUGUI* or *TextMeshPro* component 
* Make new *TranslatableText* as *ScriptableObject* (Right click in Assets->Translatable->New Translatable Text)
* To add new language: add new enum to *Language* that located in *Translatable.cs*
* To change language via code - call static function *TranslatableSetLanguageAndUpdateAll(Language xxx)*


### This lib was made on Unity 2020.