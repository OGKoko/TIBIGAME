using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorPaneSC : MonoBehaviour
{
    GameObject petHolder, petsInstance;
    void Start()
    {
        petHolder = GameObject.FindGameObjectWithTag("PetHolder");
        petsInstance = GameObject.FindGameObjectWithTag("PetInstance");
        petHolder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        PetCleaner();
    }
    void LateUpdate()
    {
        if (this.gameObject.activeSelf)
            petHolder.SetActive(false);
    }
    public void GoBack()
    {
      
        gameObject.SetActive(false);
        petHolder.SetActive(true);
    }
    public void OpenPanel()
    {
        gameObject.SetActive(true);
    }
    void PetCleaner()
    {
        if (petHolder.activeSelf == false)
        {
            for (int i = 0; i < petsInstance.transform.childCount; i++)
            {
                Destroy(petsInstance.transform.GetChild(i).gameObject);
            }
        }
    }
}
