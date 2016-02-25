using UnityEngine;
using System.Collections;

public class UnderwaterView : MonoBehaviour 
{

	public float waterLevel;
	public float groundLevel;


	//ParticleSystem myParticles;
	private bool isUnderwater;
	private Color normalColor;
	private Color underwaterColor;

	//NEW VARIABLES
	private bool canSwim = false;
	private bool underGround = false;

	// Use this for initialization
	void Start () 
	{
	
		normalColor = new Color (0.5f, 0.5f, 0.5f, 0.5f);
		underwaterColor = new Color (0.22f, 0.65f, 0.77f, 0.5f);
		//myParticles.Stop();

	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((transform.position.y < waterLevel) != isUnderwater) 
		{
			isUnderwater = transform.position.y < waterLevel;
			if (isUnderwater) SetUnderwater ();
			if (!isUnderwater) SetNormal ();
		}

		//NEW
		if(transform.position.y < groundLevel)
		{
			canSwim = true;
			underGround = true;
		}

		else
		{
			underGround = false;
		}

		if(isUnderwater && canSwim == true && underGround == false && Input.GetKey(KeyCode.E))
		{
			//constantForce.relativeForce = Vector3(0,-200, 0);
		}
		else
		{
			//constantForce.relativeForce = Vector3(0, 0, 0);
		}

		if(isUnderwater && canSwim == true && Input.GetKey(KeyCode.Q))
		{
			//constantForce.relativeForce = Vector3(0, 200, 0);
		}
	
	}


	private void SetNormal () 
	{
		RenderSettings.fogColor = normalColor;
		RenderSettings.fogDensity = 0.002f;
		//chMotor.movement.gravity = 20;
		//chMotor.movement.maxFallSpeed = 20;
		//chMotor.movement.maxForwardSpeed = 6;
		//chMotor.movement.maxSidewaysSpeed = 6;
		//myParticles.Stop();
		canSwim = false;
	}

	private void SetUnderwater () 
	{
		RenderSettings.fogColor = underwaterColor;
		RenderSettings.fogDensity = 0.03f;
		//chMotor.movement.gravity = 2;
		//chMotor.movement.maxFallSpeed = 5;
		//chMotor.movement.maxForwardSpeed = 4;
		//chMotor.movement.maxSidewaysSpeed = 4;
		//myParticles.Play();
	}

}








