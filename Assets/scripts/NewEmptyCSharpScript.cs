using UnityEngine;

public class Format : MonoBehaviour
{
    public Vector2[] position;
    public Vector2[] size;
    public int formatNumber;

    void Awake(){
        if(size.Length != position.Length){
            Debug.LogError($"Format {formatNumber} has diffrent sized, size and position arrays");
        }
   }
}
