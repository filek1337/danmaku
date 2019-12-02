using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.2f; // w hierarchi w komponencie Player można zmieniać w Unity. Nie zapisze się to w skrypcie. Niestety trzeba to samemu w skrypcie przestawiać

    public int score = 0;
    public GameObject Shot;
    public GameObject Player;
    public Transform Player_position;
    public float ShotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Shot.transform.position = Player.transform.position;
        Shot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            GameObject shot1 = Instantiate(Shot, Player_position.position, Player_position.rotation) as GameObject;
            shot1.SetActive(true);
            shot1.GetComponent<Rigidbody2D>().velocity = Player_position.forward * ShotSpeed * Time.deltaTime;
            

        }
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit(); // zamykanie gry. Działa tylko w grze, a nie w edytorze
        }

        // poruszanie gracza

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -speed, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed, 0, 0); // f - float
        }
    }
}
