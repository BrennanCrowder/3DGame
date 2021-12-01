using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject target;
    public GameObject player;
    public int damping = 2;
    public Vector3 modifiedLocation;
    
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var lookPos = target.transform.position - player.transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }
}
