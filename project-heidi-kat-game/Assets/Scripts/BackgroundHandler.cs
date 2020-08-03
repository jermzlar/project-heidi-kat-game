using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundHandler : MonoBehaviour
{
    [SerializeField]
    private Image backgroundCanvas = null;

    [SerializeField]
    private Sprite backgroundBedroom = null; //background

    [SerializeField]
    private Sprite backgroundHallway = null;

    [SerializeField]
    private Sprite backgroundTunnels = null;

    [SerializeField]
    private Sprite backgroundHospital = null;

    [SerializeField]
    private Sprite backgroundLaboratory = null;



    public void ChangeBackground(Sprite background)
    {
    	backgroundCanvas.sprite = background;
    }

    public void ChangeBackground(string background)
    {
    	switch(background)
    	{
    		case "bedroom":
    			ChangeBackground(backgroundBedroom);
    			break;
    		case "tunnels":
    			ChangeBackground(backgroundHallway);
    			break;
    		case "hallway":
    			ChangeBackground(backgroundTunnels);
    			break;
    		case "hospital":
    			ChangeBackground(backgroundHospital);
    			break;
    		case "laboratory":
    			ChangeBackground(backgroundLaboratory);
    			break;
    		default:
                Debug.Log("Unknown Background" + background);
    			break;
    	}

    }

    public void ChangeBackgroundToHallway()
    {
    	ChangeBackground(backgroundHallway);
    }

    void Start()
    {
    }
  

    void Update()
    {
        
    }
}
