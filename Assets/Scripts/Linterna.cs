using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.Playables;

public class Linterna : MonoBehaviour
{
    public GameObject LinternaMesh;
    public GameObject Luz;
    private bool encendida;
    public PlayableDirector Slinterna;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            encendida = !encendida;
            if (encendida)
            {
                Luz.SetActive(false);
                Slinterna.Play();
            }
            else
            {
                Luz.SetActive(true);
                Slinterna.Play();
            }
        }
    }

    public void FollowCamera(bool active)
    {
        LinternaMesh.transform.SetParent(active ? Camera.main.transform : null);
    }
}
