using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Translatable_Demo
{
    public class ObjectRotator : MonoBehaviour
    {
        void Update()
        {
            transform.localRotation = Quaternion.Euler(0, 30f * Mathf.Sin(Time.time), 1);
        }
    }
}
