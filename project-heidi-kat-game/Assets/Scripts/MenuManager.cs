using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

	//Fadein the logo
	//Wait for 2 seconds
	//fade out logo
	//wait .5 Seconds
	//fade in Menu group
	[SerializeField]
    private CanvasGroup logo_hexennacht = null;

    [SerializeField]
    private CanvasGroup menu_main = null;

    //Flags
    private bool logoFadedIn = false;
    private bool inBetweenLogoFadeInAndOut = false;
    private bool logoFadedOut = false;
    private bool inBetweenLogoandMainDone = false;
    private bool menuFadedIn = false;

    public void SetValue (string flag, bool value)
    {
    	switch (flag)
    	{
    		case "logo faded in":
                logoFadedIn = value;
	    		break;
	    	case "in between logo fade in and out":
                inBetweenLogoFadeInAndOut = value;
	    		break;
	    	case "logo faded out":
                logoFadedOut = value;
	    		break;
	    	case "in between logo and menu":
                inBetweenLogoandMainDone = value;
	    		break;
	    	case "menu faded in":
                menuFadedIn = value;
	    		break;
	    	default:
                break;
	    }
    }

	public void FadeIn(CanvasGroup uiElement, float time, string flag)
	{
		StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1f, time, flag));
	}

	public void FadeOut(CanvasGroup uiElement, float time, string flag)
	{
		StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0f, time, flag));
	}

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime, string flag)
    {
    	float _timeStartedLerping = Time.time;
    	float timeSinceStarted = Time.time - _timeStartedLerping;
    	float percentageComplete = timeSinceStarted / lerpTime;


    	while(true)
    	{
    		timeSinceStarted = Time.time - _timeStartedLerping;
    		percentageComplete = timeSinceStarted / lerpTime;

    		float currentValue = Mathf.Lerp(start,end,percentageComplete);

    		cg.alpha = currentValue;

    		if (percentageComplete >=1) break;

    		yield return new WaitForEndOfFrame();
    	}
    	SetValue(flag,true);
    }

    public IEnumerator WaitTimer(float waitTime, string flag)
    {
    	yield return new WaitForSeconds(waitTime);

    	SetValue(flag,true);
    }

    public void CheckNextEvent()
    {
    	if (logoFadedIn)
    	{
    		logoFadedIn = false;
    		//Starts Wait Timer
    		StartCoroutine(WaitTimer(1.0f,"in between logo fade in and out"));
    	}
    	if (inBetweenLogoFadeInAndOut)
    	{
    		inBetweenLogoFadeInAndOut = false;
    		//Starts Logo Fade out
    		FadeOut(logo_hexennacht, 1.0f,"logo faded out");
    	}
    	if (logoFadedOut)
    	{
    		logoFadedOut = false;
    		//Starts Wait Timer
    		StartCoroutine(WaitTimer(0.5f,"in between logo and menu"));
    	}
    	if (inBetweenLogoandMainDone)
    	{
    		inBetweenLogoandMainDone = false;
    		//Start Menu Fade in
    		FadeIn(menu_main, 1.0f,"menu faded in");
    	}
    	if (menuFadedIn)
    	{
    		menuFadedIn = false;
    		//Start Enable Menu Interaction
    		print("Rock and Roll!");
    	}


    }

    // Start is called before the first frame update
    void Start()
    {
    	logo_hexennacht.alpha = 0;
    	menu_main.alpha = 0;
    	FadeIn(logo_hexennacht, 3.0f, "logo faded in");
    	//StartCoroutine(WaitTimer(3.0f,"logo faded in"));
        
    }

    // Update is called once per frame
    void Update()
    {
    	CheckNextEvent();
        
    }
}
