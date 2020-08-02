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
    private SoundManager buttonClickSound = null;
    public void PlaySound()
    {
        buttonClickSound.PlaySound("mouse_click");
    }
    //change Text Color on click
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        buttonText.color = Color.white;
        PlaySound();
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        buttonText.color = new Color32(0x1b, 0x55, 0x7b, 0xFF);

    }

    void Awake()
    {
        buttonText = transform.GetComponentInChildren<Text>();
        button = transform.GetComponent<Button>();
        buttonClickSound = FindObjectOfType<SoundManager>();
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
