﻿namespace CryoFall.Automaton.UI.Data
{
    using CryoFall.Automaton.UI.Data.Options;
    using CryoFall.Automaton.UI.Managers;

    public class ViewModelSettingsGlobal : ViewModelSettings
    {
        public string UpdateIntervalText => "Update interval (s)";

        public string UpdateIntervalToolTip => "How often mod will attempt to do something.";

        public override string Name => "Settings";

        public override string Description => "Global mod settings.";

        public ViewModelSettingsGlobal() : base()
        {
            Options.Add(new OptionTextBoxDouble(
                id: "UpdateInterval",
                label: UpdateIntervalText,
                defaultValue: 0.5d,
                valueChangedCallback: (val) => AutomatonManager.UpdateInterval = val,
                toolTip: UpdateIntervalToolTip));

            InitSettings();
        }
    }
}