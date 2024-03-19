using VoidManager.MPModChecks;

namespace LookUp
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107, Dragon";

        public override string Description => "Gets rid of pesky camera limitations.";
    }
}
