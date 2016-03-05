using UnityEngine;
using System.Collections;

//public class Move : MonoBehaviour {
//
//	public float moveSpeed;
//	public GameObject brick;
////	public var MouseCoords : Vector3;
//
//	// Use this for initialization
//	void Start () {
//		moveSpeed = 200f;
//
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		float w = moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime;
//		float d = moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime;
//		transform.Translate (w, 0f, d);
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			for (int y = 0; y < 5; y++) {
//				for (int x = 0; x < 5; x++) {
//					GameObject cube = Instantiate (brick) as GameObject;
//					cube.transform.position = new Vector3 (w, 0f, d);
//					print (w);
//					print (d);
//					print (y);
//					print (x);
//
//
//					//all GameObjects have a transform property
//				}
//			}
//		}
//	}
//}

/****************************************************************/

/* http://answers.unity3d.com/questions/639139/how-to-move-an-2d-object-to-mouse-click-position-i.html */
public class Move : MonoBehaviour {

	public float speed = 200f;
	public GameObject brick;
	private Vector3 target;

	void Start() {
		target = transform.position;
	}

	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			for (int y = 0; y < 5; y++) {
				for (int x = 0; x < 5; x++) {
					GameObject cube = Instantiate (brick) as GameObject;
					target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					target.z = transform.position.z;
					cube.transform.position = Vector3.MoveTowards (target, target, speed * Time.deltaTime);
					Debug.Log (target);
				}
			}
		}
	}
}