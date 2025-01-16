using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using static UnityEngine.GraphicsBuffer;

[CustomEditor(typeof(GetRandomTest))]
public class GetRandomEditor : Editor
{
    public override void OnInspectorGUI()
    {;
        base.OnInspectorGUI();
        GetRandomTest myTarget = (GetRandomTest)target;

        if (GUILayout.Button("Randomize"))
        {
            myTarget.RandomItem();
            

        }
    }
}
