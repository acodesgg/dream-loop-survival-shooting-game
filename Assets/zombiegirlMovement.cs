using UnityEngine;
using System.Collections;

using UnityEngine.AI;


public class zombiegirlMovement : MonoBehaviour
{
	public GameObject player1;
	private AudioSource sound;
	private Animator anim;
	private string state = "idle";
	private bool alive = true;


	Transform player;
	//PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	UnityEngine.AI.NavMeshAgent nav;


	void Start()
	{
		sound = GetComponent<AudioSource> ();
		anim = GetComponent<Animator> ();
		//nav.speed = 1.2f;
		anim.speed = 1.2f;
		//   player = GameObject.FindGameObjectWithTag ("Player").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}


	void Update ()
	{
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//{
		//  nav.SetDestination (player.position);
		//}
		//else
		//{
		//    nav.enabled = false;
		//}
		if (alive) {
			anim.SetFloat ("velocity", nav.velocity.magnitude);
			if (state == "idle") {
				Vector3 randomPos = Random.insideUnitSphere * 20f;
				NavMeshHit navhit;
				NavMesh.SamplePosition (transform.position + randomPos, out navhit, 20f,NavMesh.AllAreas);
				nav.SetDestination (navhit.position);
				state = "walk";
			}
			if (state == "walk") {

				if (nav.remainingDistance <= nav.stoppingDistance && !nav.pathPending) {

					state = "idle";
				}
			}

		}
	}
}
