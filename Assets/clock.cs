using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    [SerializeField] Gradient directionalGradient,ambientGradient;
    public Light dirlight;
    [SerializeField, Range(1, 3600)] float maxduration = 1200;
    public int weeks, days, hours, minutes;
    Vector3 defaultAngels;
    [SerializeField, Range(0f, 1f)] float gameduration;//days
    public float tik = 50;
   
    void Start()
    {
        defaultAngels = dirlight.transform.localEulerAngles;
    }
    void Update()
    {
        if(Application.isPlaying)
        gameduration += Time.deltaTime / maxduration;
        tik -= Time.deltaTime;
        if (tik <= 0)
        {
            hours += 1;
            if (hours >= 24)
            {
                hours = 0;
                days += 1;
                weeks = days / 7;
            }
            tik = 50;
        }
        if (gameduration > 1f)
            gameduration = 0;
        dirlight.color=directionalGradient.Evaluate(gameduration);
        RenderSettings.ambientLight = ambientGradient.Evaluate(gameduration);
        dirlight.transform.localEulerAngles = new Vector3(360f * gameduration - 90, defaultAngels.x, defaultAngels.z);
    }
}
