using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 2f;
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

        player.transform.localScale /= multiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;

        yield return new WaitForSeconds(duration);
        player.transform.localScale /= multiplier;
    
        Destroy(gameObject);
    }
}
