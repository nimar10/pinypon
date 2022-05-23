using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour
{
    public GameObject egg;
    private GameObject eggCreation;
    // Start is called before the first frame update
    void Start()
    {
        eggCreation = transform.gameObject;
        StartCoroutine("createBaby");
    }
    IEnumerator createBaby()
    {
            while (true){
                yield return new WaitForSeconds(10.0f);

                float x = eggCreation.transform.position.x + Random.Range(-10f, 10f);
                float z = eggCreation.transform.position.z + Random.Range(-10f, 10f);
                float y = eggCreation.transform.position.y;

                Vector3 pos = new Vector3(x, y, z);

                Instantiate(egg, pos, Quaternion.identity);
            }
    }
}
