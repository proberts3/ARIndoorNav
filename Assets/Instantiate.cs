using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public GameObject prefab;
    public GameObject newPrefab;
    private float arrowRotY;
    // Use this for initialization
    void Start()
    {
        arrowRotY = prefab.transform.rotation.y;
        Debug.Log("current rotation " + arrowRotY);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trigger")
        {
            Debug.Log("enter");
            Debug.Log("current rotation " +  arrowRotY);
            var newxPos = transform.position.x;
            var newyPos = (float)transform.position.y;
            var newzPos = (float)transform.position.z + 0.5;

            var newxRot = transform.rotation.x;
            var newyRot = transform.rotation.y+90;
            var newzRot = transform.rotation.z;
            //transform.position = Vector3(transform.position.x + 10, transform.position.y + 10, transform.position.z);
            Instantiate(newPrefab, new Vector3(newxPos, (float)newyPos, (float)newzPos), newPrefab.transform.rotation);
            Destroy(prefab);
            //arrowRotY = 90;
        }
    }
}