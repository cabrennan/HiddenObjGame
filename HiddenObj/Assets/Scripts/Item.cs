using UnityEngine;
using System.Collections;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Items")]
public class Item : ScriptableObject {

    new public string name = "New Item";    // Name of the item
    public Sprite icon = null;              // Item icon
    public bool showInInventory = true;
    public bool enabled = false; // If true can be clicked on
    public Vector3 pos;

    public GameObject obj;
    public Collider2D objCollider;
    private Camera cam;
    private Plane[] planes;


    public Vector3 center;
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
        Debug.Log("Positioning: " + this.name);

        // Set item position;
        bool visible = false;
        do
        {
            //pos = new Vector3(Random.Range(-5.00f, 3.00f), Random.Range(0.0f, 3.0f), Random.Range(-2.0f, 0f));
            //pos = new Vector3(Random.Range(-7,7), Random.Range(0, 2), Random.Range(0,10));
            //pos = new Vector3(Random.Range(-5.00f, 03.00f), Random.Range(0,3), Camera.main.nearClipPlane);
            float screenX = Random.Range(-5.0f, 1.0f);
            //float screenY = Random.Range(0.0f, Camera.main.pixelHeight);
            float screenY = Random.Range(-4.0f, 3.0f);
            float screenZ = Random.Range(-4.0f, 0.0f);
             Vector3 point = new Vector3(screenX, screenY, screenZ);

            Debug.Log("Testing position: " + pos.ToString());
            obj = GameObject.Find("/HiddenObjParent/" + this.name);
            obj.transform.position = point;
            //Instantiate(obj, point, Quaternion.identity);
            //visible = true;
            
            //Debug.Log("Testing position for: " + this.name);
            cam = Camera.main;
            planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
            Debug.Log("after planes");
            objCollider = obj.GetComponent<Collider2D>();
            Debug.Log("after collider");
            if (GeometryUtility.TestPlanesAABB(planes, objCollider.bounds))
            { 
                visible = true;
            }

        } while (!visible);
    }

    public void NewSetPosition()
    {
        Debug.Log("Positioning: " + this.name);
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
        obj = GameObject.Find("/HiddenObjParent/" + this.name);
        //Instantiate(obj, screenPosition, Quaternion.identity);
        obj.transform.position = screenPosition;

    }

    public void SPos()
    {
        Debug.Log("Positioning: " + this.name);
       // Vector3 pos = new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
       // obj = GameObject.Find("/HiddenObjParent/" + this.name);
        //Instantiate(obj, screenPosition, Quaternion.identity);
        //obj.transform.position = pos; 
    }

}
