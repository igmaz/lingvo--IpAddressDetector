namespace Ude.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class HZSMModel : SMModel
    {
        private static readonly int[] HZ_cls = new int[ /*32*/ ]
        {
        BitPackage.Pack4bits(1, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 1, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 0, 0, 0, 0, 0),
        BitPackage.Pack4bits(0, 0, 0, 4, 0, 5, 2, 0),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1)
        };

        private static readonly int[] HZ_st = new int[]
        {
        BitPackage.Pack4bits(0, 1, 3, 0, 0, 0, 1, 1),
        BitPackage.Pack4bits(1, 1, 1, 1, 2, 2, 2, 2),
        BitPackage.Pack4bits(2, 2, 1, 1, 0, 0, 4, 1),
        BitPackage.Pack4bits(5, 1, 6, 1, 5, 5, 4, 1),
        BitPackage.Pack4bits(4, 1, 4, 4, 4, 1, 4, 1),
        BitPackage.Pack4bits(4, 2, 0, 0, 0, 0, 0, 0)
        };

        public HZSMModel(): base( new BitPackage( BitPackage.INDEX_SHIFT_4BITS,
                                                  BitPackage.SHIFT_MASK_4BITS, 
                                                  BitPackage.BIT_SHIFT_4BITS, 
                                                  BitPackage.UNIT_MASK_4BITS,
                                                  HZ_cls ), 6,
                                  new BitPackage( BitPackage.INDEX_SHIFT_4BITS, 
                                                  BitPackage.SHIFT_MASK_4BITS, 
                                                  BitPackage.BIT_SHIFT_4BITS, 
                                                  BitPackage.UNIT_MASK_4BITS, 
                                                  HZ_st ),
                                  HZCharLenTable, "HZ-GB-2312" )
        {
        }

        private static readonly int[] HZCharLenTable;
        static HZSMModel() => HZCharLenTable = new int[ 6 ];
    }
}