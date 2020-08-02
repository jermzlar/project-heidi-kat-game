using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
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
    void Update()
    {
    	//buttonCheck();

    }
}
