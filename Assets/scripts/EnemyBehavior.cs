using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maszerowanie : MonoBehaviour
{
    public uint GoFrames = 120;        // Iloœæ klatek ruchu do przodu
    public uint RotateFrames = 90;     // Iloœæ klatek obrotu
    public uint WaitFrames = 120;      // Iloœæ klatek oczekiwania

    void Start()
    {
        StartCoroutine(Maszeruj());
    }

    IEnumerator Maszeruj()
    {
        int i;

        while (true)
        {
            //--- Ruch do przodu ---//
            for (i = 0; i < GoFrames; i++)
            {
                transform.Translate(Vector3.forward * Time.deltaTime);
                yield return null;
            }

            //--- Obrót ---//
            for (i = 0; i < RotateFrames; i++)
            {
                transform.Rotate(0, 1, 0);
                yield return null;
            }

            //--- Strza³ (utworzenie sfery) ---//
            var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            var rb = sphere.AddComponent<Rigidbody>();
            sphere.transform.position = transform.TransformPoint(1 * Vector3.forward);
            sphere.transform.localScale = 0.3333f * Vector3.one;
            rb.velocity = transform.TransformDirection(10 * Vector3.forward);

            StartCoroutine("Bullet", sphere);
            yield return null;

            //--- Oczekiwanie ---//
            for (i = 0; i < WaitFrames; i++)
                yield return null;
        }
    }


    IEnumerator Bullet(GameObject sphere)
    {
        yield return new WaitForSeconds(2);

        Destroy(sphere);
    }
}
