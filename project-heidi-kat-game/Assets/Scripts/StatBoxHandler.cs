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

    //Used for animation
    private float progress = 0f;
    private float moveSpd = 3.0f;
    private bool IsRunning = false;
    public Vector3 startPosition = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 endPosition = new Vector3(0.0f, 0.0f, 0.0f);


    void Start()
    {
    	closedPosition = transform.position;
    	openedPosition = closedPosition - new Vector3(0.0f, 100.0f, 0.0f);
        transform.GetComponent<Image>().sprite = statBoxNoGlow;
        startPosition = transform.GetComponent<RectTransform>().position;
        endPosition = openedPosition;
    }

    public void toggleStatBox()
    {
    	if (isStatBoxClosed)
    	{
    		changeSpriteToClosed(false);
            MoveStatBoxToOpened();
    		isStatBoxClosed = false;
    	}
    	else
    	{
    		changeSpriteToClosed(true);
            MoveStatBoxToClosed();
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

    public void MoveStatBoxToOpened()
    {
        if (IsRunning == false)
        {
            StartCoroutine(AnimateMovingDown());
        }
    }

    public void MoveStatBoxToClosed()
    {
        if (IsRunning == false)
        {
            StartCoroutine(AnimateMovingUp());
        }
    }

    IEnumerator AnimateMovingDown()
    {
        IsRunning = true;
        progress = 0;
        transform.GetComponent<CanvasGroup>().interactable = false;
        while (progress != 1f)
        { 
            progress = progress + moveSpd * Time.deltaTime;
            progress = Mathf.Clamp(progress, 0f, 1f);
            transform.position = Vector3.Lerp(startPosition, endPosition, progress);
            yield return null;
        }
        transform.GetComponent<CanvasGroup>().interactable = true;
        IsRunning = false;
        yield return null;
    }

    IEnumerator AnimateMovingUp()
    {
        IsRunning = true;
        progress = 1;
        transform.GetComponent<CanvasGroup>().interactable = false;
        while (progress != 0f)
        { 
            progress = progress - moveSpd * Time.deltaTime;
            progress = Mathf.Clamp(progress, 0f, 1f);
            transform.GetComponent<RectTransform>().position = Vector3.Lerp(startPosition, endPosition, progress);
            yield return null;
        }
        transform.GetComponent<CanvasGroup>().interactable = true;
        IsRunning = false;
        yield return null;
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

    public void SetSliderCompassionateSelfServing(float value)
    {
    	slider_Logcial_Compassionate_SelfServing.value = value;
    }

}
