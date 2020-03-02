using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{

    public GameObject handEgg;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            handEgg.SetActive(true);
            player.GetComponent<PlayerMovement>().speed = 7.0f;
        }
    }

}
