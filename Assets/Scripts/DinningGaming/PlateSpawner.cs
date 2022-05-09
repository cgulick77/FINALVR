using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateSpawner : MonoBehaviour
{
    public GameObject plate;
    public GameObject spawnPoint;
    public GameObject sp2;
    [SerializeField] LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(spawnPoint.transform.position, transform.TransformDirection(Vector3.up), out RaycastHit hitInfo, 1f, layerMask))
        {
            Debug.DrawRay(spawnPoint.transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.blue);
        }
        else{
            Debug.DrawRay(spawnPoint.transform.position, transform.TransformDirection(Vector3.up) * 2f, Color.green);
            StartCoroutine(spawnPlate());   
        }
    }

    IEnumerator spawnPlate()
    {
        yield return new WaitForSeconds(1);
        Instantiate(plate, sp2.transform.position, sp2.transform.rotation);
        StopAllCoroutines();
    }
}
