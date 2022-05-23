using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject baby;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("germinate", time);
    }
    private void germinate()
    {
        if (transform.position.y < 1f)
        {
            Vector3 pos = new Vector3(transform.position.x, 0.5f, transform.position.z);
            Instantiate(baby, pos, Quaternion.identity);
        }
            Destroy(this.gameObject);
    }
}
