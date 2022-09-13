using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PingPongRotateOnHover : MonoBehaviour
{
    public float rotFl;

    public string direction;

    public float timeFactor;

    bool mouse_over;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (mouse_over)
        {
            switch (direction)
            {
                case "left":
                    transform.localEulerAngles = new Vector3(
                        0,
                        0,
                        Mathf.PingPong(Time.time * timeFactor, rotFl)
                    );
                    break;
                case "right":
                    transform.localEulerAngles = new Vector3(
                        0,
                        0,
                        -Mathf.PingPong(Time.time * timeFactor, rotFl)
                    );
                    break;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
    }
}
