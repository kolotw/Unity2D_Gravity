using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameMaster : MonoBehaviour {
	public Transform spawnPos;
	private GameObject playerInScene;
	public GameObject myPlayer;
	public static bool isWon=false;
	public static int mySpeed=3;
	// Use this for initialization
	void Start () {
		playerInScene = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInScene==null){
			GameObject go;
			Vector2 spawnPos2D;
			spawnPos2D = new Vector2(spawnPos.transform.position.x,spawnPos.transform.position.y);
			go = Instantiate(myPlayer,spawnPos2D, Quaternion.identity)as GameObject;
			playerInScene = GameObject.FindWithTag("Player");
			print ("create player");
		}
		if(isWon){
			levelSelect();
			isWon=false;
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			
			SceneManager.LoadScene("menu");
		}
	}
	void levelSelect(){
		//SceneManager.LoadScene("002");
		string thisLevel;
		thisLevel = SceneManager.GetActiveScene().name; 
		switch(thisLevel){
			case "001":
				SceneManager.LoadScene("302001");
				break;
			case "302001":
				SceneManager.LoadScene("302002");
				break;
			case "302002":
				SceneManager.LoadScene("302003");
				break;
			case "302003":
				SceneManager.LoadScene("302004");
				break;
			case "302004":
				SceneManager.LoadScene("302005");
				break;
			case "302005":
				SceneManager.LoadScene("302006");
				break;
			case "302006":
				SceneManager.LoadScene("302007");
				break;
			case "302007":
				SceneManager.LoadScene("302008");
				break;
			case "302008":
				SceneManager.LoadScene("302009");
				break;
			case "302009":
				SceneManager.LoadScene("302010");
				break;
			case "302010":
				SceneManager.LoadScene("302011");
				break;
			case "302011":
				SceneManager.LoadScene("302012");
				break;
			case "302012":
				SceneManager.LoadScene("302013");
				break;
			case "302014":
				SceneManager.LoadScene("302015");
				break;
			case "302015":
				SceneManager.LoadScene("302016");
				break;
			case "302016":
				SceneManager.LoadScene("302017");
				break;
			case "302017":
				SceneManager.LoadScene("302018");
				break;

			default:
				break;
		}
	}
}
