using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRandomTest : MonoBehaviour
{
    public List<GameObject> Itens;

    public void RandomItem()
    {
        var a = Instantiate(Itens.GetRandom());
        a.transform.position = Vector3.zero;
        Debug.Log("Result:" + a.gameObject.name);

    }

}
