namespace Stock.Model
{
    public class StockBaseInfo
    {
        /// <summary>
        /// 1:HU-A,2:SZ-A
        /// </summary>
        public int Type { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        /// <summary>
        /// 0：不可用，1:可用
        /// </summary>
        public int Status { get; set; }
    }
}
