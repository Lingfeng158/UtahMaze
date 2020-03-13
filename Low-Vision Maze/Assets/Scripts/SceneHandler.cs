using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        var name = e.target.name;
        if (name.Contains("Button"))
        {
            Debug.Log("Button!" + e.target.name);
            var button = e.target.GetComponent<Button>();
            Debug.Log(button);
            if (button != null){

                button.Select();
                button.onClick.Invoke();

                Debug.Log("HandlePointerIn", e.target.gameObject);

            }

        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {

    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {

    }
}
