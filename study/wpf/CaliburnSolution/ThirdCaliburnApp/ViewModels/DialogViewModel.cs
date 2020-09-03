﻿using Caliburn.Micro;

namespace ThirdCaliburnApp.ViewModels
{
    public class DialogViewModel : Conductor<object>, IHaveDisplayName
    {
        public override string DisplayName { get; set; }
    }
}
