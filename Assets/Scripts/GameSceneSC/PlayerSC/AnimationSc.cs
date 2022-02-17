using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSc : MonoBehaviour
{
    PlayerController player;
    Animator playerAnimator;
   
    void Start()
    {
        player = GetComponent<PlayerController>();
        playerAnimator = GetComponentInChildren<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {

      if(player.DestinationPoint.x != transform.position.x)
                playerAnimator.SetBool(GLOBALS.WALKING_ANIM, true);
            else
                playerAnimator.SetBool(GLOBALS.WALKING_ANIM, false);


     
    }
    
}
