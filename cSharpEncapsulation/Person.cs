﻿
using System;

namespace cSharpEncapsulation
{
    class Person
    {
        private DateTime _birthdate;
        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
}
