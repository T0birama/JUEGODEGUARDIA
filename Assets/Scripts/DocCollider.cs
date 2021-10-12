using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocCollider : MonoBehaviour
{
    public GameObject Doc;
    public float TiempoDeCollider = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladron"))
        {
            StartCoroutine(Tiempo());
        }
    }

    IEnumerator Tiempo()
    {
        yield return new WaitForSeconds(TiempoDeCollider);
        
        Doc.SetActive(false);

    }
}
