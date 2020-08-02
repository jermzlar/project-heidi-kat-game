using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Examples : MonoBehaviour
{


    [SerializeField]
    public RectTransform startPosition = null;

    [SerializeField]
    public RectTransform endPosition = null;
    
    [SerializeField]
    private float progress = 0f;

    private float moveSpd = .5f;

    private bool IsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<RectTransform>().position = startPosition.position;
    }

    public void MoveSquare()
    {
        if (IsRunning == false)
            StartCoroutine(UpdatePosition());
    }

    IEnumerator UpdatePosition()
    {
        IsRunning = true;
        progress = 1;
        transform.GetComponent<CanvasGroup>().interactable = false;
        while (progress != 0f)
        { 
            progress = progress - moveSpd * Time.deltaTime;
            progress = Mathf.Clamp(progress, 0f, 1f);
            transform.GetComponent<RectTransform>().position = Vector3.Lerp(startPosition.position, endPosition.position, progress);
            yield return null;
        }
        transform.GetComponent<CanvasGroup>().interactable = true;
        IsRunning = false;
        yield return null;


    }

    // Update is called once per frame
    void Update()
    {
        

        //    objectPosition = Vector3.Lerp(startPosition, endPosition, progress);
        //transform.GetComponent<RectTransform>().position = objectPosition;
    }
}
