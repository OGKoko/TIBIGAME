using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(NavMeshAgent))]
public class PlayerController : MonoBehaviour
{

    private NavMeshAgent _navMeshAgent;
    private PlayerInput _playerInput;
    private Vector3 _finalPoint;
    
    public Vector3 DestinationPoint { get { return _finalPoint; } 
                                      set { _finalPoint = value; }}
    void Start()
    {
        if(!TryGetComponent(out _playerInput))
            Debug.LogWarning("BRO MISSING PLAYER INPUT SYSTEM");

        if (!TryGetComponent(out _navMeshAgent))
            Debug.LogWarning("LA NAVEGACION DE AGENTES NO VA");

        _finalPoint = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        _navMeshAgent.SetDestination(_finalPoint);
    }

   
}
