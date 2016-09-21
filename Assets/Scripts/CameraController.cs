using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

	public GameObject player;

	// Use this for initialization
	void Start ()
	{
		cameraOn (player);
	}

	// LateUpdate is called after Update each frame
	void LateUpdate ()
	{
		cameraOn (player);
	}

	void cameraOn (GameObject obj)
	{
//		transform.position += new Vector3 (obj.transform.position.x, obj.transform.position.y, 0);
		transform.position = new Vector3 (obj.transform.position.x, obj.transform.position.y, transform.position.z);
	}
}
