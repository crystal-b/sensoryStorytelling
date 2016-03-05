using UnityEngine;
using System.Collections;

public class AddCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) { //keycode.space is kinda like the ascii number for your keyboard spacebar key
			//create a grid 5x5 layout
//			for (int y = 0; y < 5; y++) {
//				for (int x = 0; x < 5; x++) {
			int y = 0;
			int x = 0;
					GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
					string NameNumber = (x + y).ToString (); //only way this allows you to add a number to a string
					cube.name = "Brick" + NameNumber;
					//cube.transform.position = new Vector3 (Random.Range (-1f, 1f), Random.Range (-1f, 1f), 0); //-1f is float -1.0, requires floats, not ints
					cube.transform.position = new Vector3 (0, -1f, 0); //-1f is float -1.0, requires floats, not ints
					cube.AddComponent<Rigidbody> ();
					TrailRenderer tr = cube.AddComponent<TrailRenderer> ();
					tr.startWidth = 1.0f;
					tr.endWidth = 0.10f;
					tr.time = 1.0f;
//				}
//			}
		}
	
	}
}
