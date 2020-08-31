﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        public const string tomcatGender = "Male";
        public Tomcat(string name, int age)
            : base(name, age, tomcatGender)
        {

        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
