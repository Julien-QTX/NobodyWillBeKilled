
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [Header("-------AudioManager-------")]

    [SerializedField] AudioSource music source;
    public AudioClip Clé, Sauter, Opendoor, CloseDoor, Marcher ;

  [Header("-------AudioManager-------")]
    private void Start()
    {

     musicSource.clip= sauter;
     musicSource.Play();

     musicSource.clip= OpenDoor;
     musicSource.Play();

     musicSource.clip= CloseDoor ;
     musicSource.Play();

     musicSource.clip= Marcher;
     musicSource.Play();

    musicSource.clip=Clé ;
    musicSource.Play();

    }

}
