using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PandUtil : MonoBehaviour
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Pandora/Test")]
    public static void Test()
    {
        Debug.Log("Test");
    }

    [UnityEditor.MenuItem("Pandora/Test2 %g")]
    public static void Test2()
    {
        Debug.Log("Test2");
    }
#endif

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 0)
            return default(T);

        return array[Random.Range(0, array.Length)];
    }

}
