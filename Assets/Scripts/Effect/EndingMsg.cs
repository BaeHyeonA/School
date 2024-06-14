using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndingMsg : MonoBehaviour
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

    private EndingFade fadeScript;
    public TutorialManager tm;
    public int textNum;

    public AudioSource aud;

    void Start()
    {
        fadeScript = GetComponent<EndingFade>();
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
            aud.Play();
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
            else if (textNum == 5)
            {
                fadeScript.LoadFade();
            }
            else
            {
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
