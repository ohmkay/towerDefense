using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wayPointIndex = 0;

	void Start ()
    {
        Waypoints waypoints = GameObject.FindObjectOfType<Waypoints>();
        target = Waypoints.waypoints[0];		
	}
	
	void Update ()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);


	}
}
