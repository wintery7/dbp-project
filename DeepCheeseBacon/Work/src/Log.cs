namespace deepcheesebacon.work.src
{
    internal class Log
    {
        private static Log instance;

        /* ----- Constructor ----- */
        private Log() { }

        /* ----- Instance ----- */
        public static Log Instance
        {
            get
            {
                if (instance == null) instance = new Log();

                return instance;
            }
        }

        /* ----- Log ----- */
        public void Here(string log)
        {
            MessageBox.Show(log);
        }
    }
}
