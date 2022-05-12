namespace DAL
{
    public class DataContextFactory
    {
        private static JogoDataContext dataContext;

        public static JogoDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new JogoDataContext();

                return dataContext;
            }
        }
    }
}
