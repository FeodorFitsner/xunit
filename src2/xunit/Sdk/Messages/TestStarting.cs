﻿using Xunit.Abstractions;

namespace Xunit.Sdk
{
    public class TestStarting : LongLivedMarshalByRefObject, ITestStarting
    {
        public ITestCase TestCase { get; set; }
        public string DisplayName { get; set; }
    }
}