using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxs : MonoBehaviour
{
    static int money = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        Destroy(gameObject);
        money = money + 100;
        print("ура " + money);
    }
}
