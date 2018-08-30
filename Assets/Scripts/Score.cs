using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Transform target;
    public Text scoreText;
    private float game;

    // Update is called once per frame
    void Update()
    {
        scoreText.transform.position = new Vector3(0f, target.position.y + 4f, 0f);
        scoreText.text = (target.position.y * 10).ToString("0") ;
    }
}
