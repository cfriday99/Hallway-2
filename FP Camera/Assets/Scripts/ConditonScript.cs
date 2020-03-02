using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditonScript : MonoBehaviour
{

    public GameObject canvas;
    public PlayerMovement playerMovement;
    public MouseLook mouseLook;
    public GameObject winEgg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && winEgg.activeSelf)
        {
            foreach(Transform child in other.transform.parent.transform)
            {
                if (child.GetComponent<Camera>() == null)
                {
                    child.gameObject.SetActive(false);
                }
            }
            playerMovement.enabled = false;
            mouseLook.enabled = false;
            canvas.SetActive(true);
        }
    }

}
