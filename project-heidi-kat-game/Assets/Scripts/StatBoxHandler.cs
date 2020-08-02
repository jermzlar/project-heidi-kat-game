using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBoxHandler : MonoBehaviour
{
	//Open y=240 Closed y=336 delta 94
	public Vector3 closedPosition = new Vector3(0.0f, 0.0f, 0.0f);
	public Vector3 openedPosition = new Vector3(0.0f, 240.0f, 0.0f);
	public bool isStatBoxClosed = true;


	[SerializeField]
	public Sprite statBoxNoGlow = null;

	[SerializeField]
	public Sprite statBoxGlow = null;

    void Start()
    {
    	closedPosition = transform.position;
    	openedPosition = closedPosition - new Vector3(0.0f, 94.0f, 0.0f);
        transform.GetComponent<Image>().sprite = statBoxNoGlow;
    }

    public void toggleStatBox()
    {
    	Debug.Log("click");
    	if (isStatBoxClosed)
    	{
    		changeSpriteToClosed(false);
    		changePositionToClosed(false);
    		isStatBoxClosed = false;
    	}
    	else
    	{
    		changeSpriteToClosed(true);
    		changePositionToClosed(true);
    		isStatBoxClosed = true;
    	}
    }

    public void changeSpriteToClosed (bool isStatBoxClosed)
    {
    	if (isStatBoxClosed)
    	{
    		transform.GetComponent<Image>().sprite = statBoxNoGlow;
    	} 
    	else 
    	{
    		transform.GetComponent<Image>().sprite = statBoxGlow;
    	}
    }

    public void changePositionToClosed (bool isStatBoxClosed)
    {
    	if (isStatBoxClosed)
    	{
    		transform.position = closedPosition;
    	} 
    	else 
    	{
    		transform.position = openedPosition;
    	}
    }


    
    void Update()
    {
        
    }
}
