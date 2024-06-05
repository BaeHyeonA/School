using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Day2_Situation : MonoBehaviour
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

    void Start()
    {
        DeactivateAllAnswers();

        Ans1.onClick.AddListener(() => ActivateAnswer(Reasion_1));
        Ans2.onClick.AddListener(() => ActivateAnswer(Reasion_2));
        Ans3.onClick.AddListener(() => ActivateAnswer(Reasion_3));
        Ans4.onClick.AddListener(() => ActivateAnswer(Reasion_4));
        Btn_Close.onClick.AddListener(DeactivateAllAnswers);
    }

    void ActivateAnswer(GameObject answer)
    {
        DeactivateAllAnswers();
        answer.SetActive(true);
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
