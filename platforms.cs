using UnityEngine;
using GorillaLocomotion;
using System;

namespace Forest2000Menu.Mods {
	public class Movement {
		public leftplat = null;
    
	    public static void CreatePlatform() {
			GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
			platform.transform.localScale = new Vector3(0.025f, 0.15f, 0.2f);
			platform.GetComponent<Renderer>().material.color = Color.blue;
		
			return platform;
	    }

		GameObject leftplat = null;
		GameObject rightplat = null;
	    
	    public static void Platforms() {
			if (ControllerInputPoller.instance.leftGrab && leftplat == null) {
				leftplat = CreatePlatform();
					
				var leftHandTransform = GorillaLocomotion.Player.Instance.leftHandTransform;
				leftplat.transform.position = leftHandTransform.position;
				leftplat.transform.rotation = leftHandTransform.rotation;
	      	} else {
				UnityEngine.Object.Destroy(leftplat);
			}

			if (ControllerInputPoller.instance.rightGrab && rightplat == null) {
				rightplat = CreatePlatform();
					
				var rightHandTransform = GorillaLocomotion.Player.Instance.rightHandTransform;
				rightplat.transform.position = rightHandTransform.position;
				rightplat.transform.rotation = rightHandTransform.rotation;
	      	} else {
				UnityEngine.Object.Destroy(rightplat);
			}
    	}
  	}
}
