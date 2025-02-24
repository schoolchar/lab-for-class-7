using JetBrains.Annotations;
using UnityEngine;
public class VectorSubtractionExample : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 directionToTarget = target.position - player.transform.position;
        player.transform.Translate(directionToTarget.normalized * Time.deltaTime * 2); // Move toward target
        Debug.DrawRay(player.transform.position, directionToTarget, Color.green);
    }
}