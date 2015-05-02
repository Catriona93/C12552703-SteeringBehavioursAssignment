using UnityEngine;
using System.Collections;

public class catchFish : MonoBehaviour {

	public void OnTriggerEnter(Collider collider){
		if(collider.gameObject.name == "_Player") //If the food collides with the crab collider destroy food.
			
		{
			
			
			
			
			Destroy(gameObject);//Destroy the enemy game object.
		}
		
		
	}
}