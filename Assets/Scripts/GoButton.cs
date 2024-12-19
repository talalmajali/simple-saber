using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
    List<GameObject> popups = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {
        Debug.Log("Clicking");
        GameObject instance = Instantiate(Resources.Load<GameObject>("ImagesPopup"));
        popups.Add(instance);
    }


    public void ClearAssets() {
        int counter = 0;
        foreach (GameObject pp in popups) {
            Destroy(pp);
        }
        popups.Clear();
        // var popup = GameObject.Find("ImagesPopup(Clone)");
        // while (popup != null && counter < 100) {
        //     Destroy(popup);
        //     counter++;
        //     popup = GameObject.Find("ImagesPopup(Clone)");
        // }
        Resources.UnloadUnusedAssets();
    }
}
