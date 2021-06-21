using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    
        public class Counter
        {
            public double MinValue { get; set; }
            public double CurrentValue { get; set; }
            private double _maxValue;
            public double MaxValue
            {
                get { return _maxValue; }
                set
                {
                    if (value <= MinValue)
                        throw new ArgumentOutOfRangeException(nameof(_maxValue), "Max counter must be more than min");

                    _maxValue = value;
                }
            }
            public Counter(in double minValue, in double maxValue)
            {
                MinValue = minValue;
                MaxValue = maxValue;
                CurrentValue = minValue;
            }
            public double Increment()
            {
            Console.ForegroundColor = ConsoleColor.Green;

            return (CurrentValue == MaxValue) ? CurrentValue = MinValue : ++CurrentValue;
            }
        }
    }
