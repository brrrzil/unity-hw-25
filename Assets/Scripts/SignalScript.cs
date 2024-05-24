using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalScript : MonoBehaviour
{
    public void DestroyME()
    {
        Destroy(this.gameObject);
    }
}