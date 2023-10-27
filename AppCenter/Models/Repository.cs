namespace AppCenter.Models
{
    public static class Repository
    {
        private static List<Requester> requesters = new();

        public static IEnumerable<Requester> Requesters => requesters;


        public static void Add(Requester requester)
        {
            requesters.Add(requester);
        }
    }
}
