using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;


namespace Translatables
{
    public enum Language : int
    {
        English,
        Spanish,
        Russian,
        Polish
    }

    [RequireComponent(typeof(TMP_Text))]
    public class Translatable : MonoBehaviour
    {
        public static Language CURRENT_LANGUAGE = Language.Russian;
        public static void SetLanguageAndUpdateAll(Language new_language)
        {
            CURRENT_LANGUAGE = new_language;
            UpdateTextOnAllTranslatables();
        }

        static List<Translatable> all_translatables = new List<Translatable>();

        public static void UpdateTextOnAllTranslatables()
        {
#if UNITY_EDITOR
            Translatable[] _all_translatables = FindObjectsOfType<Translatable>();
            for(int i = 0; i < _all_translatables.Length; i++)
            {
                _all_translatables[i].UpdateText();
            }
#else
            for(int i = 0; i < all_translatables.Count; i++)
            {
                all_translatables[i].UpdateText();
            }
#endif
        }

        public static void IncrementLanguage()
        {
            CURRENT_LANGUAGE++;
            if((int)CURRENT_LANGUAGE >= System.Enum.GetNames(typeof(Language)).Length)
            {
                CURRENT_LANGUAGE = 0;
            }
        }

        public TranslatableText translatable_text;

        TMP_Text tmp;

        public TMP_Text GetTMP_Text()
        {
            if(!tmp)
                tmp = GetComponent<TMP_Text>();

            return tmp;
        }



        


        void Awake()
        {
            tmp = GetComponent<TMP_Text>();
            if(!all_translatables.Contains(this))
                all_translatables.Add(this);
        }

        void OnEnable()
        {
            UpdateText();
        }

        void OnDestroy()
        {
            all_translatables.Remove(this);
        }

        public void UpdateText()
        {
            GetTMP_Text().SetText(GetText_InCurrentLanguage());
        }

        public string GetText_InCurrentLanguage()
        {
            string Result_string;

            switch(CURRENT_LANGUAGE)
            {
                case(Language.English):
                {
                    Result_string = translatable_text.eng_str;
                    break;
                }
                case(Language.Spanish):
                {
                    Result_string = translatable_text.spanish_str;
                    break;
                }
                case(Language.Russian):
                {
                    Result_string = translatable_text.russian_str;
                    break;
                }
                case(Language.Polish):
                {
                    Result_string = translatable_text.polish_str;
                    break;
                }
                default:
                {
                    Result_string = translatable_text.eng_str;
                    break;
                }
            }

            return Result_string;
        }

    }
}
