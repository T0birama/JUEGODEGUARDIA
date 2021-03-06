using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronVolver : MonoBehaviour
{
    public GameObject Ladron;
    public float ladronVolverSeg;
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
        yield return new WaitForSeconds(ladronVolverSeg);
        Ladron.SetActive(true);
    }
}
