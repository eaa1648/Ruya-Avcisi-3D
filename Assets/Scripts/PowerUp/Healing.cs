using UnityEngine;

public class Healing : PowerUp
{
    GameObject player;
    PlayerHealth playerHealth;
    public AudioSource healingAudio;

    public override void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        playerHealth = player.GetComponent<PlayerHealth>();
    }

    public override void OnTriggerEnter(Collider other)
    {
        float dist = Vector3.Distance(other.transform.position, transform.position);
        if ((other.tag == "Player") && (dist < 1.5))
        {
            playerHealth.Healing();
            this.gameObject.SetActive(false);
        }
    }
}
