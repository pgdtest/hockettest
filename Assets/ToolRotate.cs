using UnityEngine;
using System.Collections;

public class ToolRotate : MonoBehaviour {

    public Vector3 v3Speed;
	// Use this for initialization
    Vector3 v3Rotation;
    public bool isCheck;
    float fDegree;
    void Start () {
        v3Rotation = gameObject.transform.localEulerAngles;
	}
	
	// Update is called once per frame
	
   

    void Update () {
        /*
        fDegree += Time.deltaTime * v3Speed;

        if (fDegree > 360)
        {
            fDegree = fDegree % 360;
        }
        //gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.localEulerAngles.x, fDegree, gameObject.transform.localEulerAngles.z);

         */
        v3Rotation += (v3Speed * Time.deltaTime);
        gameObject.transform.localEulerAngles = v3Rotation;
        /*
        gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.localEulerAngles.x +(v3Speed.x * Time.deltaTime),
            gameObject.transform.localEulerAngles.y +(v3Speed.y * Time.deltaTime),
            gameObject.transform.localEulerAngles.z +(v3Speed.z * Time.deltaTime)
                );
         * */
        if (isCheck)
        {
            Debug.Log(gameObject.transform.localEulerAngles + " : " + v3Rotation + " =" + (v3Speed * Time.deltaTime));
        }
    }
}
