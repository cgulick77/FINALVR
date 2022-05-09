using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int correctOrder;
    public static int incorrectOrder;
    public static int remainingOrder;
    public Text rOrder;
    public Text iOrder;
    public Text roOrder;
    // Start is called before the first frame update
    void Start()
    {
        //rOrder = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        rOrder.text = "" + correctOrder;
        iOrder.text = "" + incorrectOrder;
        roOrder.text = " " + remainingOrder;
    }
}
