﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeScript : MonoBehaviour   //cubeScript is attached to all MOBILE IONS
{

	public Vector3 velocity;
	public float temp;
	private Rigidbody cube;
	private Slider temperatureSlider;
    public float OriginalYPosition;    
    private float NewVx;   //used to get mobile ion out of a rut moving only vertically or only horizontally
    private float NewVy;  //used to get mobile ion out of a rut moving only vertically or only horizontally

    // Start is called before the first frame update
    void OnEnable()
	{
		cube = gameObject.GetComponent<Rigidbody>();
		temperatureSlider = GameObject.Find("temperatureSlider").GetComponent<Slider>();
		
		float vx = UnityEngine.Random.Range(-5, 5);
		if ((-1 < vx) && (vx < 1))
			{ vx = 2;}

		float vy = UnityEngine.Random.Range(-5, 5);
		if ((-1 < vy) && (vy < 1))
			{ vy = 2;}

        temp = temperatureSlider.value;

        velocity = new Vector3(vx, vy, 0);
		cube.velocity = velocity.normalized*temp;
		
		
		GameObject.Find("GameObject").GetComponent<forces>().nonObjects.Add(gameObject);

        OriginalYPosition = transform.position.y;
	}		



	// Update is called once per frame
	void FixedUpdate()
	{
		temp = temperatureSlider.value;

        if (Mathf.Abs(cube.velocity.y) < 1f)
        {
            NewVx = cube.velocity.x;  //stores the x-velocity of the ion so it can be used in new Vector3
            //print("Vy = " + cube.velocity.y);
            if (cube.transform.position.y > -1)
            {
                NewVy = -1;
            }
            else if (cube.transform.position.y <= 0)
            {
                NewVy = 1;
            }
            cube.velocity = new Vector3(NewVx, NewVy, 0);
            //print("New Vy = " + cube.velocity.y);

        }

        if (Mathf.Abs(cube.velocity.x) < 1f)
        {
            NewVy = cube.velocity.y;  //stores the current y-velocity of the ion so it can be used in new Vector3
            //print("Vx = " + cube.velocity.x);
            if (cube.transform.position.x > 0)
            {
                NewVx = -1;
            }
            else if (cube.transform.position.x <= 0)
            {
                NewVx = 1;
            }
            cube.velocity = new Vector3(NewVx, NewVy, 0);
            //print("New Vx = " + cube.velocity.x);

        }

        //REDID THE VELOCITIES BY USING "NORMALIZE"*TEMP VALUE.  TEMP VALUES GO FROM 4 TO 20 (5-FOLD DIFFERENCE IN SPEED)

        if (Time.timeScale != 0 && cube.velocity.magnitude < temp)                //.sqrMagnitude < (temp)) //GameObject.Find("TemperatureController").GetComponent<TemperatureScript>().Temperature)) //&& GameObject.Find("ForcesKeeper").GetComponent<forces>().recording)
        {
            //print(gameObject + "is very slow");
            //cube.velocity *= 10f;
            //print("velocity sped up to = " + cube.velocity.magnitude);
            velocity = new Vector3(cube.velocity.x, cube.velocity.y, 0);
            cube.velocity = velocity.normalized * temp;
            //print(gameObject + " Velocity increased to " + cube.velocity);
        }

        if (Time.timeScale != 0 && cube.velocity.magnitude > 2*temp)                //.sqrMagnitude < (temp)) //GameObject.Find("TemperatureController").GetComponent<TemperatureScript>().Temperature)) //&& GameObject.Find("ForcesKeeper").GetComponent<forces>().recording)
        {
            //print(gameObject + "is very slow");
            //cube.velocity *= 10f;
            //print("velocity sped up to = " + cube.velocity.magnitude);
            velocity = new Vector3(cube.velocity.x, cube.velocity.y, 0);
            cube.velocity = velocity.normalized * 1.7f*temp;
            //print(gameObject + " Velocity decreased to " + cube.velocity);
        }

        //if (Time.timeScale != 0 && cube.velocity.sqrMagnitude < (5*temp)) //GameObject.Find("TemperatureController").GetComponent<TemperatureScript>().Temperature)) //&& GameObject.Find("ForcesKeeper").GetComponent<forces>().recording)
        //{
        //    //print(gameObject + "is kinda slow");
        //    cube.velocity *= 2.5f;
        //    //print("velocity sped up to = " + cube.velocity.magnitude);
        //}

        //if (Time.timeScale != 0 && cube.velocity.sqrMagnitude < (15 * temp)) //GameObject.Find("TemperatureController").GetComponent<TemperatureScript>().Temperature)) //&& GameObject.Find("ForcesKeeper").GetComponent<forces>().recording)
        //{
        //    //print(gameObject + "is a bit slow");
        //    cube.velocity *= 1.3f;
        //    //print("velocity sped up to = " + cube.velocity.magnitude);
        //}

        //if (Time.timeScale != 0 && cube.velocity.sqrMagnitude > (30 * temp)) //GameObject.Find("TemperatureController").GetComponent<TemperatureScript>().Temperature)) //&& GameObject.Find("ForcesKeeper").GetComponent<forces>().recording)
        //{
        //    //print(gameObject + "is too fast");
        //    cube.velocity /= 1.3f;
        //    //print("velocity slowed to = " + cube.velocity.magnitude);
        //}


  //      if (cube.velocity.sqrMagnitude < 0.002f)
		//{
		//	cube.velocity = new Vector3(1,1,0);
		//}

		//if (Time.timeScale != 0 && GameObject.Find("GameObject").GetComponent<forces>().recording && cube.velocity.sqrMagnitude < (20 * temp))
		//{
		//	cube.velocity *= 1.3f;
		//	//print("new velocity = " + velocity.magnitude);
		//}
	}

    
        


    
}
