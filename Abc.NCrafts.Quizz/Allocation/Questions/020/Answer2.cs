﻿using System;

namespace Abc.NCrafts.Quizz.Questions._020
{
    public class Answer2
    {
        public static void Run()
        {
            // begin
            var d1 = new DateTime(1983, 03, 02);
            IDateWrapper w = new DateWrapper(d1);
            var d2 = w.Value;
            // end

            Logger.Log("Date: ", d2);
        }

        private interface IDateWrapper
        {
            DateTime Value { get; }
        }

        private struct DateWrapper : IDateWrapper
        {
            public DateWrapper(DateTime value)
                : this()
            {
                Value = value;
            }

            public DateTime Value { get; private set; }
        }
    }
}
