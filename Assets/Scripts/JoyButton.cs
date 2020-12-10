using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class JoyButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    [HideInInspector]
    protected bool Pressed;
    // Start is called before the first frame update
    void Start()
    {
        Pressed = true;
    }

    // Update is called once per frame
    void Update()
    {
        Pressed = false;
    }
}
