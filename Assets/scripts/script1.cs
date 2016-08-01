using UnityEngine;
using System.Collections;

public class script1 : MonoBehaviour {

    public GameObject bullet;
    public GameObject player;
    float timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left);
        }
        else
        {

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right);
        }
        else
        {

        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (timer > .5) { 
            Instantiate(bullet, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);
                timer = 0;
        }
        }
        else
        {

        }
    }
}
