using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerFarmer : MonoBehaviour
{
    public GameObject[] farms;
    public TextMeshProUGUI inventoryText;
    private Transform objTransform;
    // Start is called before the first frame update
    void Start()
    {
        objTransform = gameObject.GetComponent<Transform>();
    }

    void HitTree()
    {
        farms = GameObject.FindGameObjectsWithTag("Farm");
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
                            inventoryText.SetText(inventoryText.text + ' ' + tree.itemName);
                            Destroy(farms[i]);
                            farms[i] = null;
                        }
                        break;
                    }
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            InvokeRepeating("HitTree", 0, 0.5f); 
          if (Input.GetMouseButtonUp(0))
            CancelInvoke();
            
    }
}
