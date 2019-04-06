using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravity : MonoBehaviour
{

    public float gravity;

    private bool sumando = false;

    private void Awake()
    {
        gravity = Physics.gravity.y;
    }

    
    private void FixedUpdate()
    {
        
        IEnumerator changeValueOverTime(float fromVal, float toVal, float duration)
        {
            float counter = 0f;

            while (counter < duration)
            {
                if (Time.timeScale == 0)
                    counter += Time.unscaledDeltaTime;
                else
                    counter += Time.deltaTime;

                float val = Mathf.Lerp(fromVal, toVal, counter / duration);
                Debug.Log("Val: " + val);

                
                yield return null;
                
            }

            Physics.gravity = new Vector3(0, toVal, 0);
            yield return new WaitForSeconds(1);
            if (Physics.gravity.y >= toVal)
            {
                
                gravity = -gravity;
            }
            

        }

        StartCoroutine(changeValueOverTime(gravity,-gravity,0.5f));
        
    }
    
}
