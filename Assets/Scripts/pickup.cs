using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemBehavior : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == player)
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item collected!");
        }
    }
}