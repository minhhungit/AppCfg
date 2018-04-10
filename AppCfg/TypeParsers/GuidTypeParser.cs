﻿using System;

namespace AppCfg.TypeParsers
{
    public class GuidTypeParser : ITypeParser<Guid>
    {
        public Guid Parse(string rawValue)
        {
            return Guid.Parse(rawValue);
        }
    }
}