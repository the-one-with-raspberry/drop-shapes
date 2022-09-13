using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UpdateBaseplatePos : MonoBehaviour
{
    public Camera cam;

    public char lrb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (lrb) {
            case 'l':
                gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(0, (cam.pixelHeight / 2), (Math.Abs(cam.transform.position.z))));
                break;
            case 'r':
                gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, (cam.pixelHeight / 2), (Math.Abs(cam.transform.position.z))));
                break;
            case 'b':
                gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3((cam.pixelWidth / 2), (0 + (gameObject.transform.localScale.y / 2)), (Math.Abs(cam.transform.position.z))));
                break;
        }  
    }
}
