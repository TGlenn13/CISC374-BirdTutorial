using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript birdStatus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3 && birdStatus.getBirdStatus()) {
            logic.addScore(1);
        }
    }
}
