using UnityEngine;
using System.Collections;

public class LogicControlScript : MonoBehaviour {

    public GameObject panel;
    public GameObject clickArea;

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;

    Vector3 posPoint1;
    Vector3 posPoint2;
    Vector3 posPoint3;
    Vector3 posPoint4;

	// Use this for initialization
	void Start () {
        posPoint1 = new Vector3(-6, 7, 0);
        posPoint2 = new Vector3(-2, 7, 0);
        posPoint3 = new Vector3(2, 7, 0);
        posPoint4 = new Vector3(6, 7, 0);

        StartCoroutine(MyMethod());
	}

    IEnumerator MyMethod()
    {
        while (true)
        {
            int r = Random.Range(1, 5);
            if (r == 1)
                addPoint(point1, posPoint1);
            else if (r == 2)
                addPoint(point2, posPoint2);
            else if (r == 3)
                addPoint(point3, posPoint3);
            else if (r == 4)
                addPoint(point4, posPoint4);
            yield return new WaitForSeconds(Random.Range(0.1f, 1));
        }
    }


    void Update()
    {
        
    }

    void addPoint(GameObject point, Vector3 pos)
    {
        var c = (GameObject)Instantiate(point, pos, Quaternion.identity);
        c.transform.parent = panel.transform;
    }
}
