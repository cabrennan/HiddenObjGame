using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Items")]
public class Item : ScriptableObject {

    new public string name = "New Item";    // Name of the item
    public Sprite icon = null;              // Item icon
    public bool showInInventory = true;
    public bool enabled = false; // If true can be clicked on
    public Vector3 pos;

    public GameObject obj;

    // Called when the item is pressed in the inventory
    public virtual void Use()
    {
        // Use the item

    }

    // Call this method to remove the item from inventory
    public void RemoveFromInventory()
    {
       // Inventory.instance.Remove(this);
    }

    public void SetPosition()   {
        //Debug.Log("Positioning: " + this.name);

        // Set item position;

        
        bool visible = false;
        do
        {
           //pos = new Vector3(Random.Range(-5.00f, 3.00f), Random.Range(0.0f, 3.0f), Random.Range(-2.0f, 0f));
           // obj = GameObject.Find("/HiddenObjParent/" + this.name);
           // obj.transform.position = pos;
           // Debug.Log("Testing position for: " + this.name);
            //RaycastHit hit;
            //if(Physics.Raycast(obj.transform.position, obj.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
           // {
              visible = true;
           // }

        } while (!visible);


        
        

    }
}
