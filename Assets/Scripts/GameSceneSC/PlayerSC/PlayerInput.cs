using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private bool _clicked;
    private bool _paused;
    private bool _showInteractable;
    [SerializeField] private bool _inputEnable;

    public bool Clicked { get { return _clicked; } }
    public bool Paused { get { return _paused; } }
    public bool ShowInteractable { get { return _showInteractable; } }
    public bool InputEnabler { get { return _inputEnable; } 
                               set{ _inputEnable = value; }}

    private Vector3 _mousePos;
    public Vector3 MousePosition { get { return _mousePos; } }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_inputEnable)
        {
            _clicked = Input.GetButtonDown(GLOBALS.FINGER_INPUT);
            _mousePos = Input.mousePosition; 
        }
        else
        {
            _clicked = false;
            _mousePos = Vector3.zero;
        }
    }
}
