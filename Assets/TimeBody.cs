﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[System.Obsolete("This is an obsolete method")]
public class TimeBody : MonoBehaviour
{
    [System.Obsolete("This is an obsolete method")]
    public bool isRewinding = false;[System.Obsolete("This is an obsolete method")]
    public int frame = -1;[System.Obsolete("This is an obsolete method")]
    private GameObject gameobject;[System.Obsolete("This is an obsolete method")]
    private List<SpaceTime> points = Enumerable.Repeat<SpaceTime>(null, 1).ToList();[System.Obsolete("This is an obsolete method")]
    public Rigidbody Arbies;

    // void Start()
    // {
    // 	gameobject = GameObject.Find("GameObject");
    // 	Arbies = GetComponent<Rigidbody>();
    // }

    // void FixedUpdate()
    // {
    // 	if (isRewinding)
    // 	{
    // 		frame--;
    // 		Rewind();
    // 	}
    // 	else if(frame < -1 || points[frame+1] != null)
    // 	{
    // 		frame++;
    // 		Playback();
    // 	}
    // 	else
    // 	{
    // 		points.Add(Enumerable.Repeat<SpaceTime>(null, 1).ToList()[0]);
    // 		frame++;
    // 		Record();
    // 	}
    // }

    // void Rewind()
    // {
    // 	if (frame < 0)
    // 	{
    // 		if(frame == gameobject.GetComponent<TimeBody>().frame)
    // 		{
    // 			gameobject.GetComponent<forces>().stopRewind();
    // 			GameObject.Find("speedSlider").GetComponent<time>().updateTimeScale(0f);
    // 		}
    // 		else
    // 		{
    // 			transform.position = new Vector3(-15, 0, -15);
    // 		}
    // 	}
    // 	else
    // 	{
    // 		SpaceTime point = points[frame];
    // 		transform.position = point.position;
    // 		transform.rotation = point.rotation;
    // 	}
    // }

    // void Record()
    // {
    // 	points[frame] = new SpaceTime(Arbies.velocity, transform.position, transform.rotation);
    // }

    // void Playback()
    // {
    // 	if(frame > -1)
    // 	{
    // 		transform.position = points[frame].position;
    // 		transform.rotation = points[frame].rotation;
    // 		if(points[frame+1] == null)
    // 		{
    // 			Arbies.isKinematic = false;
    //             Arbies.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    // 			Arbies.velocity = points[frame].velocity;
    // 			gameobject.GetComponent<forces>().recording = true;
    // 		}

    // 	}
    // }

    // public void StartRewind()
    // {
    // 	isRewinding = true;
    // 	gameobject.GetComponent<forces>().recording = false;
    //     Arbies.collisionDetectionMode = CollisionDetectionMode.Discrete;
    // 	Arbies.isKinematic = true;
    // }
}