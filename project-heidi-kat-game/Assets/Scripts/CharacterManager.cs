using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    private Transform characterA = null;

    [SerializeField]
    private Transform characterB = null;

    [SerializeField]
    private List<Sprite> sprites = null;

    [SerializeField]
    private GlobalVariables globalVariables = null;

    [SerializeField]
    private Transform nameBox = null;
    [SerializeField]
    private CanvasGroup nameBoxCanvasGroup = null;
    private Text nameText = null;

    void Start()
    {
        nameText = nameBox.GetComponentInChildren<Text>();
        nameBoxCanvasGroup = nameBox.GetComponent<CanvasGroup>();
    }

    public void ToggleNamePlate(bool toggle)
    {
        if (toggle)
        {
            nameBoxCanvasGroup.alpha = 1;
            
        }
        else
            nameBoxCanvasGroup.alpha = 0;
    }

    public void DisplayName(string name)
    {
        if (string.Equals(name,"nobody"))
        {
            ToggleNamePlate(false);
        }
        else if (string.Equals(name,"mc"))
        {
            ToggleNamePlate(true);
            nameText.text = globalVariables.getPlayerName();

        }
        else if (string.Equals(name, "stranger"))
        {
            ToggleNamePlate(true);
            nameText.text = "Stranger";

        }
        else if (string.Equals(name, "sunday"))
        {
            ToggleNamePlate(true);
            nameText.text = "Sunday";

        }
        else if (string.Equals(name, "lin"))
        {
            ToggleNamePlate(true);
            nameText.text = "L-1N";

        }
        else
        {
            ToggleNamePlate(true);
            nameText.text = name;
        }

    }

    public void DetermineCharacterA(string value)
    {
        switch (value)
        {
            case "nobody":
                ToggleCharacterA(false);    
                break;
            case "sunday":
                ToggleCharacterA(true);
                break;
            default:
                break;
        }
    }

    public void DetermineCharacterB(string value)
    {
        switch (value)
        {
            case "nobody":
                ToggleCharacterB(false);
                break;
            case "lin":
                ToggleCharacterB(true);
                break;
            default:
                break;
        }
    }



    public void ToggleCharacterA(bool toggle)
    {
        if (toggle)
            characterA.GetComponent<CanvasGroup>().alpha = 1;
        else
            characterA.GetComponent<CanvasGroup>().alpha = 0;
    }
    
    public void ToggleCharacterB(bool toggle)
    {

        if (toggle)
            characterB.GetComponent<CanvasGroup>().alpha = 1;
        else
            characterB.GetComponent<CanvasGroup>().alpha = 0;

    }



    public void Resize(float size)
    {
        nameBox.GetComponent<RectTransform>().sizeDelta = new Vector2(size, 50);
    }

    void Update()
    {
        
    }







}
