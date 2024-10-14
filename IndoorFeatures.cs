/*
 * File Name: IndoorFeatures.cs
 *
 * Copyright (c) 2023 - 2024 IndoorJson
 *
 * Author: Kunlin Yu <yukunlin@syriusrobotics.com>
 * Create Date: 2024/1/21
 *
 */

using System.Collections.Generic;

namespace indoorjson3
{

    class IndoorFeatures : Feature
    {
        public List<Cell> cells;
        public List<Connection> connections;
        public List<Layer> layers;
        public List<RLines> rlineses;
    };

}  // namespace indoorjson3