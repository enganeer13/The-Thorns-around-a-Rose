using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pickup : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itemButton;
    


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void Update()
    {
        if(GameVariables.keyCount == 1)
        {
            
            //Debug.Log("door is now unlocked.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Current Key count: " + GameVariables.keyCount);
        if(other.CompareTag("Player"))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    //Item can be added to the inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);

                    GameVariables.keyCount++;
                    //Debug.Log("key added");
                    break;
                }
            }
        }
        //Debug.Log("Final Key count: " + GameVariables.keyCount);
    }

}
