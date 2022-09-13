using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonOnClickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(SwitchScene);
    }

    void SwitchScene() {
        SceneManager.LoadScene("PlayArea", LoadSceneMode.Single);
    }
}
