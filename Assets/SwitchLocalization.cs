using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class SwitchLocalization : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return LocalizationSettings.InitializationOperation;
        for (int i = 0; i < LocalizationSettings.AvailableLocales.Locales.Count; i++)
        {
            Debug.Log(LocalizationSettings.AvailableLocales.Locales[i].LocaleName);
        }
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[Random.Range(0, 4)];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
