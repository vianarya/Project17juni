using UnityEngine;
[CreateAssetMenu(fileName ="CarData", menuName = "Game Data/Car Data")]
public class CarData : ScriptableObject
{
   [SerializeField]private string carID;
   [SerializeField]private float moveSpeed = 1f;
   [SerializeField]private float turnSpeed = 1f;
   [SerializeField]private Sprite carSprite;

   public string CarID => carID;
   public float MoveSpeed => moveSpeed;
   public float TurnSpeed => turnSpeed;
   public Sprite CarSprite => carSprite;
   
}
