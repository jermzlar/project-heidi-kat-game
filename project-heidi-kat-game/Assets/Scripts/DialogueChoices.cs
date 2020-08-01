using System.Collections;
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
    [SerializeField]
    private int boxSize = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Resize()
    {
        int childCount = ink_manager.story.currentChoices.Count;
        Debug.Log("number of children " + childCount);
        boxSize = (childCount * 50) + 20;
        RectTransform rt = dialogueBox.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(620, boxSize);
    }

    public void RemoveAllButtons()
    {
        int childCount = dialogueBox.childCount;
        for (int i = childCount - 1; i >= 0; --i)
        {
            GameObject.Destroy(dialogueBox.GetChild(i).gameObject);
        }
    }

    public Button AddButton(Choice choice)
    {
        Button newChoice = Instantiate(buttonPrefab, dialogueBox).GetComponent<Button>();
        Text dialogueText = newChoice.GetComponentInChildren<Text>();
        dialogueText.text = choice.text;
        return newChoice;
    }

    //restart story
    public void RestartButton(string restart)
    {
        Button newChoice = Instantiate(buttonPrefab, dialogueBox).GetComponent<Button>();
        Text dialogueText = newChoice.GetComponentInChildren<Text>();
        dialogueText.text = restart;
        newChoice.onClick.AddListener(delegate {
            ink_manager.StartStory();
        });
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
