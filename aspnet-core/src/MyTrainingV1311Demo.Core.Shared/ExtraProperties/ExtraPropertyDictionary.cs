﻿using System;
using System.Collections.Generic;
using Abp.Json;

namespace MyTrainingV1311Demo.ExtraProperties
{
    [Serializable]
    public class ExtraPropertyDictionary : Dictionary<string, object>
    {
        public ExtraPropertyDictionary()
        {
        }

        public ExtraPropertyDictionary(IDictionary<string, object> dictionary)
            : base(dictionary)
        {
        }

        public override string ToString()
        {
            return this.ToJsonString();
        }
    }
}