using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScalePlatforms : MonoBehaviour
{
    public int band;
    public float startScale, scaleMultiplier;
    public bool useBuffer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (useBuffer)
        {
            transform.localScale = new Vector3((AudioPeer.bandBuffer[band] * scaleMultiplier) + startScale,
                transform.localScale.y, (AudioPeer.bandBuffer[band] * scaleMultiplier) + startScale);
        }
        if (!useBuffer)
        {
            transform.localScale = new Vector3((AudioPeer.freqBand[band] * scaleMultiplier) + startScale,
                transform.localScale.y, (AudioPeer.freqBand[band] * scaleMultiplier) + startScale);
        }
    }
}
