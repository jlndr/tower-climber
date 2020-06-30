using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offset = new Vector3(0, 0, -1);

	void LateUpdate()
	{
		if (target)
		{
			Vector3 desiredPos = target.position + offset;
			Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
			smoothedPos.x = 0;
			transform.position = smoothedPos;

		}

	}

}
