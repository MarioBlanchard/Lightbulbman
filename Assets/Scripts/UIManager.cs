using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public Text Text;
    public static UIManager GetInstance()
    {
        return instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAmmoCount(float ammo)
    {
        Text.text = "Ammo: " + ammo;
    }
}
