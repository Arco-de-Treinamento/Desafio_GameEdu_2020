﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

		public Transform Player;

		private void FixedUpdate(){
			//Traslado suave da camera
			transform.position = Vector2.Lerp(transform.position, Player.position, 0.1f);
		}
}
