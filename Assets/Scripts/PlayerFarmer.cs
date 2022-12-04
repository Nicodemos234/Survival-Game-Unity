using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFarmer : MonoBehaviour
{
    public GameObject[] farms;
    private Transform objTransform;
    // Start is called before the first frame update
    void Start()
    {
        farms = GameObject.FindGameObjectsWithTag("Farm");
        objTransform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            for (int i = 0; i < farms.Length; i++)
            {
                if(farms[i]) {
                    float distance = Vector3.Distance(farms[i].transform.position, objTransform.position);
                    if(distance < 2.5f) {
                        Tree tree = farms[i].GetComponent<Tree>();
                        tree.life--;
                        if(tree.life <= 0) {
                            Inventory inventory = gameObject.GetComponent<Inventory>();
                            inventory.items.Add(tree.itemName);
                            Destroy(farms[i]);
                            farms[i] = null;
                        }
                        break;
                    }
                }
            }
        }
    }
}
