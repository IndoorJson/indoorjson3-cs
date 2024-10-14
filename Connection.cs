/*
 * File Name: Connection.cs
 *
 * Copyright (c) 2023 - 2024 IndoorJson
 *
 * Author: Kunlin Yu <yukunlin@syriusrobotics.com>
 * Create Date: 2024/1/21
 *
 */
using NetTopologySuite.Geometries;

namespace indoorjson3
{
    class Connection : Feature
    {
        public Cell fr;
        public Cell to;
        public Geometry bound;
        public Geometry edge;
    };
}  // namespace indoorjson3