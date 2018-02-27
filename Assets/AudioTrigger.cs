using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour {

    [SerializeField]
    private AudioClip aveRuidosaEscondida;
    [SerializeField]
    private AudioClip aveRuidosaExpuesta;
    [SerializeField]
    private AudioClip aveSilenciosa;
    [SerializeField]
    private AudioClip aveSolitaria;
    [SerializeField]
    private AudioClip avesYGrillos;
    [SerializeField]
    private AudioClip ranasCantando;
    [SerializeField]
    private AudioClip gavilan;
    [SerializeField]
    private AudioClip gavilanMasLucido;

    public AudioSource source;
    private float volRange = 1.0f;


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tucaneta"))
        {
            source.Stop();
            source.PlayOneShot(aveRuidosaEscondida, volRange);

        }
        else

        if (other.gameObject.CompareTag("Cristofue"))
        {
            source.Stop();
            source.PlayOneShot(aveRuidosaExpuesta, 0.18f);

        }
        else

        if (other.gameObject.CompareTag("Gorrion"))
        {
            source.Stop();
            source.PlayOneShot(aveSilenciosa, 0.5f);

        }
        else

        if (other.gameObject.CompareTag("Barranquero"))
        {
            source.Stop();
            source.PlayOneShot(aveSolitaria, volRange);

        }
        else

        if (other.gameObject.CompareTag("Grillos"))
        {
            source.Stop();
            source.PlayOneShot(avesYGrillos, volRange);

        }
        else

        if (other.gameObject.CompareTag("Ranas"))
        {
            source.Stop();
            source.PlayOneShot(ranasCantando, volRange);

        }

        else

        if (other.gameObject.CompareTag("Gavilan"))
        {
            source.Stop();
            source.PlayOneShot(gavilanMasLucido, volRange);

        }
        else

        if (other.gameObject.CompareTag("Gavilansin"))
        {
            source.Stop();
            source.PlayOneShot(gavilan, volRange);

        }

    }


}
