using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EntrarEnCamaras : MonoBehaviour
{
    
    public GameObject CamaraDeSala;
    public GameObject Player;
    public GameObject InterfazDeCambiar;
    public GameObject InterfazDeCamara2;
    public GameObject Linterna;
    public GameObject vision;
    public bool PuedeApretar = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PuedeApretar == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                gameObject.SetActive(false);
                InterfazDeCamara2.SetActive(true);
                InterfazDeCambiar.SetActive(false);

                CamaraDeSala.SetActive(true);
                Player.SetActive(false);
                Linterna.SetActive(false);
                vision.SetActive(true);



            }
        }
       
    }

    IEnumerator Fadedblack()
    {
        yield return new WaitForSeconds(0.5f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PuedeApretar = true;
            InterfazDeCambiar.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PuedeApretar = false;
            InterfazDeCambiar.SetActive(false);
        }
    }
}
