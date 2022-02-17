using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerController))]
public class ClickManager : MonoBehaviour
{
    private PlayerController _playerController;
    private PlayerInput _playerInput;
    private Vector3 _finalPoint;
    private Camera _camera;

    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent(out _playerController))
            Debug.LogWarning("BROSKI EL PLAYER CONTROLLER");

        if (!TryGetComponent(out _playerInput))
            Debug.LogWarning("BROSKI EL PLAYER INPUT");

        _camera = _camera ?? Camera.main ?? FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerInput.Clicked)
        {

            var ray = _camera.ScreenPointToRay(_playerInput.MousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                _playerController.DestinationPoint = hit.point;
            }
        }
    }
}
