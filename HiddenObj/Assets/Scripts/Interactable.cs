using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius = 0.75f;


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);

    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }
}
