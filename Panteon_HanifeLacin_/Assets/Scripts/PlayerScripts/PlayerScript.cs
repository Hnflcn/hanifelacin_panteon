using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody playerRB;

    public GameObject missionFailedPanel;
    public GameObject missionCompletedPanel;

    [HideInInspector]public bool isAlive = true;
    [HideInInspector]public bool won = false;

    
    public float levelUpTime = 25f; //sayaç

    void Start()
    {
        Time.timeScale = 1;
        playerRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
       // transform.position = transform.position + Vector3.forward;
       
        transform.position += Vector3.forward * 10*Time.deltaTime;

        gameObject.transform.rotation = new Quaternion(0,0,0,1);

        float x = transform.position.x;
        float z = transform.position.z;

        gameObject.transform.position = new Vector3(x,0,z);

        if(Input.GetKey("a")){
            moveLeft();
        }
        if(Input.GetKey("d")){
            moveRight();
        }
    }

    void Update()
    {
        if(isAlive == false){
            GameOverFail();
        }
        else{
            levelUpTime -= Time.deltaTime;  // sayaç geriye sayma
            Debug.Log(levelUpTime);
            
            if(won == true){
                GameOverWin();
            }
        }

    }


    private void moveRight(){
        transform.position += Vector3.right * Time.deltaTime *2f;
    }
    private void moveLeft(){
        transform.position += Vector3.left * Time.deltaTime *2f;
    }

    


    private void GameOverFail(){
        Debug.Log("Player died");
        
        Time.timeScale = 0;
        missionFailedPanel.SetActive(true);
    }
    private void GameOverWin(){
        Debug.Log("Player won");
        
        Time.timeScale = 0;
        missionCompletedPanel.SetActive(true);
    }

    public void TryAgain(){
        missionFailedPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void GoNextLevel(){
        missionCompletedPanel.SetActive(false);
        SceneManager.LoadScene('1');
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Finish"){
            won = true;
        }
        else if(other.gameObject.tag != "Rakip" && other.gameObject.tag != "kenar"){

            isAlive = false;
        }
    }

    


}
