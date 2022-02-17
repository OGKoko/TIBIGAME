using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ModelRotator : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    Touch touch;
    bool isPressed;
    [SerializeField]
    Transform petHolder;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {

            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    if (touch.deltaPosition.x > 0)
                    {
                        petHolder.Rotate(0, -touch.deltaPosition.x, 0);
                    }
                    else if (touch.deltaPosition.x < 0)
                    {
                        petHolder.Rotate(0, -touch.deltaPosition.x, 0); 
                    }
                }
            }
        }
    }
}
