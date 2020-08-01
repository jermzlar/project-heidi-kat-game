using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private MainMenu mainMenu = null;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mainMenu.isMenuOpen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (mainMenu.menuPanel.alpha == 0)
            mainMenu.isMenuOpen = false;
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
