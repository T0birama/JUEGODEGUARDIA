using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronInicio : MonoBehaviour
{
    public GameObject Ladron;
    public float ladronInicioSeg;
    public GameObject LadronVolverScript;
    public GameObject Wasd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WASD());
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

    IEnumerator WASD()
    {
        yield return new WaitForSeconds(5);
        Wasd.SetActive(false);
    }
}
