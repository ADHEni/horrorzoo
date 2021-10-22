using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private GameObject myLight;
    public string Inventory;

    public List<string> Items;

    private Dictionary<string,KeyCode> controls = new Dictionary<string, KeyCode>();

    void Start()
    {
        myLight = GameObject.Find("Taschenlampe");
        controls.Add("Taschenschlampe",KeyCode.T);
        controls.Add("Aufheben",KeyCode.E);
    }

    void Update()
    {
        if(Input.GetKeyDown(controls["Taschenschlampe"]))
        {
            myLight.GetComponent<Light>().enabled = !myLight.GetComponent<Light>().enabled;
        }

        if (Input.GetKeyDown(controls["Aufheben"])) { 
            RaycastHit hit;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast (ray,out hit,3f)) {
                if(Items.Contains(hit.transform.tag))
                {
                    Inventory = hit.transform.tag;
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
