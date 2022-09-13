using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkLightMode : MonoBehaviour
{
    public Slider slider;

    public Camera cam;

    public GameObject playButton;

    public Text playButtonText, titleText1, titleText2;

    public Sprite blackButton;

    public Sprite whiteButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (slider.value) {
            case 0:
                playButtonText.color = Color.HSVToRGB(0.0f, 0.0f, 0.0f);
                titleText1.color = Color.HSVToRGB(0.0f, 0.0f, 1.0f);
                titleText2.color = Color.HSVToRGB(0.0f, 0.0f, 1.0f);
                cam.backgroundColor = Color.HSVToRGB(0.0f, 0.0f, 0.0f);
                playButton.GetComponent<Image>().sprite = whiteButton;
                break;
            case 1:
                playButtonText.color = Color.HSVToRGB(0.0f, 0.0f, 1.0f);
                titleText1.color = Color.HSVToRGB(0.0f, 0.0f, 0.0f);
                titleText2.color = Color.HSVToRGB(0.0f, 0.0f, 0.0f);
                cam.backgroundColor = Color.HSVToRGB(0.0f, 0.0f, 1.0f);
                playButton.GetComponent<Image>().sprite = blackButton;
                break;
        }
    }
}
