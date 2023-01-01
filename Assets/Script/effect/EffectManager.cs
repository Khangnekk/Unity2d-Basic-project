using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    static public EffectManager instance;
    List<GameObject> effects;

    private void Awake()
    {
        instance = this;
        this.loadEffect();
    }

    protected virtual void loadEffect()
    {
        effects = new List<GameObject>();
        foreach (Transform child in transform)
        {
            effects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    public virtual void SpawnVFX(string effectName, Vector3 position, Quaternion rot)
    {
        GameObject effect = Get(effectName);
        GameObject newEffect = Instantiate(effect, position, rot);
        newEffect.gameObject.SetActive(true);
    }

    protected virtual GameObject Get(string effectName)
    {
        foreach (GameObject child in effects)
        {
            if (child.name == effectName) return child;
        }
        return null;
    }
}
