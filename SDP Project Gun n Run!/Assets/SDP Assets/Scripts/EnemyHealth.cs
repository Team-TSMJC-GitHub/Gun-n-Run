using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{ 
    public GameObject effectPrefab;
    public AudioClip destroySound;
    public int enemyHP;


    private Slider slider;

    void Start()
    {

        // GameObject.Find ("○○") can decide the name of object 
        slider = GameObject.Find("EnemyHPSlider").GetComponent<Slider>();

        // maximum slider
        slider.maxValue = enemyHP;

        // current slider
        slider.value = enemyHP;
    }


    void OnTriggerEnter(Collider other)
    {

        // if it has the tag of missile,
        if (other.gameObject.CompareTag("Laser"))
        {

            // generate effect
            /* GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity) as GameObject;
             // remove effect
             Destroy(effect, 0.5f);
             */
            // decrease hp by 1
            enemyHP -= 1;

            // change value of health bar
            slider.value = enemyHP;

            // delete bullet
            Destroy(other.gameObject);

            // when boss health bacomes 0, the object destroys
            if (enemyHP == 0)
            {

                // destroy boss
                Destroy(transform.root.gameObject);

                // generate the sound effects when it destroys
                //  AudioSource.PlayClipAtPoint(destroySound, transform.position);
            }
        }
    }
}