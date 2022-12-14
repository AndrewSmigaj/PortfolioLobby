using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneUtils 
{

    private static GameObject xrRigPers;

    public enum SceneId
    {
        Maze,
        Lobby,
        ComplexInteractions,
        RecruitmentLobby
    }

    public static readonly string[] scenes = { Names.maze, Names.lobby, Names.carScene, Names.recruitmentLobby };

    public static GameObject XrRigPers { get => xrRigPers; set => xrRigPers = value; }

    public static class Names
    {
        public static string xRRigPersistentName = "XRPersistentScene";
        public static string maze = "SampleScene";
        public static string carScene = "CarScene";
        public static string lobby = "Lobby pt2";
        public static string recruitmentLobby = "Not Implemented";
    }

    //public static string xRRigPersistentName = "XRPersistentScene";

    public static void AlignXRRig(Scene persistent, Scene current)
    {
        //find xr rig in persistent and xr origin in current
        GameObject[] pers = persistent.GetRootGameObjects();
        GameObject[] curr = current.GetRootGameObjects();

        foreach(var possibleOrigin in curr)
        {
            //for now need special case for car scene since it is inside another object
            if(current.name == "CarScene")
            {
                Debug.Log("Car Scene special case entered");
                var possibleOriginAlt = GameObject.FindGameObjectWithTag("XRRigOriginCar");
                foreach (var possibleRig in pers)
                {
                    if (possibleRig.CompareTag("XRRig"))
                    {
                        possibleRig.transform.position = possibleOriginAlt.transform.position;
                        possibleRig.transform.rotation = possibleOriginAlt.transform.rotation;

                        //XrRigPers = possibleRig;


                        possibleOriginAlt.transform.parent.GetComponentInParent<CarBehavior>().SetXRRigReferenceForCar();
                        //possibleRig.transform.parent = possibleOriginAlt.transform.parent;
                        return;
                    }
                }

            }
            else if (possibleOrigin.CompareTag("XRRigOrigin"))
            {
                foreach(var possibleRig in pers)
                {
                    if (possibleRig.CompareTag("XRRig"))
                    {
                        possibleRig.transform.position = possibleOrigin.transform.position;
                        possibleRig.transform.rotation = possibleOrigin.transform.rotation;
                        return;
                    }
                }
            }
        }
    }
}
