using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

[RequireComponent(typeof(ARRaycastManager))]
public class ARsceneSetup : MonoBehaviour
{
    //public GameObject placementPrefab; 

    private ARRaycastManager raycastManager;


    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {

    }
}
