using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    public GameObject player;
    public float detectionRange = 5.0f;
    public float movementSpeed = 5.0f;

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < detectionRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime);
            transform.LookAt(player.transform.position, Vector3.up);
        }
    }

}
