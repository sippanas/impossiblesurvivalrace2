namespace ImpossibleSurvivalRace2.Server
{
    public static class ServerUtils
    {
        private static DateTime _lastServerUpdate;

        public static bool CanUpdate()
        {
            DateTime currentUpdate = DateTime.Now;

            if(currentUpdate.Subtract(_lastServerUpdate).Milliseconds >= 500)
            {
                _lastServerUpdate = currentUpdate;
                return true;
            }

            return false;
        }
    }
}
