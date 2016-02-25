using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour 
{

	public GameObject sunLight = null;
	public GameObject moonLight = null;
	public float dayNightSpeed = 0.01f;

	public bool rot_x_axis = false;
	public bool rot_y_axis = false;
	public bool rot_z_axis = false;
	public bool rot_direction = false;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		//Rotation--------------------------------------------------------------
		if(rot_y_axis == true)
		{
			if(rot_direction == false)
			{
				sunLight.transform.Rotate(Vector3.up * Time.deltaTime * dayNightSpeed);
				moonLight.transform.Rotate(Vector3.up * Time.deltaTime * dayNightSpeed);
			}
			else
			{
				sunLight.transform.Rotate(Vector3.down * Time.deltaTime * dayNightSpeed);
				moonLight.transform.Rotate(Vector3.down * Time.deltaTime * dayNightSpeed);
			}
		}

		if(rot_x_axis == true)
		{
			if(rot_direction == false)
			{
				sunLight.transform.Rotate(Vector3.right * Time.deltaTime * dayNightSpeed);
				moonLight.transform.Rotate(Vector3.right * Time.deltaTime * dayNightSpeed);
			}
			else
			{
				sunLight.transform.Rotate(Vector3.left * Time.deltaTime * dayNightSpeed);
				moonLight.transform.Rotate(Vector3.left * Time.deltaTime * dayNightSpeed);
			}
		}

		if(rot_z_axis == true)
		{
			if(rot_direction == false)
			{
				sunLight.transform.Rotate(Vector3.forward * Time.deltaTime * dayNightSpeed);
				moonLight.transform.Rotate(Vector3.forward * Time.deltaTime * dayNightSpeed);
			}
			else
			{
				sunLight.transform.Rotate(Vector3.back * Time.deltaTime * dayNightSpeed);
				moonLight.transform.Rotate(Vector3.back * Time.deltaTime * dayNightSpeed);
			}
		}
		//----------------------------------------------------------------------

	}
}
