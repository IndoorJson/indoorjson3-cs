/*
 * File Name: RLines.cs
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
    class RLine
    {
        public Connection fr;
        public Connection to;
    };

    class RLines : Feature
    {
        public Cell cell;
        public List<Connection> ins;
        public List<Connection> outs;
        public List<RLine> closure;
    };

}  // namespace indoorjson3