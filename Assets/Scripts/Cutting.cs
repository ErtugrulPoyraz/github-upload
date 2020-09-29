using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class Cutting : MonoBehaviour
{
    public Material mat;
    public LayerMask mask;
    public static int score;

    public void Start()
    {
        score = 0;
    }

    public SlicedHull Cut(GameObject obj , Material mat = null)
    {
        return obj.Slice(transform.position, transform.right, mat);
    }

    void OnTriggerEnter(Collider other)
    {
        SlicedHull cuttedobject = Cut(other.gameObject, mat);
        GameObject cuttedbottom = cuttedobject.CreateLowerHull(other.gameObject,mat);
        GameObject cuttedtop = cuttedobject.CreateUpperHull(other.gameObject,mat);
        score++;

        AddPhysics(cuttedbottom);
        AddPhysics(cuttedtop);

        cuttedbottom.GetComponent<Rigidbody>().AddForce(0f, 0f, 50f);
        cuttedtop.GetComponent<Rigidbody>().AddForce(0f, 0f, -50f);
        Destroy(other.gameObject);
        Destroy(cuttedbottom, 3f);
        Destroy(cuttedtop, 3f);
    }
    
    void AddPhysics(GameObject obj)
    {
        obj.AddComponent<Rigidbody>();
        obj.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
        obj.GetComponent<Rigidbody>().AddExplosionForce(100, obj.transform.position, 20);
    }
}
