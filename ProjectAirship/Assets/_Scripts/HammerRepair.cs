using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve;

public class HammerRepair : MonoBehaviour
{
    public GameObject brokenItem;
    public GameObject damagedItem;
    public GameObject crackedItem;
    public GameObject fixedItem;

    void Start()
    {
        brokenItem.SetActive(true);
        damagedItem.SetActive(false);
        crackedItem.SetActive(false);
        fixedItem.SetActive(false);
    }

    public void OnTriggerEnter(Collider hammer)
    {
        if(hammer.tag == "brokenItem")
        {
            brokenItem.SetActive(false);
            damagedItem.SetActive(true);
        }
        if (hammer.tag == "damagedItem")
        {
            damagedItem.SetActive(false);
            crackedItem.SetActive(true);
        }
        if (hammer.tag == "crackedItem")
        {
            crackedItem.SetActive(false);
            fixedItem.SetActive(true);
        }
    }
}
