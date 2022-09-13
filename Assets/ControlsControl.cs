using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ControlsControl : MonoBehaviour
{
    public bool controlsScreenOn;

    public Text control1,
        control2,
        control3,
        control4,
        control5,
        title;

    public Image background;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            if (controlsScreenOn)
            {
                ChangeScreen(false);
            }
            else if (!controlsScreenOn)
            {
                ChangeScreen(true);
            }
        }
    }

    void ChangeScreen(bool type)
    {
        switch (type)
        {
            case false:
                SwitchScreenOff();
                break;
            case true:
                SwitchScreenOn();
                break;
        }
    }

    void SwitchScreenOff()
    {
        Text[] objArr = { control1, control2, control3, control4, control5 };
        foreach (Text objCurrent in objArr)
        {
            Text tobj = objCurrent.GetComponent<Text>();
            Color tcol = tobj.color;
            tcol.a = 0f;
            tobj.color = tcol;
        }
        Text tobjt = title.GetComponent<Text>();
        Color tcolt = tobjt.color;
        tcolt.a = 0f;
        tobjt.color = tcolt;
        Image tobjb = background.GetComponent<Image>();
        Color tcolb = tobjb.color;
        tcolb.a = 0f;
        tobjb.color = tcolb;
        controlsScreenOn = false;
    }

    void SwitchScreenOn()
    {
        Text[] objArr = { control1, control2, control3, control4, control5 };
        foreach (Text objCurrent in objArr)
        {
            Text tobj = objCurrent.GetComponent<Text>();
            Color tcol = tobj.color;
            tcol.a = 1f;
            tobj.color = tcol;
        }
        Text tobjt = title.GetComponent<Text>();
        Color tcolt = tobjt.color;
        tcolt.a = 1f;
        tobjt.color = tcolt;
        Image tobjb = background.GetComponent<Image>();
        Color tcolb = tobjb.color;
        tcolb.a = 0.5f;
        tobjb.color = tcolb;
        controlsScreenOn = true;
    }
}
