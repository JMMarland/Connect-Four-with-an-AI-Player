﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Connect_Four.Source.Players
{
    public interface IPlayer
    {
        Color Colour { get; }

        bool IsHuman { get; }

        void Update();
    }
}
