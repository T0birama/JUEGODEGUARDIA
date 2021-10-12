using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronVolver : MonoBehaviour
{
    public GameObject Ladron;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Ladron.activeSelf)
        {
            StartCoroutine(volverLadron());
        }
    }


    IEnumerator volverLadron()
    {
        yield return new WaitForSeconds(4);
        Ladron.SetActive(true);
    }
}
