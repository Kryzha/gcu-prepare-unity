using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown : MonoBehaviour
{
    public float multiplier = 1.9f;
    public GameObject pickupEffect;
    public float duration = 2f;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
           StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.speed *= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;

        yield return new WaitForSeconds(duration);
        stats.speed /= multiplier;
    
        Destroy(gameObject);
    }
}
