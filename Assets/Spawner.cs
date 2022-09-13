using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public GameObject triangle;

    [SerializeField]
    public GameObject square;

    [SerializeField]
    public GameObject circle;

    [SerializeField]
    public sbyte currentShape = 0;
    
    [SerializeField]
    public GameObject holoTriangle;
    [SerializeField]
    public GameObject holoSquare;
    [SerializeField]
    public GameObject holoCircle;

    // Start is called before the first frame update
    void Start() {
        Color tempcolor1 = holoTriangle.GetComponent<SpriteRenderer>().material.color;
        tempcolor1.a = 0.5f;
        holoTriangle.GetComponent<SpriteRenderer>().material.color = tempcolor1;
        holoSquare.GetComponent<SpriteRenderer>().material.color = tempcolor1;
        holoCircle.GetComponent<SpriteRenderer>().material.color = tempcolor1;
    }

    void MouseHologram(Vector2 MouseWorldpos2D) {
        holoTriangle.SetActive(false);
        holoSquare.SetActive(false);
        holoCircle.SetActive(false);
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            currentShape = 0;
        }
        else if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            currentShape = 1;
        }
        else if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            currentShape = 2;
        }
        switch (currentShape)
        {
            case 0:
                holoTriangle.SetActive(true);
                SetPos2D(holoTriangle, MouseWorldpos2D);
                holoSquare.SetActive(false);
                holoCircle.SetActive(false);
                break;
            case 1:
                holoTriangle.SetActive(false);
                holoSquare.SetActive(true);
                SetPos2D(holoSquare, MouseWorldpos2D);
                holoCircle.SetActive(false);
                break;
            case 2:
                holoTriangle.SetActive(false);
                holoSquare.SetActive(false);
                holoCircle.SetActive(true);
                SetPos2D(holoCircle, MouseWorldpos2D);
                break;
        }
    }

    void SpawnerMain(Vector2 MousePos2D) {
        if (Mouse.current.leftButton.wasPressedThisFrame) {
            switch (currentShape) {
                case 0:
                    GameObject t = Instantiate(triangle, Vector2ToVector3(MousePos2D), Quaternion.identity);
                    Rigidbody2D rbt = t.AddComponent<Rigidbody2D>() as Rigidbody2D;
                    break;
                case 1:
                    GameObject s = Instantiate(square, Vector2ToVector3(MousePos2D), Quaternion.identity);
                    Rigidbody2D rbs = s.AddComponent<Rigidbody2D>() as Rigidbody2D;
                    break;
                case 2:
                    GameObject c = Instantiate(circle, Vector2ToVector3(MousePos2D), Quaternion.identity);
                    Rigidbody2D rbc = c.AddComponent<Rigidbody2D>() as Rigidbody2D;
                    break;
            }
        }
    }

    Vector3 Vector2ToVector3(Vector2 input) {
        return new Vector3(input.x, input.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 MouseWorldpos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 MouseWorldpos2D = new Vector2(MouseWorldpos.x, MouseWorldpos.y);
        MouseHologram(MouseWorldpos2D);
        SpawnerMain(MouseWorldpos2D);
    }

    void SetPos2D(GameObject obj, Vector2 pos)
    {
        obj.transform.position = new Vector3(pos.x, pos.y, 0);
    }

    void SetPos2D(GameObject obj, Vector2 pos, int z)
    {
        obj.transform.position = new Vector3(pos.x, pos.y, z);
    }
}