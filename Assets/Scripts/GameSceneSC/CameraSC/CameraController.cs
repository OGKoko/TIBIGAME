using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    public float speed = 0.1f;
    private GameObject _player;
    void Start()
    {
        if (!_player)
            _player = FindObjectOfType<PlayerInput>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = _player.transform.position + _offset;
        Vector3 desiredPoint = Vector3.Lerp(transform.position, pos, speed);
        transform.position = desiredPoint;

        transform.LookAt(_player.gameObject.transform);
    }
}
