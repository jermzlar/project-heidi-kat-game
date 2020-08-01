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
        else
        {
            ToggleNamePlate(true);
            nameText.text = name;
        }

    }

    public void Resize(float size)
    {
        nameBox.GetComponent<RectTransform>().sizeDelta = new Vector2(size, 50);
    }

    void Update()
    {
        
    }







}
