using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    // This is used by assigning a teleport target and assigning a player which is, The Player, and just makes the players coordinates, the teleport
    // target's coordinates.
    public Transform teleportTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;





    }
