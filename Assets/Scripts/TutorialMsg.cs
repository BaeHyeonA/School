using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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

    //텍스트 이펙트없이 다 보이게 해주는 기능을 위한 변수
    private bool msgCheck;
    private int _dialogNum2;

    private Fade fadeScript;
    public TutorialManager tm;
    public int textNum;
    

    void Start()
    {
        fadeScript = GetComponent<Fade>();
        _dialogNum = 0;
        _dialogNum2 = 0;
        msgCheck = true;
        NextDialog();
        interval = 1.0f / CharPerSeconds;
    }

    void OnEnable()
    {
        _dialogNum = 0;
        _dialogNum2 = 0;
        msgCheck = true;
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
            msgCheck = true;
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
            msgCheck = false;
        }
        else
        {
            if (textNum == 0 || textNum == 5)
                fadeScript.LoadFade();
            else
                tm.Change(textNum);
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
