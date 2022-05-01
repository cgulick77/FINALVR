using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] tableSpawnPts;
    int i;
    public GameObject table;
    [SerializeField] LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        for (i = 0; i < tableSpawnPts.Length;++i)
        {
            
            if (Physics.Raycast(tableSpawnPts[i].transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo, 2f, layerMask))
            {
                Debug.DrawRay(tableSpawnPts[i].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.blue);
            }
            else
            {
                
                Debug.DrawRay(tableSpawnPts[i].transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.green);
                Instantiate(table, tableSpawnPts[i].transform.position, tableSpawnPts[i].transform.rotation);
            }
            
        }
    }

    void GameStart()
    {

    }
}
