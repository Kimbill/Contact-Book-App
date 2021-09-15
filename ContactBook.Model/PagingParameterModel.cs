namespace ContactBook.Model
{
    public class PagingParameterModel
    {
        public const int maxPageSize = 50;

        public int PageNumber { get; set; } = 1;

        private int _PageSize = 10;

        public int PageSize
        {

            get { return _PageSize; }
            set
            {
                _PageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
