using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private GameManager gm;
    static float t = 0.0f;
    private float minimum = 1.75F;
    private float maximum = 2.0F;
    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        gm.points++;
        gm.UpdateText();
    }

    private void OnMouseOver()
    {
        
        this.transform.localScale = new Vector3(Mathf.Lerp(minimum, maximum, t),Mathf.Lerp(minimum, maximum, t), 1f);
        
        // .. and increase the t interpolater
        t += 0.7f * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }
    private void OnMouseExit()
    {
        this.transform.localScale = new Vector3(2, 2, 1);
    }
}
