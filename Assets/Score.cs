using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int correctOrder;
    public static int incorrectOrder;
    public Text rOrder;
    public Text iOrder;
    // Start is called before the first frame update
    void Start()
    {
        //rOrder = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        rOrder.text = "" + correctOrder;
        iOrder.text = "" + correctOrder;
    }
}
