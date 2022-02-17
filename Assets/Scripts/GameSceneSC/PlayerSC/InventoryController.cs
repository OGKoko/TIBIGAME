using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryController : MonoBehaviour
{

    private GameObject collectedPanel;
    private int invSizeDiff;

    [SerializeField]
    private List<GameObject> inventory = new List<GameObject>();
    [SerializeField]
    private int[] itemAmount;
    [SerializeField]
    private List<Sprite> collectiblesSprites = new List<Sprite>();
    public GameObject swapPH;
    [Header("Amount Items text/UI")]
    public Text itemBlauAmount;
    public Text itemGrocAmount;
    public Text itemVerdAmount;
    public Text itemGrisAmount;
    public Text itemOrganicAmount;

    private void Awake()
    {
        collectedPanel = GameObject.FindGameObjectWithTag(GLOBALS.COLLECTED_PANEL_WINDOW);

    }
    void Start()
    {
        //swapPH = GameObject.FindGameObjectWithTag(GLOBALS.SWAP_SPRITE_GARBAGE);
        collectedPanel.SetActive(false);
        invSizeDiff = inventory.Count;
        itemAmount = new int[5];
    }

    // Update is called once per frame
    void Update()
    {
        CheckListSize();
        CollectorPanelSwitch();
    }
    private void LateUpdate()
    {

    }
    private void CheckListSize()
    {
        if (invSizeDiff < inventory.Count || inventory.Count < invSizeDiff)
        {
            collectedPanel.SetActive(true);
            invSizeDiff = inventory.Count;
            this.GetComponent<PlayerController>().DestinationPoint = transform.position;

        }
      
    }
    private void CollectorPanelSwitch()
    {
        if (collectedPanel.activeSelf)
            this.GetComponent<PlayerInput>().InputEnabler = false;
        else
            this.GetComponent<PlayerInput>().InputEnabler = true;
    }

    public void AddItemToInventory(GameObject obj)
    {
        inventory.Add(obj);
    }

    public void inventoryCheckToRemove(GameObject obj)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (LayerMask.LayerToName(inventory[i].gameObject.layer) == LayerMask.LayerToName(obj.gameObject.layer))
            {
                // Debug.Log("Aqui llego");
                inventory.Remove(inventory[i].gameObject);
            }

        }
    }

    public void InventoryAmountDisplay(GameObject go)
    {
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.BLAU)))
        {
            itemAmount[0]++;
            itemBlauAmount.text = "x0" + itemAmount[0].ToString();
           swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.NEWSPAPER_SPRITE];
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GROC)))
        {
            itemAmount[1]++;
            itemGrocAmount.text = "x0" + itemAmount[1].ToString();
            swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.CHIP_BAG_SPRITE];
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.VERD)))
        {
            itemAmount[2]++;
            itemVerdAmount.text = "x0" + itemAmount[2].ToString();
            swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.GLASS_BOTTLE_SPRITE];
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GRIS)))
        {
            itemAmount[3]++;
            itemGrisAmount.text = "x0" + itemAmount[3].ToString();
            swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.FACE_MASK_SPRITE];
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.ORGANIC)))
        {
            itemAmount[4]++;
            itemOrganicAmount.text = "x0" + itemAmount[4].ToString();
            swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.APPLE_SPRITE  ];
        }

    }
    public void ThrowItemGarbage(GameObject go)
    {

        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.BLAU)))
        {
            if (itemAmount[0] > 0)
            {
                itemAmount[0]--;
                itemBlauAmount.text = "x0" + itemAmount[0].ToString();
                swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.NEWSPAPER_SPRITE];
            }
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GROC)))
        {
            if (itemAmount[1] > 0)
            {
                itemAmount[1]--;
                itemGrocAmount.text = "x0" + itemAmount[1].ToString();
                swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.CHIP_BAG_SPRITE];
            }
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.VERD)))
        {
            if (itemAmount[2] > 0)
            {
                itemAmount[2]--;
                itemVerdAmount.text = "x0" + itemAmount[2].ToString();
                swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.GLASS_BOTTLE_SPRITE];
            }
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.GRIS)))
        {
            if (itemAmount[3] > 0)
            {
                itemAmount[3]--;
                itemGrisAmount.text = "x0" + itemAmount[3].ToString();
                swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.FACE_MASK_SPRITE];
            }
        }
        if ((go.gameObject.layer == LayerMask.NameToLayer(GLOBALS.ORGANIC)))
        {
             
            if (itemAmount[4] > 0)
            {
                itemAmount[4]--;
                itemOrganicAmount.text = "x0" + itemAmount[4].ToString();
                swapPH.GetComponent<Image>().sprite = collectiblesSprites[GLOBALS.APPLE_SPRITE];
            }
        }
    }
}
