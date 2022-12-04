using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public int life = 5;
    public string itemName = "wood";
    public GameObject lifeLine;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(life == 5) {
            lifeLine.transform.localScale = new Vector3(
                            0, 
                lifeLine.transform.localScale.y, 
                lifeLine.transform.localScale.z);
        } else {
            lifeLine.transform.localScale = new Vector3(
                life * 0.3f, 
                lifeLine.transform.localScale.y, 
                lifeLine.transform.localScale.z);
        }
    }

    private void OnDestroy() {
    }
}
