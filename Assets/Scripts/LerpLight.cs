using UnityEngine;
using System.Collections;

public class LerpLight : MonoBehaviour {

	// position, color, intensity
	public float speed = 20f;
	public float distance = 8f;
	public float intensityMax = 2f;
	public float intensityMin = 0.5f;

	//private Color newColor;



	void Update(){

		float x = PingPong(Time.time*speed, -distance, distance);
		transform.position = new Vector3( x , transform.position.y, transform.position.z);

		GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 2f, 0.5f * Time.deltaTime);


		//GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, Color.magenta, Time.deltaTime * (speed/4));



	}


	float PingPong (float value, float min,float max) {

		return Mathf.PingPong(value, max - min) + min;

	}

	/*
	 * http://answers.unity3d.com/questions/608674/does-mathfpingpong-always-have-to-start-at-000.html
	 * http://docs.unity3d.com/ScriptReference/Mathf.Lerp.html
	 * https://www.youtube.com/watch?v=cD-mXwSCvWc&list=PLX2vGYjWbI0Tg4eS9w29PPqg0Fx4sIL7p&index=209
	 * http://unity3d.com/learn/tutorials/modules/beginner/scripting/linear-interpolation?playlist=17117
	 */
	
}
