using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : CoinSystem{

    // public Transform Warptarget;
    public AudioSource coinaudio;

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        coinaudio.GetComponent<AudioSource>();
        coinaudio.Play();
        coinsCollect += 1;
        transform.position = new Vector3(0, -1000, 0);
        StartCoroutine(GoingON());

    }

    IEnumerator GoingON()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
