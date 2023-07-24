using UnityEngine;

public abstract class PersistentData : ScriptableObject
{
    public void Save()
    {
        var settings = new ES3Settings { memberReferenceMode = ES3.ReferenceMode.ByRefAndValue };
        ES3.Save(name, this, settings);
    }

    public virtual void Load()
    {
        if (ES3.KeyExists(name))
        {
            ES3.LoadInto(name, this);
        }
    }

}
