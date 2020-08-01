﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class DialogueChoices : MonoBehaviour
{

    [SerializeField]
    private GameObject buttonPrefab = null;
    [SerializeField]
    private Transform dialogueBox = null;
    [SerializeField]
    InkManager ink_manager = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Resize()
    {

    }

    public void RemoveAllButtons()
    {
        int childCount = dialogueBox.childCount;
        for (int i = childCount - 1; i >= 0; --i)
        {
            GameObject.Destroy(dialogueBox.GetChild(i).gameObject);
        }
    }

    public void AddButton(Choice choice)
    {
        Button newChoice = Instantiate(buttonPrefab, dialogueBox).GetComponent<Button>();
        Text dialogueText = newChoice.GetComponentInChildren<Text>();
        dialogueText.text = choice.text;
        newChoice.onClick.AddListener(delegate { OnClickChoiceButton(choice); });
    }

    private void OnClickChoiceButton (Choice choice)
    {
        ink_manager.story.ChooseChoiceIndex(choice.index);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
