using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    public GameObject Player;

    private List<float> postions = new List<float>();

    private float currenPlayerPos = 0;

    private float HeightMove = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (Player != null)
        {
            currenPlayerPos = Player.transform.position.y;
            HeightMove = 2.6f * (float)Mathf.Abs(Player.transform.position.y - transform.position.y);
            postions.Add(transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currenPlayerPos + HeightMove < Player.transform.position.y)
        {
            Vector3 pos = transform.position;
            pos.y = postions[0] + HeightMove / 2;
            transform.position = pos;
        }
        else
        {
            Vector3 pos = transform.position;
            pos.y = postions[0];
            transform.position = pos;
        }
    }
}
