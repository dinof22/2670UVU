using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStartingPoints : MonoBehaviour {

    public GameObject littleCube, BigCube, RollingCube, Tree, TreeSmasher, Bear, WaterPlugcube, Gator1, Gator2, Gator3, GrabbableRoof, TempleDoor, LoweringPlatform1, LoweringPlatform2, Light1;

    public GameObject GatorGate1, GatorGate2, GatorGate3;

    Vector3 littleCubeStart, BigCubeStart, RollingCubeStart, TreeStart, TreeSmasherStart, BearStart, WaterPlugStart, Gator1Start, Gator2Start, Gator3Start, GrabbableRoofStart, TempleDoorStart, LoweringPlatform1Start, LoweringPlatform2Start, Light1Start;

    private void Start()
    {
        littleCubeStart = littleCube.transform.position;
        BigCubeStart = BigCube.transform.position;
        RollingCubeStart = RollingCube.transform.position;
        TreeStart = Tree.transform.position;
        TreeSmasherStart = TreeSmasher.transform.position;
        BearStart = Bear.transform.position;
        WaterPlugStart = WaterPlugcube.transform.position;
        Gator1Start = Gator1.transform.position;
        Gator2Start = Gator2.transform.position;
        Gator3Start = Gator3.transform.position;
        GrabbableRoofStart = GrabbableRoof.transform.position;
        TempleDoorStart = TempleDoor.transform.position;
        LoweringPlatform1Start = LoweringPlatform1.transform.position;
    }

    public void ResetAllObjects()
    {
        littleCube.transform.position = littleCubeStart;
        BigCube.transform.position = BigCubeStart;
        RollingCube.transform.position = RollingCubeStart;
        Tree.transform.position = TreeStart;
        TreeSmasher.transform.position = TreeSmasherStart;
        Bear.transform.position = BearStart;
        WaterPlugcube.transform.position = WaterPlugStart;
        Gator1.transform.position = Gator1Start;
        Gator2.transform.position = Gator2Start;
        Gator3.transform.position = Gator3Start;
        GrabbableRoof.transform.position = GrabbableRoofStart;
        TempleDoor.transform.position = TempleDoorStart;
        LoweringPlatform1.transform.position = LoweringPlatform1Start;

        GatorGate1.SetActive(true);
        GatorGate2.SetActive(true);
        GatorGate3.SetActive(true);


    }

}
