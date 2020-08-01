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
	private nt medicine_skill = 50;
	private int technology_skill = 50;
	private int ingenuity_skill = 50;
	private int charm_skill = 50;

	private int rel_sunday = 50;
	private int rel_lin = 50;

	private int compassion_selfserve = 50;
	private int communal_independent = 50;
	private int logical_creative = 50;
	private int optimist_pessimist = 50;

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

    public void setPronounShe(string value)
    {
    	if(value != null)
    	{
    		pronoun_she = value;
    	}
    }
    public string getPronounShe()
    {
    	return pronoun_she;
    }

    public void setPronounHers(string value)
    {
    	if(value != null)
    	{
    		pronoun_hers = value;
    	}
    }
    public string getPronounHers()
    {
    	return pronoun_hers;
    }

    public void setPronounHer(string value)
    {
    	if(value != null)
    	{
    		pronoun_her = value;
    	}
    }
    public string getPronounHer()
    {
    	return pronoun_her;
    }

    public void setGenderPerson(string value)
    {
    	if(value != null)
    	{
    		gender_person = value;
    	}
    }
    public string getGenderPerson()
    {
    	return gender_person;
    }

    public void setGenderFemales(string value)
    {
    	if(value != null)
    	{
    		gender_females = value;
    	}
    }
    public string getGenderFemales()
    {
    	return gender_females;
    }

	public void setCombatSkill(string value)
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

    public void setMedicineSkill(string value)
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

    public void setTechnologySkill(string value)
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

    public void setIngenuitySkill(string value)
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

    public void setCharmSkill(string value)
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

	public void setRelSunday(string value)
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

    public void setRelLin(string value)
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

    public void setCompassionSelfserve(string value)
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

    public void setCommunalIndependent(string value)
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

    public void setLogicalCreative(string value)
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

    public void setOptimistPessimist(string value)
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




    void Update()
    {
        
    }
}
