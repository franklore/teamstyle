﻿using UnityEngine;

public class FireLine : MonoBehaviour {
    public ParticleSystem line;
    new AudioSource audio;
    ParticleSystem flash;
    public float range;

    void Awake () {
        audio = GetComponent<AudioSource>();
        flash = GetComponent<ParticleSystem>();
	}

    public void Fire(GameObject target)
    {
        if (target.name != "Terrain")
        {
            var hitpos = target.GetComponent<UnitControl>().position.Random(range) - transform.position;
            transform.rotation = Quaternion.LookRotation(hitpos);
        }
        else
        {
            
        }

        if (audio)
        {
            audio.Play();
        }

        flash.Play();
        line.GetComponent<BulletHit>().target = target;
        line.Play();
    }
}
