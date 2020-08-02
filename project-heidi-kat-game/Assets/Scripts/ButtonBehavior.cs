using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonBehavior : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private Text buttonText = null;
    private Button button = null;

	private bool isButtonPressed = false;

    [SerializeField]
    private AudioSource buttonClickSound = null;
    public void buttonPressDown()
    {
    	isButtonPressed = true;
    	buttonClickSound.GetComponent<AudioSource>().Play();
    }

    public void buttonPressUp()
    {
    	isButtonPressed = false;
    }
    /*
        public void buttonCheck()
        {
            if(isButtonPressed == true)
            {
                //
                buttonPressUp();
            } else if(isButtonPressed == false)
            {
                //
                buttonPressDown();
            }
        }
    */
    //change Text Color on click
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        buttonText.color = Color.white;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        buttonText.color = Color.black;

    }

    void Awake()
    {
        buttonText = transform.GetComponentInChildren<Text>();
        button = transform.GetComponent<Button>();
    }

    void Start()
    {
        //button.onClick.AddListener(ChangeColor);
    }

    void Update()
    {
        //buttonCheck();

    }
}
