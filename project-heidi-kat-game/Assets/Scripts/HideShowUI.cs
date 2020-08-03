using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideShowUI : MonoBehaviour
{
    [SerializeField]
    public CanvasGroup dialogueChoices = null;

    [SerializeField]
    public CanvasGroup statusBox = null;

    [SerializeField]
    public CanvasGroup dialogueBox = null;

    [SerializeField]
    public Sprite showUI = null;

    [SerializeField]
    public Sprite hideUI = null;

    [SerializeField]
    public InkManager inkManager = null;
    private Image buttonImage;

    public void Toggle()
    {
        if (dialogueBox.alpha == 1)
        {
            ToggleCanvasGroups(false);
            ToggleButtonImage(false);
            inkManager.stopClick = true;

        }
        else
        {
            ToggleCanvasGroups(true);
            ToggleButtonImage(true);
            inkManager.stopClick = false;

        }


    }

    public void ToggleCanvasGroups(bool toggle)
    {
        if (toggle)
        {
            dialogueChoices.alpha = 1;
            dialogueChoices.blocksRaycasts = true;
            dialogueChoices.interactable = true;

            statusBox.alpha = 1;
            statusBox.blocksRaycasts = true;
            statusBox.interactable = true;

            dialogueBox.alpha = 1;
            dialogueBox.blocksRaycasts = true;
            dialogueBox.interactable = true;
        }
        else
        {
            dialogueChoices.alpha = 0;
            dialogueChoices.blocksRaycasts = false;
            dialogueChoices.interactable = false;

            statusBox.alpha = 0;
            statusBox.blocksRaycasts = false;
            statusBox.interactable = false;

            dialogueBox.alpha = 0;
            dialogueBox.blocksRaycasts = false;
            dialogueBox.interactable = false;
        }
    }

    public void ToggleButtonImage(bool toggle)
    {
        if (toggle)
            buttonImage.sprite = showUI;
        else
            buttonImage.sprite = hideUI;
    }


    // Start is called before the first frame update
    void Start()
    {
        buttonImage = transform.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
