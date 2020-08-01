using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{

	public Sprite[] emotionSprites; //https://www.youtube.com/watch?v=v5sU1Aidzwo - 15 min
	SpriteRenderer spRend;
	public int ID; //Left = 0, Right = 1
	public enum CharacterStats
    {
    	normal,attack
    }

    void Awake()
    {
        //myStat = CharacterStats.normal; //27:09
        spRend = GetComponent<SpriteRenderer>();
    }

    public void ChangeStat(string statName)
    {
    	StartCoroutine(statName + "Stat");
    }

    IEnumerator defaultStat()
    {
    	//placeholder
    	yield return null;
    }

    IEnumerator attackStat()
    {
    	//placeholder
    	yield return null;    	
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
