using UnityEngine;
using System.Collections;

public class camera_script : MonoBehaviour {

	public GameObject player;
    private Vector3  offset;
	void Start ()
    {
        offset = transform.position - player.transform.position;
    }
	
	void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
