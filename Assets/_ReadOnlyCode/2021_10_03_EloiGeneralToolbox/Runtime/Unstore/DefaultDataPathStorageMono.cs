using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultDataPathStorageMono : Eloi.AbstractMetaAbsolutePathDirectoryMono
{
    public string m_debug;
    public override void GetPath(out string path)
    {
        path = Application.dataPath;
        m_debug = path;
    }

    public override string GetPath()
    {
        GetPath(out string p);
        return p;
    }
}
