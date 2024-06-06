using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialMsg: MonoBehaviour
{
    public TextMeshProUGUI text;
    public List<string> _dialog = new List<string>();
    public int _dialogNum;
    public GameObject img;

    public int CharPerSeconds;
    private string targetmsg;
    private int index;
    private float interval;
    private bool isEffect;

    private Fade fadeScript;
    public TutorialManager tm;
    public int textNum;

    public GameObject cal;
    public GameObject sticker;
    public GameObject quest;
    public GameObject quiz;
    public GameObject store;


    void Start()
    {
        fadeScript = GetComponent<Fade>();
        _dialogNum = 0;
        NextDialog();
        interval = 1.0f / CharPerSeconds;
    }

    void OnEnable()
    {
        _dialogNum = 0;
        NextDialog();
        interval = 1.0f / CharPerSeconds;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
    {
        if (isEffect)
        {
            CancelInvoke();
            EffectEnd();
            text.text = targetmsg;
        }
        else
            NextDialog();
    }
    }

    public void NextDialog()
    {
        if (_dialogNum < _dialog.Count)
        {
            Setmsg(_dialog[_dialogNum]);
            _dialogNum++;

        }
        else
        {
            if (textNum == 0)
                fadeScript.LoadFade();
            else if(textNum == 5)
            {
                store.SetActive(false);
                fadeScript.LoadFade();
            }
            else
            {
                 if (textNum == 1)
                {
                    cal.SetActive(false);
                    sticker.SetActive(true);
                }
                else if (textNum == 2)
                {
                    sticker.SetActive(false);
                    quest.SetActive(true);
                }
                else if (textNum == 3)
                {
                    quest.SetActive(false);
                    quiz.SetActive(true);
                }
                else if (textNum == 4)
                {
                    quiz.SetActive(false);
                    store.SetActive(true);
                }
                tm.Change(textNum);
            }
        }
    }

    public void Setmsg(string msg)
    {
        if (isEffect)
        {
            CancelInvoke();
            EffectEnd();
        }
        targetmsg = msg;
        EffectStart();
    }

    void EffectStart()
    {
        img.SetActive(false);
        text.text = "";
        index = 0;
        isEffect = true;
        Invoke("Effecting", interval);
    }

    void Effecting()
    {
        if (text.text == targetmsg)
        {
            EffectEnd();
            return;
        }

        text.text += targetmsg[index];
        index++;

        Invoke("Effecting", interval);
    }

    void EffectEnd()
    {
        isEffect = false;
        img.SetActive(true);
    }
}
