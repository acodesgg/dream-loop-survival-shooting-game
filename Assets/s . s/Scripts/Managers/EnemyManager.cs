using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
 //   public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 5f;
    public Transform[] spawnPoints;
	public int time1=0;
	public doorScript doors;
	public winCondition win;
	public bool zombie2=false;
	public bool _zombie2;
	public GameObject front;
    void Start ()
	{

        InvokeRepeating ("Spawn", spawnTime, spawnTime);

    }
	void Update (){
		
		time1 +=(int) (Time.time);
		//print(zombie2+"out");

		if (zombie2) {
			//print ("front");
			front.SetActive(false);
//			SceneManager.LoadScene ("testingcone");
		}
	}

	void setZombie(bool z){
		this.zombie2 = z;
	}

    void Spawn ()
    {
	//	print (time1);
		
if(time1>999999)
			
      {
			zombie2 = true;
			setZombie (zombie2);

          return;
       }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
}
