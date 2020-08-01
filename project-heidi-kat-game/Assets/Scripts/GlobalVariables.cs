using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{

	private string player_name = "Butts";
	private string pronoun_she = "she";
	private string pronoun_hers = "hers";
	private string pronoun_her = "her";
	private string gender_person = "woman";
	private string gender_females = "female";

	private int combat_skill = 50;
	private int medicine_skill = 50;
	private int technology_skill = 50;
	private int ingenuity_skill = 50;
	private int charm_skill = 50;

	private int rel_sunday = 50;
	private int rel_lin = 50;

	private int compassion_selfserve = 50;
	private int communal_independent = 50;
	private int logical_creative = 50;
	private int optimist_pessimist = 50;

	[SerializeField]
	private InkManager im = null;

    void Start()
    {
        
    }

    public void setPlayerName(string value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["player_name"] = value;
    	}
    }
    public string getPlayerName()
    {
    	return (string)im.story.variablesState["player_name"];
    }

    public void setPronounShe(string value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["pronoun_she"] = value;
    	}
    }
    public string getPronounShe()
    {
    	return (string)im.story.variablesState["pronoun_she"];
    }

    public void setPronounHers(string value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["pronoun_hers"] = value;
    	}
    }
    public string getPronounHers()
    {
    	return (string)im.story.variablesState["pronoun_hers"];
    }

    public void setPronounHer(string value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["pronoun_her"] = value;
    	}
    }
    public string getPronounHer()
    {
    	return (string)im.story.variablesState["pronoun_her"];
    }

    public void setGenderPerson(string value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["gender_person"] = value;
    	}
    }
    public string getGenderPerson()
    {
    	return (string)im.story.variablesState["gender_person"];
    }

    public void setGenderFemales(string value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["gender_females"] = value;
    	}
    }
    public string getGenderFemales()
    {
    	return (string)im.story.variablesState["gender_females"];
    }

	public void setCombatSkill(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["combat_skill"] = value;
    	}
    }
    public int getCombatSkill()
    {
    	return (int)im.story.variablesState["combat_skill"];
    }

    public void setMedicineSkill(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["medicine_skill"] = value;
    	}
    }
    public int getMedicineSkill()
    {
    	return (int)im.story.variablesState["medicine_skill"];
    }

    public void setTechnologySkill(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["technology_skill"] = value;
    	}
    }
    public int getTechnologySkill()
    {
    	return (int)im.story.variablesState["technology_skill"];
    }

    public void setIngenuitySkill(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["ingenuity_skill"] = value;
    	}
    }
    public int getIngenuitySkill()
    {
    	return (int)im.story.variablesState["ingenuity_skill"];
    }

    public void setCharmSkill(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["charm_skill"] = value;
    	}
    }
    public int getCharmSkill()
    {
    	return (int)im.story.variablesState["charm_skill"];
    }

	public void setRelSunday(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["rel_sunday"] = value;
    	}
    }
    public int getRelSunday()
    {
    	return (int)im.story.variablesState["rel_sunday"];
    }

    public void setRelLin(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["rel_lin"] = value;
    	}
    }
    public int getRelLin()
    {
    	return (int)im.story.variablesState["rel_lin"];
    }

    public void setCompassionSelfserve(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["compassion_selfserve"] = value;
    	}
    }
    public int getCompassionSelfserve()
    {
    	return (int)im.story.variablesState["compassion_selfserve"];
    }

    public void setCommunalIndependent(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["communal_independent"] = value;
    	}
    }
    public int getCommunalIndependent()
    {
    	return (int)im.story.variablesState["communal_independent"];
    }

    public void setLogicalCreative(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["logical_creative"] = value;
       	}
    }
    public int getLogicalCreative()
    {
    	return (int)im.story.variablesState["logical_creative"];
    }

    public void setOptimistPessimist(int value)
    {
    	if(value != null)
    	{
    		im.story.variablesState["optimist_pessimist"] = value;
    	}
    }
    public int getOptimistPessimist()
    {
    	return (int)im.story.variablesState["optimist_pessimist"];
    }

    public void refreshAll()
    {
    	getPlayerName();
		getPronounShe();
		getPronounHers();
		getPronounHer();
		getGenderPerson();
		getGenderFemales();
		getCombatSkill();
		getMedicineSkill();
		getTechnologySkill();
		getIngenuitySkill();
		getCharmSkill();
		getRelSunday();
		getRelLin();
		getCompassionSelfserve();
		getCommunalIndependent();
		getLogicalCreative();
		getOptimistPessimist();
    }




/*
    public int convertToInt(string value)
    {
    	int result = 0;
    	try
	       {
	           result = int.Parse(value);
	       }
	       catch (Exception e)
	       {
	           Debug.LogException(e, this);
	       }
	    return result;
    }*/
	


	    void Update()
	    {
	        
	    }
}
