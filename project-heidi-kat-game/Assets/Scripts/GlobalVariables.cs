using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    private string player_name = "Butts";
    [SerializeField]
    private string whos_talking = "player";
	
    [SerializeField]
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
    		player_name = value;
    	}
    }
    public string getPlayerName()
    {
    	return player_name;
    }

    public void setWhosTalking(string value)
    {
        if(value != null)
        {
            whos_talking = value;
        }
    }
    public string getWhosTalking()
    {
        return whos_talking;
    }

	public void setCombatSkill(int value)
    {
    	if(value != null)
    	{
    		combat_skill = value;
    	}
    }
    public int getCombatSkill()
    {
    	return combat_skill;
    }

    public void setMedicineSkill(int value)
    {
    	if(value != null)
    	{
    		medicine_skill = value;
    	}
    }
    public int getMedicineSkill()
    {
    	return medicine_skill;
    }

    public void setTechnologySkill(int value)
    {
    	if(value != null)
    	{
    		technology_skill = value;
    	}
    }
    public int getTechnologySkill()
    {
    	return technology_skill;
    }

    public void setIngenuitySkill(int value)
    {
    	if(value != null)
    	{
    		ingenuity_skill = value;
    	}
    }
    public int getIngenuitySkill()
    {
    	return ingenuity_skill;
    }

    public void setCharmSkill(int value)
    {
    	if(value != null)
    	{
    		charm_skill = value;
    	}
    }
    public int getCharmSkill()
    {
    	return charm_skill;
    }

	public void setRelSunday(int value)
    {
    	if(value != null)
    	{
    		rel_sunday = value;
    	}
    }
    public int getRelSunday()
    {
    	return rel_sunday;
    }

    public void setRelLin(int value)
    {
    	if(value != null)
    	{
    		rel_lin = value;
    	}
    }
    public int getRelLin()
    {
    	return rel_lin;
    }

    public void setCompassionSelfserve(int value)
    {
    	if(value != null)
    	{
    		compassion_selfserve = value;
    	}
    }
    public int getCompassionSelfserve()
    {
    	return compassion_selfserve;
    }

    public void setCommunalIndependent(int value)
    {
    	if(value != null)
    	{
    		communal_independent = value;
    	}
    }
    public int getCommunalIndependent()
    {
    	return communal_independent;
    }

    public void setLogicalCreative(int value)
    {
    	if(value != null)
    	{
    		logical_creative = value;
       	}
    }
    public int getLogicalCreative()
    {
    	return logical_creative;
    }

    public void setOptimistPessimist(int value)
    {
    	if(value != null)
    	{
    		optimist_pessimist = value;
    	}
    }
    public int getOptimistPessimist()
    {
    	return optimist_pessimist;
    }

    public void refreshAll()
    {
        setPlayerName((string)im.story.variablesState["player_name"]);
        setWhosTalking((string)im.story.variablesState["whos_talking"]);
        setCombatSkill((int)im.story.variablesState["combat_skill"]);
        setMedicineSkill((int)im.story.variablesState["medicine_skill"]);
        setTechnologySkill((int)im.story.variablesState["technology_skill"]);
        setIngenuitySkill((int)im.story.variablesState["ingenuity_skill"]);
        setCharmSkill((int)im.story.variablesState["charm_skill"]);
        setRelSunday((int)im.story.variablesState["rel_sunday"]);
        setRelLin((int)im.story.variablesState["rel_lin"]);
        setCompassionSelfserve((int)im.story.variablesState["compassion_selfserve"]);
        setCommunalIndependent((int)im.story.variablesState["communal_independent"]);
        setLogicalCreative((int)im.story.variablesState["logical_creative"]);
        setOptimistPessimist((int)im.story.variablesState["optimist_pessimist"]);

    }

	    void Update()
	    {
	        
	    }
}
