using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject OtraCamara;
    public GameObject OtraCamara2;
    public GameObject InterfazDeEstaCamara;
    public GameObject estaCam;
    public GameObject CamaraManager;
    public GameObject Linterna;
    public GameObject Vision;
    public GameObject estecollider;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        InterfazDeEstaCamara.SetActive(true);
        estecollider.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CamaraManager.SetActive(true);
            InterfazDeEstaCamara.SetActive(false);

            Player.SetActive(true);
            Linterna.SetActive(true);

            gameObject.SetActive(false);
            Vision.SetActive(false);
            


        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            estaCam.SetActive(false);
            OtraCamara.SetActive(true);
            InterfazDeEstaCamara.SetActive(false);
            estecollider.SetActive(false);


        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            estaCam.SetActive(false);
            OtraCamara2.SetActive(true);
            InterfazDeEstaCamara.SetActive(false);
            estecollider.SetActive(false);
        }
    }

    IEnumerator Faded()
    {
        yield return new WaitForSeconds(0.5f);

    }

    IEnumerator Faded2()
    {
        yield return new WaitForSeconds(0.5f);

    }
}
