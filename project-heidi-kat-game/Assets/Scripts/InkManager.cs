using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using System.Linq;

public class InkManager : MonoBehaviour
{

	[SerializeField]
	private TextAsset inkJSONAsset = null;
	public Story story;

	[SerializeField]
	private Canvas canvas = null;

	[SerializeField]
	private DialogueChoices dialogueChoices = null;

	[SerializeField]
	private GlobalVariables globalVariables = null;

	[SerializeField]
	private CharacterManager characterManager = null;

	[SerializeField]
	private BackgroundHandler backgroundHandler= null;

	[SerializeField]
	private SoundManager soundManager = null;

	[SerializeField]
	private MusicManager musicManager = null;

	[SerializeField]
	private Text conversation = null;

	[SerializeField]
	private MainMenu mainMenu = null;

	[SerializeField]
	private string logOfDialogue = null;

	public bool stopClick = false;

	[SerializeField]
	private string nameOfTalker = null;

	private bool switchNameOnClick = false;

	private bool clickToContinue = false;
	private bool clearText = false;
	public static event Action<Story> OnCreateStory;
    void Start () {
		characterManager.DisplayName("nobody");
		characterManager.DetermineCharacterA("none");
		characterManager.DetermineCharacterB("none");
		StartStory();
		story.ObserveVariable("whos_talking", (string varName, object newValue) =>
		{ SetDisplayName((string)newValue); });
		story.ObserveVariable("whos_talking_button", (string varName, object newValue) =>
		{ SetDisplayNameOnButton((string)newValue); });
		story.ObserveVariable("character_a", (string varName, object newValue) =>
		{ characterManager.DetermineCharacterA((string)newValue); });
		story.ObserveVariable("character_b", (string varName, object newValue) =>
		{ characterManager.DetermineCharacterB((string)newValue); });

		story.ObserveVariable("background", (string varName, object newValue) =>
		{ backgroundHandler.ChangeBackground((string)newValue); });

		story.ObserveVariable("sound_cue", (string varName, object newValue) =>
		{ soundManager.PlaySound((string)newValue); });

		story.ObserveVariable("music_cue", (string varName, object newValue) =>
		{ soundManager.PlaySound((string)newValue); });

		//Starting cues
		backgroundHandler.ChangeBackground((string)story.variablesState["background"]);
		musicManager.HandleMusic((string)story.variablesState["music_cue"]);



	}

	private void SetDisplayName(string name)
    {
			characterManager.DisplayName(name);
    }

	private void SetDisplayNameOnButton(string name)
    {
		switchNameOnClick = true;
		nameOfTalker = name;
    }

	// Creates a new Story object with the compiled story which we can then play!
	public void StartStory () {
		story = new Story (inkJSONAsset.text);
		ClearText();
		/*Binding external functions example
		story.BindExternalFunction("place_actors",(string leftName, string rightName)=>
		{
			cm.PlaceActors(leftName, rightName);
		});
		story.BindExternalFunction("change_stat",(string stat, string ID)=>
		{
			cm.ChangeActorStat(stat, ID);
		});*/
        if(OnCreateStory != null) OnCreateStory(story);
		RefreshView();
	}
	
	// This is the main function called every time the story changes. It does a few things:
	// Destroys all the old content and choices.
	// Continues over all the lines of text, then displays all the choices. If there are no choices, the story is finished!
	void RefreshView () {

		// Remove all the UI on screen
		dialogueChoices.RemoveAllButtons();
		

		string dialogueText = conversation.text;
		// Read all the content until we can't continue any more
		if (story.canContinue) {
			// Continue gets the next line of the story
			string text = story.Continue();
			globalVariables.refreshAll();

			// This removes any white space from the text.
			text = text.Trim();
			// Display the text on screen! If Log was empty
			if (text == "" && !story.canContinue)
			{
				RefreshView();
				return;
			}
			else 
			{
				dialogueText = text;
				logOfDialogue = logOfDialogue + "\n" + text;
			}


			CreateContentView(dialogueText);

		}

		// Display all the choices, if there are any!
		if (story.currentChoices.Count > 0)
		{
			if (!dialogueChoices.panelAlpha)
				dialogueChoices.ToggleDialogueChoice();
			for (int i = 0; i < story.currentChoices.Count; i++)
			{
				Choice choice = story.currentChoices[i];

				Button newButton = dialogueChoices.AddButton(choice);
				newButton.onClick.AddListener(delegate
				{
					OnClickChoiceButton(choice);
				});

			}
			
			dialogueChoices.Resize();
		}
		// If we've read all the content and there's no choices, the story is finished!
		else
		{
			if (!story.canContinue)
			{
				dialogueChoices.RestartButton("End of story.\nRestart?");
				dialogueChoices.Resize();
			}
			else
			{
				if (dialogueText == "")
					RefreshView();
				else
				{
					//SetDisplayName((string)story.variablesState["whos_talking"]);
					clickToContinue = true;
					if (dialogueChoices.panelAlpha)
						dialogueChoices.ToggleDialogueChoice();
				}
            }
		}
	}

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton (Choice choice) {
		story.ChooseChoiceIndex (choice.index);
		if (switchNameOnClick)
		{
			characterManager.DisplayName(nameOfTalker);
			switchNameOnClick = false;
		}
		nameOfTalker = ((string)story.variablesState["whos_talking"]);
		ClearText();
		RefreshView();
	}

	// Creates a textbox showing the the line of text
	void CreateContentView (string text) {
		conversation.text = text;
	}

	private void ClearText()
    {
		conversation.text = "";
    }

    private void Update()
    {
        if (clickToContinue && !mainMenu.isMenuOpen && !stopClick)
			if(Input.GetMouseButtonDown(0))
            {
				clickToContinue = false;
				RefreshView();
				
            }
    }


}
