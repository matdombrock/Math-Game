using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
    public float speed = 5.0F;
    public int curSum = 0;
    public GameObject jumpparts;
    public GameObject Body;
    public GameObject Wing;
    public Quaternion WingPos;
    public AudioSource jumpSFX;
    public AudioSource hitSFX;
    public AudioSource clickSFX;
    public string dir = "right";
    void Start(){
            WingPos=Wing.transform.rotation;
    }
    void Update() {
        float translation_x = Input.GetAxis("Horizontal") * speed;
        translation_x *= Time.deltaTime;
        transform.Translate(translation_x, 0, 0);
        //transform.Rotate(0, rotation, 0);
        if(Input.GetButtonDown("Jump")){
            jumpSFX.Play();
            Instantiate(jumpparts, transform.position, transform.rotation);
        	GetComponent<Rigidbody>().AddForce(transform.up * speed*45);
            int i = 0;
            
        }
        if(Input.GetButton("Jump")){
               Wing.transform.localRotation = Quaternion.Euler(new Vector3(-45,-90,270));
        }
        if(Input.GetButtonUp("Jump")){
               Wing.transform.localRotation = WingPos;
        }
        if(translation_x > 0.01f && translation_x > 0.01f){
            Body.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
        }
        if(translation_x < -0.01f){
            Body.transform.rotation = Quaternion.Euler(new Vector3(0,180,0));
        }

    }
    void OnCollisionEnter(Collision collision)
    { 
       clickSFX.Play();
       if (collision.gameObject.tag == "Enemy"){
            hitSFX.Play();
            int value = int.Parse(collision.gameObject.GetComponentInChildren<TextMesh>().text);
            collision.gameObject.GetComponentInChildren<EnemyMove>().Die();
            curSum=curSum+value;
       }
    }   
}