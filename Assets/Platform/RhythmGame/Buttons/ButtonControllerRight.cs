using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerRight : MonoBehaviour
{
    private SpriteRenderer SR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public GameObject buttons;

    public KeyCode keyToPress;
    GamepadInput GamepadInputComponent;


    private void Awake()
    {
        GamepadInputComponent = FindObjectOfType<GamepadInput>();
    }
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (GameManager.instance.startplaying && GameManager.instance.menuPause == false)
        {
            buttons.SetActive(true);

            // KeyBoard
            if (Input.GetKeyDown(keyToPress))
            {
                SR.sprite = pressedImage;
            }
            if (Input.GetKeyUp(keyToPress))
            {
                SR.sprite = defaultImage;
            }

            // GamePad
            if (GamepadInputComponent.onButtonDown["RightArrow"])
            {
                SR.sprite = pressedImage;
            }
            if (GamepadInputComponent.onButtonUp["RightArrow"])
            {
                SR.sprite = defaultImage;
            }


            }
    }
}
