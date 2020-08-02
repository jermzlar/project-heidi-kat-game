using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

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

	[SerializeField]
	private Text combat_skill = null;

	[SerializeField]
	private Text ingenuity_skill = null;

	[SerializeField]
	private Text medicine_skill = null;

	[SerializeField]
	private Text charm_skill = null;

	[SerializeField]
	private Text technology_skill = null;

	[SerializeField]
	private Image sunday_rel = null;

	[SerializeField]
	private Image lin_rel = null;

	[SerializeField]
	private Slider slider_Optimistic_Pessimistic;

	[SerializeField]
	private Slider slider_Logcial_Creative;

	[SerializeField]
	private Slider slider_Independent_Communal;

	[SerializeField]
	private Slider slider_Logcial_Compassionate_SelfServing;


    void Start()
    {
    	closedPosition = transform.position;
    	openedPosition = closedPosition - new Vector3(0.0f, 100.0f, 0.0f);
        transform.GetComponent<Image>().sprite = statBoxNoGlow;
    }

    public void toggleStatBox()
    {
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

    public void SetCombatStat(string value)
    {
    	combat_skill.text = value;
    }

    public void SetIngenuityStat(string value)
    {
    	ingenuity_skill.text = value;
    }

    public void SetMedicineStat(string value)
    {
    	medicine_skill.text = value;
    }

    public void SetCharmStat(string value)
    {
    	charm_skill.text = value;
    }

    public void SetTechnologyStat(string value)
    {
    	technology_skill.text = value;
    }

    public void SetSundayRel(float value)
    {
    	sunday_rel.fillAmount = value;
    }

    public void SetLinRel(float value)
    {
    	lin_rel.fillAmount = value;
    }

    public void SetSliderOptimisticPessimistic(float value)
    {
    	slider_Optimistic_Pessimistic.value = value;
    }

    public void SetSliderLogcialCreative(float value)
    {
    	slider_Logcial_Creative.value = value;
    }

    public void SetSliderIndependentCommunal(float value)
    {
    	slider_Independent_Communal.value = value;
    }

    public void SetSliderLogcialCompassionateSelfServing(float value)
    {
    	slider_Logcial_Compassionate_SelfServing.value = value;
    }

}
