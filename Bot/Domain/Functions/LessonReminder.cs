﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.Domain.Functions
{
    public class LessonReminder: IBotFunction
    {
        static public string Do(DateTime lessonStartTime)
        {
            while (true)
            {
                if (DateTime.Now.AddMinutes(10) == lessonStartTime)
                {
                    return "Пара сейчас начнется";
                }
            }
        }
    }
}
