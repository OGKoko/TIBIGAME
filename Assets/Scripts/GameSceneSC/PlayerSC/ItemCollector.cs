using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemCollector : MonoBehaviour
{
    InventoryController inventory;
    [SerializeField]
    Animator playerAnim;
    public ParticleSystem collectedPart;
    private void Start()
    {
        inventory = this.GetComponentInParent<InventoryController>();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
   
    private void OnTriggerEnter(Collider hit)
    {
        // si es un item collectable
        if (hit.gameObject.tag == GLOBALS.LAYER_COLLECT)
        {
            playerAnim.SetTrigger(GLOBALS.COLLECT_ANIM);
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.BLAU))
            {
                inventory.AddItemToInventory(hit.gameObject);
                inventory.InventoryAmountDisplay(hit.gameObject);
                hit.gameObject.SetActive(false);
                collectedPart.Play();
                // Debug.Log(hit.gameObject + " collected");
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GROC))
            {
                inventory.AddItemToInventory(hit.gameObject);
                inventory.InventoryAmountDisplay(hit.gameObject);
                hit.gameObject.SetActive(false);
                collectedPart.Play();
                // Debug.Log(hit.gameObject + " collected");
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GRIS))
            {
                inventory.AddItemToInventory(hit.gameObject);
                inventory.InventoryAmountDisplay(hit.gameObject);
                hit.gameObject.SetActive(false);
                collectedPart.Play();
                // Debug.Log(hit.gameObject + " collected");
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.ORGANIC))
            {
                inventory.AddItemToInventory(hit.gameObject);
                inventory.InventoryAmountDisplay(hit.gameObject);
                hit.gameObject.SetActive(false);
                collectedPart.Play();
                // Debug.Log(hit.gameObject + " collected");
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.VERD))
            {
                inventory.AddItemToInventory(hit.gameObject);
                inventory.InventoryAmountDisplay(hit.gameObject);
                hit.gameObject.SetActive(false);
                collectedPart.Play();
                // Debug.Log(hit.gameObject + " collected");
            }

        }
     
        //si es una papelera
        if (hit.gameObject.tag == GLOBALS.GARBAGE)
        {
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.BLAU))
            {
                inventory.inventoryCheckToRemove(hit.gameObject);
                inventory.ThrowItemGarbage(hit.gameObject);
                // Debug.Log("dandole a "+hit.gameObject);
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.ORGANIC))
            {
                inventory.inventoryCheckToRemove(hit.gameObject);
                inventory.ThrowItemGarbage(hit.gameObject);
                // Debug.Log("dandole a "+hit.gameObject);
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.VERD))
            {
                inventory.inventoryCheckToRemove(hit.gameObject);
                inventory.ThrowItemGarbage(hit.gameObject);
                // Debug.Log("dandole a "+hit.gameObject);
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GROC))
            {
                inventory.inventoryCheckToRemove(hit.gameObject);
                inventory.ThrowItemGarbage(hit.gameObject);
                // Debug.Log("dandole a "+hit.gameObject);
            }
            if (hit.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GRIS))
            {
                inventory.inventoryCheckToRemove(hit.gameObject);
                inventory.ThrowItemGarbage(hit.gameObject);
                // Debug.Log("dandole a "+hit.gameObject);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
      /*  if (other.gameObject.tag == GLOBALS.LAYER_COLLECT)
            isCollecting = false;*/
    }

}
