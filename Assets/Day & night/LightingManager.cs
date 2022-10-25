using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LightingManager : MonoBehaviour
{
    //References
   [SerializeField]  Light DirectionalLight;
   [SerializeField]  LightingPreset Preset;
   //Variables 
   [SerializeField, Range(0, 1800)]  float TimeOfDay;


    private void Update()
    {
        if(Preset == null)
            return;

        if(Application.isPlaying)
        {
            TimeOfDay += Time.deltaTime;
            TimeOfDay %= 1800; //Clamp between 0 - 600
            UpdateLighting(TimeOfDay / 1800f);
        }
        else 
        {
            UpdateLighting(TimeOfDay / 1800f);
        }
    }

    private void UpdateLighting(float timePercent)
    {

        RenderSettings.ambientLight = Preset.AmbientColor.Evaluate(timePercent);
        RenderSettings.fogColor = Preset.FogColor.Evaluate(timePercent);

        if (DirectionalLight != null)
        {
            DirectionalLight.color = Preset.DirectionalColor.Evaluate(timePercent);

            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 90f, 0f));
        }
    }

    //Try to find a directional light to use if we haven't set one
   private void OnValidate()
   {

    if (DirectionalLight!= null)
    return;

    //Search for lighting tab sun
    if (RenderSettings.sun !=null)
    {
        DirectionalLight = RenderSettings.sun;
    }
    //Search scene for light that fits critearia (Driectional)
    else
    {
        Light[] lights = GameObject.FindObjectsOfType<Light>();
        foreach (Light light in lights)
        {
            if (light.type == LightType.Directional)
            DirectionalLight = light;
            return;
        }
    }
   }
}
