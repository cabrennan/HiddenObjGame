using UnityEngine;
using UnityEngine.AI;

/*	
	This component is for all objects that the player can
	interact with such as enemies, items etc. It is meant
	to be used as a base class.
*/

//[RequireComponent(typeof(ColorOnHover))]
public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;

    bool isFocus = false;   // Is this interactable currently being focused?
   // Transform player;       // Reference to the player transform

    bool hasInteracted = false;	// Have we already interacted with the object?


   // [RequireComponent(typeof(ColorOnHover))]
        void Update()
    {
        Debug.Log("Inside Interactable Update");
        
    }


    // This method is meant to be overwritten
    public virtual void Interact()
    {


    }

    void OnDrawGizmosSelected()
    {
        if(interactionTransform == null)
        {
            interactionTransform = transform;
        }
        Gizmos.color = Color.green;
       // Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

}