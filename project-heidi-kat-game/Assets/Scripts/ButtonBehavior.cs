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
    public void PlaySound()
    {
        buttonClickSound.Play();
    }
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
        buttonClickSound = transform.GetComponent<AudioSource>();
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
