using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotator : MonoBehaviour {


	void Update () {
        //indicates how the object rotates and ensures rotation is smooth with deltaTime
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
