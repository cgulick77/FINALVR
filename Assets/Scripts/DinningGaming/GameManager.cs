using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] tableSpawnPts;
    int tableNum;
    public GameObject table;
    private bool table1, table2, table3, table4;
    [SerializeField] LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        Score.remainingOrder = 5;
        // Instantiate(table, tableSpawnPts[0].transform.position, tableSpawnPts[0].transform.rotation);
        // Instantiate(table, tableSpawnPts[1].transform.position, tableSpawnPts[1].transform.rotation);
        // Instantiate(table, tableSpawnPts[2].transform.position, tableSpawnPts[2].transform.rotation);
        // Instantiate(table, tableSpawnPts[3].transform.position, tableSpawnPts[3].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Computer.JobActivated == true && Score.remainingOrder !=0)
        {
            GameStart();
        }
        
        // for (i = 0; i < tableSpawnPts.Length;++i)
        // {

        //     if (Physics.Raycast(tableSpawnPts[i].transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo, 2f, layerMask))
        //     {
        //         Debug.DrawRay(tableSpawnPts[i].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.blue);
        //     }
        //     else
        //     {

        //         Debug.DrawRay(tableSpawnPts[i].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.green); 
        //         Instantiate(table, tableSpawnPts[i].transform.position, tableSpawnPts[i].transform.rotation);
        //         StartCoroutine(tableCooldown());
        //     }

        // }
    }

    void GameStart()
    {
        if (Physics.Raycast(tableSpawnPts[0].transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo1, 2f, layerMask))
        {
            Debug.DrawRay(tableSpawnPts[0].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.blue);

        }
        else
        {
            //Debug.Log("Talbe 0 ON");
            Debug.DrawRay(tableSpawnPts[0].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.green);
            StartCoroutine(tableCooldown(0));


        }
        if (Physics.Raycast(tableSpawnPts[1].transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo2, 2f, layerMask))
        {
            Debug.DrawRay(tableSpawnPts[1].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.blue);

        }
        else
        {
            Debug.DrawRay(tableSpawnPts[1].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.green);
            StartCoroutine(tableCooldown(1));

        }
        if (Physics.Raycast(tableSpawnPts[2].transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo3, 2f, layerMask))
        {
            Debug.DrawRay(tableSpawnPts[2].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.blue);

        }
        else
        {
            Debug.DrawRay(tableSpawnPts[2].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.green);
            StartCoroutine(tableCooldown(2));


        }
        if (Physics.Raycast(tableSpawnPts[3].transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo4, 2f, layerMask))
        {
            Debug.DrawRay(tableSpawnPts[3].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.blue);

        }
        else
        {
            Debug.DrawRay(tableSpawnPts[3].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.green);
            StartCoroutine(tableCooldown(3));

        }
    }

    IEnumerator tableCooldown(int tableNum)
    {
        yield return new WaitForSeconds(3);
        if (Score.remainingOrder != 0)
        {
            Score.remainingOrder -=1;
        }
        
        Instantiate(table, tableSpawnPts[tableNum].transform.position, tableSpawnPts[tableNum].transform.rotation);
        StopAllCoroutines();
        //StopCoroutine(tableCooldown(tableNum));
        //table1 = true;
    }
}
