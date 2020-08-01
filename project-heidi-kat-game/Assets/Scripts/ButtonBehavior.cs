using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
	private bool isButtonPressed = false;

	[SerializeField]
	private AudioSource buttonClickSound = null;

    void Start()
    {
        
    }

    public void buttonPressDown()
    {
    	isButtonPressed = true;
    	buttonClickSound.Play();
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
    void Update()
    {
    	//buttonCheck();
    }
}
