using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongRotate : MonoBehaviour
{
    public float rotFl;

    public string direction;

    public float timeFactor;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        switch (direction) {
            case "left":
                transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * timeFactor, rotFl));
                break;
            case "right":
                transform.localEulerAngles = new Vector3(0, 0, -Mathf.PingPong(Time.time * timeFactor, rotFl));
                break;
        }
    }
}
