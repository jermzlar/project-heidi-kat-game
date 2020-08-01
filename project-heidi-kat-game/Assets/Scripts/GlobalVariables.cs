using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    private string player_name = "Butts";
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

    public void setAll()
    {
        setPlayerName(player_name);
        setCombatSkill(combat_skill);
        setMedicineSkill(medicine_skill);
        setTechnologySkill(technology_skill);
        setIngenuitySkill(ingenuity_skill);
        setCharmSkill(charm_skill);
        setRelSunday(rel_sunday);
        setRelLin(rel_lin);
        setCompassionSelfserve(compassion_selfserve);
        setCommunalIndependent(communal_independent);
        setLogicalCreative(logical_creative);
        setOptimistPessimist(optimist_pessimist);

    }
    public void getAll()
    {
    	player_name = getPlayerName();
		combat_skill = getCombatSkill();
		medicine_skill = getMedicineSkill();
		technology_skill = getTechnologySkill();
		ingenuity_skill = getIngenuitySkill();
		charm_skill = getCharmSkill();
		rel_sunday = getRelSunday();
		rel_lin = getRelLin();
		compassion_selfserve = getCompassionSelfserve();
		communal_independent = getCommunalIndependent();
		logical_creative = getLogicalCreative();
		optimist_pessimist = getOptimistPessimist();
    }

	    void Update()
	    {
	        
	    }
}
