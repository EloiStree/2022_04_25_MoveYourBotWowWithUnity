using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Action_Post_MoveCursor_PCT_LRTD : IUser32Action
{
    public IntPtrProcessId m_processId;
    public PercentPoint m_whereToMove;
}

