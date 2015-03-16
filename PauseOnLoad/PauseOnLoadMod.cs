using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICities;

namespace PauseOnLoad
{
    public class Mod : IUserMod
    {

        public string Description
        {
            get { return "Automatically pauses the game when loaded"; }
        }

        public string Name
        {
            get { return "Pause on load"; }
        }
    }

    public class PauseOnLoadMod : LoadingExtensionBase
    {
        ILoading loading;

        public override void OnCreated(ILoading loading)
        {
            this.loading = loading;
        }

        public override void OnLevelLoaded(LoadMode mode)
        {
            loading.managers.threading.simulationPaused = true;
        }
    }
}
