/*
 * File Name: Cell.cs
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
    class Cell : Feature
    {
        public Geometry space;
        public Geometry node;
    };
}  // namespace indoorjson3