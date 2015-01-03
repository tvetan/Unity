using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float speed;

	public GUIText pickUpCountText;

	public GUIText winText;

	private int pickUpCount;

	public void Start()
	{
		this.pickUpCount = 0;
		this.pickUpCountText.text = string.Format ("Count: {0}", this.pickUpCount);
		this.winText.text = string.Empty;
	}

	public void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		this.rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
		
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp") 
		{
			other.gameObject.SetActive(false);
			this.pickUpCount = this.pickUpCount + 1;
			this.pickUpCountText.text = string.Format ("Count: {0}", this.pickUpCount);

			if (this.pickUpCount >= 12) 
			{
				this.winText.text = "You win";
			}
		}
	}
}