using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronInicio : MonoBehaviour
{
    public GameObject Ladron;
    public float ladronInicioSeg;
    public GameObject LadronVolverScript;
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
        yield return new WaitForSeconds(ladronInicioSeg);
        Ladron.SetActive(true);
        gameObject.SetActive(false);
        LadronVolverScript.SetActive(true);
    }
}
