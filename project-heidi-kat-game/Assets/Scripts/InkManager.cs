using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

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
	private Text conversation = null;

	public static event Action<Story> OnCreateStory;
    void Start () {
		StartStory();
	}

	// Creates a new Story object with the compiled story which we can then play!
	public void StartStory () {
		story = new Story (inkJSONAsset.text);
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


		// Read all the content until we can't continue any more
		while (story.canContinue) {
			// Continue gets the next line of the story
			string text = story.Continue ();
			// This removes any white space from the text.
			text = text.Trim();
			// Display the text on screen!
			CreateContentView(text);
		}

		// Display all the choices, if there are any!
		if(story.currentChoices.Count > 0) {
			for (int i = 0; i < story.currentChoices.Count; i++) {
				Choice choice = story.currentChoices [i];

				Button newButton =dialogueChoices.AddButton(choice);
				newButton.onClick.AddListener(delegate {
					OnClickChoiceButton(choice);
				});
				
			}
			dialogueChoices.Resize();
		}
		// If we've read all the content and there's no choices, the story is finished!
		else {

			dialogueChoices.RestartButton("End of story.\nRestart?");
			dialogueChoices.Resize();

		}
	}

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton (Choice choice) {
		story.ChooseChoiceIndex (choice.index);
		RefreshView();
	}

	// Creates a textbox showing the the line of text
	void CreateContentView (string text) {
		conversation.text = text;
	}
	

}
