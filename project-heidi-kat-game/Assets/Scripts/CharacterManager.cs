using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{

	public GameObject[] characters;
	public List<GameObject> actorsList = new List<GameObject>();
	[SerializeField]
	Vector3 leftActorPosition, rightActorPosition;

	List<Actor> activeActors = new List<Actor>();

    void Start()
    {/*
        for(int i = 0; i < characters.Length; i++)
        {
        	GameObject newActor = Instantiate(characters[i]);
        	newActor.SetActive(false);
        	newActor.name = characters[i].name;
        	actorsList.Add(newActor);
        }*/
    }
/*
    public void PlaceActors(string leftActorName, string rightActorName)
    {
    	foreach (GameObject gO in actorsList)
    	{
    		if(gO.name == leftActorName)
    		{
    			gO.SetActive(true);
    			gO.getComponent<Actor>().ID = 0;
    			activeActors.Add(gO.getComponent<Actor>());
    			gO.transform.position = leftActorPosition;
    		} else if(gO.name == rightActorName)
    		{
    			gO.SetActive(true);
    			gO.getComponent<Actor>().ID = 1;
    			activeActors.Add(gO.getComponent<Actor>());
    			gO.transform.position = rightActorPosition;
    		}

    	}
    }

    //ID Left = 0, right = 1
    public void ChangeActorStat(string stat, int ID)
    {
    	foreach (Actor actor in activeActors)
    	{
    		if (actor.gameObject.activeInHierarchy)
    		{
    			actor.ChangeStat(stat);
    		}
    	}

    }
*/
    void Update()
    {
        
    }

}
