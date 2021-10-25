using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Linq; 



public static class SceneSelector 
{
    //creating a menu option that will help us access scenes quickly
    //lobby
    [MenuItem("Scenes/Lobby")]
    static void OpenLobby()
    {
        Load("Lobby"); 
    }

    //green place
    [MenuItem("Scenes/Green Place")]
    static void OpenGreenPlace()
    {
        Load("GreenPlace");
    }

    //red place
    [MenuItem("Scenes/Red Place")]
    static void OpenRedPlace()
    {
        Load("RedPlace");
    }
    static void Load(string scene)
    {
        //So we dont lose changes just in case. IMPORTANT maybe?
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();

        Scene xrScene = EditorSceneManager.OpenScene("Assets/Scenes/XR.unity", OpenSceneMode.Single);
        Scene newScene = EditorSceneManager.OpenScene("Assets/Scenes/" + scene + ".unity", OpenSceneMode.Additive);

        XRSceneTransitionManager.PlaceXRRig(xrScene, newScene);

    }





}
