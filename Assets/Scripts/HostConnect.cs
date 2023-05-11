using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
using TMPro;

public class HostConnect : MonoBehaviour
{

    NetworkManager manager;
    public GameObject Host;

    void Awake()
    {
        manager = GetComponent<NetworkManager>();
    }
    // Start is called before the first frame update
    void Start()
    {

        manager.StartHost();
        Host.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        manager.StartClient();

        Host.SetActive(false);
        
    }
}
