using UnityEngine;
using System.Collections;

public class A : MonoBehaviour
{
	Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3(0,10,0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log("デバッグ");
		Save();
	}

	void Save()
	{
		Debug.Log("セーブ");
	}

	void Load()
	{
		Debug.Log("ロード");
	}

    void Hoge()
    {
        Debug.Log("hoge");
    }

    void HogeHoge()
    {
        int a = 0;
    }

}
