using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public GameObject[] menuItems;
    public GameObject[] spawnPoints;
    public GameObject rotateAround;
    private float rotateSpeed = 80;
    public int x;
    public string foodItem, plateItems;
    public List<bool> requestedItems = new List<bool>();
    public GameObject checkMark;


    // Start is called before the first frame update
    void Start()
    {
        GenerateOrder();
    }

    // Update is called once per frame
    void Update()
    {
        
        RotateOrderVisuals();
        OrderComplete();
    }

    private void OnTriggerEnter(Collider collider) {
       //Checks If the items on the plate are the correct items.
            switch(collider.tag){
                  case "Kebab":
            requestedItems[0] = false;
            break;
            case "Porkchop":
            requestedItems[1] = false;
            break;
            case "Steak":
            requestedItems[2] = false;
            break;
            case "Orange":
            requestedItems[3] = false;
            break;
            case "Tomato":
            requestedItems[4] = false;
            break;
            }
        
    }

    // Randomizes Order, Shows order rotating above the table
    void GenerateOrder()
    {
        //Gemerates the number of food items the table wants
        int numFoodItems = Random.Range(1,3);

        for (x=0;x<numFoodItems;x++)
        {
            GameObject item;
            
            int randomOrder = Random.Range(0,menuItems.Length);

           item = Instantiate(menuItems[randomOrder], spawnPoints[x].transform.position, spawnPoints[x].transform.rotation);
           item.transform.SetParent(spawnPoints[x].transform);
           
         //Checks the orders tag and sets the table to what item it needs to complete the order
         foodItem = item.tag;
         CheckOrderFoods();
        }
        

    }

    //Rotates the food items above the table
    void RotateOrderVisuals()
    {
        spawnPoints[0].transform.RotateAround(rotateAround.transform.position,Vector3.down, rotateSpeed *Time.deltaTime);
        spawnPoints[1].transform.RotateAround(rotateAround.transform.position,Vector3.down, rotateSpeed *Time.deltaTime);
        spawnPoints[2].transform.RotateAround(rotateAround.transform.position,Vector3.down, rotateSpeed *Time.deltaTime);
    }

    void CheckOrderFoods()
    {
        
        switch(foodItem){
            case "Kebab":
            requestedItems[0] = true;
            break;
            case "Porkchop":
            requestedItems[1] = true;
            break;
            case "Steak":
            requestedItems[2] = true;
            break;
            case "Orange":
            requestedItems[3] = true;
            break;
            case "Tomato":
            requestedItems[4] = true;
            break;
        }
    }

    //Checks if all the items are all taken
    void OrderComplete()
    {
        if(!requestedItems.Contains(true))
        {
            Debug.Log("Order Complete");
            deleteIcons();
            checkMark.gameObject.SetActive(true);
        }
    }

    // Checks if the spawnpoint has a child, if true destroy
    void deleteIcons()
    {
        if (spawnPoints[0].transform.childCount > 0)
        {
             Destroy(spawnPoints[0].transform.GetChild(0).gameObject);
        }
        
        if (spawnPoints[1].transform.childCount > 0)
        {
             Destroy(spawnPoints[1].transform.GetChild(0).gameObject);
        }
        
        if (spawnPoints[2].transform.childCount > 0)
        {
             Destroy(spawnPoints[2].transform.GetChild(0).gameObject);
        }
       
       
    }
}
