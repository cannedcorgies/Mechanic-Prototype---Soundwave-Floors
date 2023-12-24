//// CREDITS ////
//
//  - adopted from Peer Play on YouTube
//      - https://youtu.be/mHk3ZiKNH48?si=rdaIzi7dtoq5Oeky

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameticCube : MonoBehaviour
{

    public int band;
    public float startScale;
    public float scaleMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = new Vector3(transform.localScale.x, (AudioPeer.freqBand[band] * scaleMultiplier) + startScale, transform.localScale.z);
        
    }
}
