using UnityEngine;
using System.Collections;

public class fishFood : MonoBehaviour {

	//The fish names Fish1 that has this script is able to search for the food if seek and arrive are enabled in the script.

	public void OnTriggerEnter(Collider collider){
		if(collider.gameObject.name == "Fish1") //If the food collides with the crab collider destroy food.
			
		{
			
			
			
			
			Destroy(gameObject);//Destroy the enemy game object.
		}
		
		
	}
}