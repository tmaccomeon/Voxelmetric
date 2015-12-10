﻿using System;
using System.Collections;

public struct BlockConfig
{
    public string name;
    public string controller;

    public string[] textures;
    public bool isSolid;
    public bool solidTowardsSameType;

    public string meshFileName;
    public float meshXOffset;
    public float meshYOffset;
    public float meshZOffset;

    public Hashtable additionalProperties;

    public override string ToString()
    {
        return name;
    }
}
