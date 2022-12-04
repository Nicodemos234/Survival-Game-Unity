using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform targetTransform;

    private Transform objTransform;
    // Start is called before the first frame update
    void Start()
    {
        objTransform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        objTransform.position = new Vector3(
            targetTransform.position.x, 
            targetTransform.position.y, 
            objTransform.position.z);
    }
}
