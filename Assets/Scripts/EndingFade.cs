using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingFade : MonoBehaviour
{
    public GameObject fadePanel;
    //public TutorialManager tm;
    public GameObject Panel;
    Image image;

    public void LoadFade()
    {
        fadePanel.SetActive(true);
        image = fadePanel.GetComponent<Image>();
        StartCoroutine(StartFadeOutCoroutine());
    }

    IEnumerator StartFadeOutCoroutine()
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.015f);
            image.color = new Color(0, 0, 0, fadeCount);
        }
        // GetComponent<TutorialMsg>().text.text = "";
        //if (GetComponent<TutorialMsg>().textNum == 5)
        //StartCoroutine(StartFadeInCoroutine());
    }
}

   /* IEnumerator StartFadeInCoroutine()
    {
        yield return new WaitForSeconds(0.3f);

        float fadeCount = 1.0f;
        while (fadeCount > 0)
        {
            fadeCount -= 0.01f;
            yield return new WaitForSeconds(0.015f);
            image.color = new Color(0, 0, 0, fadeCount);
        }
        Panel.SetActive(true);

        yield return new WaitForSeconds(0.8f);

        //if (GetComponent<TutorialMsg>().textNum == 0)
            //GetComponent<TutorialMsg>().cal.SetActive(true);
        //tm.Change(GetComponent<TutorialMsg>().textNum);
    }
}*/