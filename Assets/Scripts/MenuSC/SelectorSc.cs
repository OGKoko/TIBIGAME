using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSc : MonoBehaviour
{
    public GameObject[] pets;
    [SerializeField]
    SelectorPaneSC SelectorPanelSc;
    int petIdx;
    void Start()
    {
        InstantiatePet();
    }

    public void InstantiatePet()
    {
        Instantiate(pets[petIdx], transform.position, transform.rotation, transform);
    }
    void Update()
    {
        
    }
    public void WildPigSelector()
    {
        petIdx = 0;
        InstantiatePet();
        SelectorPanelSc.GoBack();
        
    }
    public void FoxSelector()
    {
        petIdx = 1;
        InstantiatePet();
        SelectorPanelSc.GoBack();
    }

}
