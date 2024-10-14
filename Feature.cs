/*
 * File Name: Feature.cs
 *
 * Copyright (c) 2023 - 2024 IndoorJson
 *
 * Author: Kunlin Yu <yukunlin@syriusrobotics.com>
 * Create Date: 2024/1/21
 *
 */
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace indoorjson3
{
    class Feature
    {
        // string id;
        public string name;
        public string desc;
        public string ext_ref;
        public Envelope envelope;
        public Dictionary<string, object> properties;
    };

}  // namespace indoorjson3