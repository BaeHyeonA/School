using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    public GameObject fadePanel;
    public GameObject character;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;

    Image image;

    void Awake()
    {
        StartCoroutine(FadeInStart());
    }

    IEnumerator FadeInStart()
    {
        yield return new WaitForSeconds(0.3f);

        image = fadePanel.GetComponent<Image>();
        float fadeCount = 1.0f;
        while (fadeCount > 0)
        {
            fadeCount -= 0.01f;
            yield return new WaitForSeconds(0.015f);
            image.color = new Color(0, 0, 0, fadeCount);
        }

        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        text1.SetActive(true);
        yield return new WaitForSeconds(1f);
        text2.SetActive(true);
        yield return new WaitForSeconds(1f);
        text3.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Tutorial");
    }
}
