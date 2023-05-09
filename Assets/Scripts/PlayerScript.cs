using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Mirror;

public class PlayerScript : NetworkBehaviour
{

    public Transform head;
    public Transform lefthand;
    public Transform righthand;
    // Start is called before the first frame update
    void Movement()
    {

        if(isLocalPlayer)
        {
            righthand.gameObject.SetActive(false);
            lefthand.gameObject.SetActive(false);
            head.gameObject.SetActive(false);

        MapPosition(head, XRNode.Head);
        MapPosition(lefthand, XRNode.LeftHand);
        MapPosition(righthand, XRNode.RightHand);

        }
        
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
        
    }

    void MapPosition(Transform target,XRNode node)
    {
        InputDevices.GetDeviceAtXRNode(node).TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 position);

        InputDevices.GetDeviceAtXRNode(node).TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rotation);

         target.position = position;
         target.rotation = rotation;
    }
}
