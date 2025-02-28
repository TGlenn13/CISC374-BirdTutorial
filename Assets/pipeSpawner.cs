using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 2f;
    private float timer = 0;
    public float heightOffset = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate){
            timer = timer + Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        GameObject newPipe = Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        ApplyRandomColor(newPipe);
    }
    void ApplyRandomColor(GameObject pipeObject) {
{
        // ChatGPT
        // Get all SpriteRenderers in the pipe (including children)
        SpriteRenderer[] spriteRenderers = pipeObject.GetComponentsInChildren<SpriteRenderer>();

        // Generate a random bright color
        Color randomColor = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
        //ChatGPT end

        // Apply the same random color to all sprite renderers (top & bottom pipe)
        foreach (SpriteRenderer sr in spriteRenderers){
            sr.color = randomColor;
            }
        }
    }
}
