using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
    public int limit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectsWithTag("Egg").Length == limit)
        {
            if (other.gameObject.tag == "Egg")
            {
                DestroyObject(other.gameObject);
            }
        }
    }
}
