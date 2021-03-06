using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public GameObject[] menuItems;
    public GameObject[] spawnPoints;
    public GameObject rotateAround;
    private float rotateSpeed = 80;
    public float orderTime = 30, numberOfOrders = 5, timeBetweenOrder;
    public int x;
    public string foodItem, plateItems;
    public List<bool> requestedItems = new List<bool>();
    public GameObject checkMark, incorrectMark;
    public bool orderCompleted = false, orderFailed, orderGenerated;
    public Collider boxColl;


    // Start is called before the first frame update
    void Start()
    {
        if (Score.remainingOrder !=0)
        {
            GenerateOrder();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
            RotateOrderVisuals();
            OrderComplete();
        
        

    }

    private void OnTriggerEnter(Collider collider)
    {
        //Checks If the items on the plate are the correct items.
        switch (collider.tag)
        {
            case "Kebab":
                requestedItems[0] = false;
                break;
            case "Porkchop":
                requestedItems[1] = false;
                break;
            case "Steak":
                requestedItems[2] = false;
                break;
            case "Squid":
                requestedItems[3] = false;
                break;
            case "Sushi":
                requestedItems[4] = false;
                break;
            case "Salmon":
                requestedItems[5] = false;
                break;
             case "Soda":
                requestedItems[6] = false;
                break;
             case "Coffee":
                requestedItems[7] = false;
                break;
             case "Lemonade":
                requestedItems[8] = false;
                break;
            case "Pie":
                requestedItems[9] = false;
                break;
            case "Donut":
                requestedItems[10] = false;
                break;
            case "IceCream":
                requestedItems[11] = false;
                break;
        }

    }

    // Randomizes Order, Shows order rotating above the table
    void GenerateOrder()
    {
        //Gemerates the number of food items the table wants
        int numFoodItems = Random.Range(1, 3);

        for (x = 0; x < numFoodItems; x++)
        {
            GameObject item;

            int randomOrder = Random.Range(0, menuItems.Length);

            item = Instantiate(menuItems[randomOrder], spawnPoints[x].transform.position, Quaternion.identity);
            item.transform.SetParent(spawnPoints[x].transform);

            //Checks the orders tag and sets the table to what item it needs to complete the order
            foodItem = item.tag;
            CheckOrderFoods();
        }

        StartCoroutine(OrderTimer());


    }

    //Rotates the food items above the table
    void RotateOrderVisuals()
    {
        spawnPoints[0].transform.RotateAround(rotateAround.transform.position, Vector3.down, rotateSpeed * Time.deltaTime);
        spawnPoints[1].transform.RotateAround(rotateAround.transform.position, Vector3.down, rotateSpeed * Time.deltaTime);
        spawnPoints[2].transform.RotateAround(rotateAround.transform.position, Vector3.down, rotateSpeed * Time.deltaTime);
    }

    void CheckOrderFoods()
    {

        switch (foodItem)
        {
            case "Kebab":
                requestedItems[0] = true;
                break;
            case "Porkchop":
                requestedItems[1] = true;
                break;
            case "Steak":
                requestedItems[2] = true;
                break;
            case "Squid":
                requestedItems[3] = true;
                break;
            case "Sushi":
                requestedItems[4] = true;
                break;
            case "Salmon":
                requestedItems[5] = true;
                break;
             case "Soda":
                requestedItems[6] = true;
                break;
             case "Coffee":
                requestedItems[7] = true;
                break;
             case "Lemonade":
                requestedItems[8] = true;
                break;
             case "Pie":
                requestedItems[9] = true;
                break;
            case "Donut":
                requestedItems[10] = true;
                break;
            case "IceCream":
                requestedItems[11] = true;
                break;
        }
    }

    //Checks if all the items are all taken
    void OrderComplete()
    {

        if (!requestedItems.Contains(true))
        {
            //StartCoroutine(addScore());
            orderCompleted = true;
            //Debug.Log("Order Complete");
            deleteIcons();
            checkMark.gameObject.SetActive(true);
            StartCoroutine(OrderCompletedTimer());

        }
    }

    // Checks if the spawnpoint has a child, if true destroy
    void deleteIcons()
    {
        if (spawnPoints[0].transform.childCount > 0 || orderFailed == true)
        {
            Destroy(spawnPoints[0].transform.GetChild(0).gameObject);
        }

        if (spawnPoints[1].transform.childCount > 0 || orderFailed == true)
        {
            Destroy(spawnPoints[1].transform.GetChild(0).gameObject);
        }

        if (spawnPoints[2].transform.childCount > 0 || orderFailed == true)
        {
            Destroy(spawnPoints[2].transform.GetChild(0).gameObject);
        }


    }

    IEnumerator OrderTimer()
    {
        yield return new WaitForSeconds(orderTime);
        if (orderCompleted == false)
        {
            //StartCoroutine(minusScore());
            boxColl.isTrigger = false;
            orderFailed = true;
            //deleteIcons();
            incorrectMark.gameObject.SetActive(true);
            StartCoroutine(OrderFailTimer());
            //Debug.Log("Order Failed");
            //StartCoroutine(OrderCooldown());
        }
    }

    IEnumerator OrderCompletedTimer()
    {
        yield return new WaitForSeconds(5);
        // StopAllCoroutines();
        // StartCoroutine(addScore());
        Score.correctOrder += 1;
        Destroy(gameObject);
    }

    IEnumerator OrderFailTimer()
    {
        yield return new WaitForSeconds(5);
        // StopAllCoroutines();
        // StartCoroutine(minusScore());
        Score.incorrectOrder += 1;
        Destroy(gameObject);
    }

    IEnumerator addScore()
    {
        yield return new WaitForSeconds(.1f);
         Score.correctOrder += 1;
         StopCoroutine(addScore());
    }

    IEnumerator minusScore()
    {
         yield return new WaitForSeconds(.1f);
         Score.incorrectOrder += 1;
         StopCoroutine(minusScore());
    }


}
