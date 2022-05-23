using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedController : MonoBehaviour
{
    private int vida = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void quitarVida()
    {
        vida--;

        if (vida == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
