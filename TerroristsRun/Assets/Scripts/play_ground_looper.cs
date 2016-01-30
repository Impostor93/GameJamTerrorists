using UnityEngine;
using System.Collections;

public class play_ground_looper : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    private int lengthOfBackground;

	void Start ()
    {
        var playgroundObjects = GameObject.FindGameObjectsWithTag("playground");
        lengthOfBackground = playgroundObjects.Length;
        if (playgroundObjects != null && playgroundObjects.Length > 0)
        {
            var playgroundObject = playgroundObjects[0];
            transform.position = new Vector3(-playgroundObject.transform.localScale.x, 0.0f, 0.0f);
        }

        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("playground"))
        {
            var newX = lengthOfBackground * other.transform.localScale.x;
            other.transform.position = new Vector3(other.transform.position.x + newX, 0.0f, 0.0f);
        }
    }
}
