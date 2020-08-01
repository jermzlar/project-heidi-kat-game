using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField]
    private CanvasGroup blackOutPanel;

    public CanvasGroup menuPanel;
    [SerializeField]
    public bool isMenuOpen = false;


    public void ToggleMenu(bool toggle)
    {
        if (toggle)
        {
            blackOutPanel.alpha = 1;
            blackOutPanel.blocksRaycasts = true;
            menuPanel.alpha = 1;
            menuPanel.interactable = true;
            menuPanel.blocksRaycasts = true;
            isMenuOpen = true;
        }
        else
        {
            blackOutPanel.alpha = 0;
            blackOutPanel.blocksRaycasts = false;
            menuPanel.alpha = 0;
            menuPanel.interactable = false;
            menuPanel.blocksRaycasts = false;
            isMenuOpen = false;
        }
    }

    public void ToggleMenu()
    {
        if (menuPanel.alpha == 0)
        {
            ToggleMenu(true);
        }
        else
        {
            ToggleMenu(false);
        }
    }

    private void Awake()
    {
        menuPanel = transform.GetComponent<CanvasGroup>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
