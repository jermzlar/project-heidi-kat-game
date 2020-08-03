using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private MainMenu mainMenu = null;

    [SerializeField]
    private InkManager inkManager = null;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mainMenu.isMenuOpen = true;
        //inkManager.stopClick = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (mainMenu.menuPanel.alpha == 0)
            mainMenu.isMenuOpen = false;
        //inkManager.stopClick = false;
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
