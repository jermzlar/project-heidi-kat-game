using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFader : MonoBehaviour
{

	public CanvasGroup uiElement;

	public void FadeIn()
	{
		StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1));
	}

	public void FadeOut()
	{
		StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
	}

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float learpTime = 0.5f)
    {
    	float _timeStartedLerping = Time.time;
    	float timeSinceStarted = Time.time - _timeStartedLerping;
    	float percentageComplete = timeSinceStarted / learpTime;


    	while(true)
    	{
    		timeSinceStarted = Time.time - _timeStartedLerping;
    		percentageComplete = timeSinceStarted / learpTime;

    		float currentValue = Mathf.Lerp(start,end,percentageComplete);

    		cg.alpha = currentValue;

    		if (percentageComplete >=1) break;

    		yield return new WaitForEndOfFrame();
    	}
    }

    public bool WaitTimer(float waitTime)
    {
    	float _timeStarted = Time.time;
    	float timeSinceStarted = Time.time - _timeStarted;

    	while(true)
    	{
    		timeSinceStarted = Time.time - _timeStarted;

    		if(timeSinceStarted >= waitTime) break;
    	}

    	return true;

    }
}
