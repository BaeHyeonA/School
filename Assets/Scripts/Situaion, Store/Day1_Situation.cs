using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Day1_Situation : MonoBehaviour
{
    public GameObject Reasion_1;
    public GameObject Reasion_2;
    public GameObject Reasion_3;
    public GameObject Reasion_4;
    public Button Ans1;
    public Button Ans2;
    public Button Ans3;
    public Button Ans4;
    public Button Btn_Close;

    public AudioSource trueAud;
    public AudioSource falseAud;

    void Start()
    {
        DeactivateAllAnswers();

        Ans1.onClick.AddListener(() => ActivateAnswer(Reasion_1, false));
        Ans2.onClick.AddListener(() => ActivateAnswer(Reasion_2, true));
        Ans3.onClick.AddListener(() => ActivateAnswer(Reasion_3, false));
        Ans4.onClick.AddListener(() => ActivateAnswer(Reasion_4, false));
        Btn_Close.onClick.AddListener(DeactivateAllAnswers);
    }

    void ActivateAnswer(GameObject answer, bool check)
    {
        DeactivateAllAnswers();
        answer.SetActive(true);
        AudioSource audio = check ? trueAud : falseAud;
        audio.Play();
        Btn_Close.gameObject.SetActive(true);
    }

    void DeactivateAllAnswers()
    {
        Reasion_1.SetActive(false);
        Reasion_2.SetActive(false);
        Reasion_3.SetActive(false);
        Reasion_4.SetActive(false);
        Btn_Close.gameObject.SetActive(false);
    }
}