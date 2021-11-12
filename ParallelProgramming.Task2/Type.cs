namespace ParallelProgramming.Task2
{
    public class Type
    {
        private int _type;

        //  this property sets and gets the barcode value
        public int Barcode { get; set; }


        // this property sets and gets the type value
        public int BarcodeType
        {
            get => _type;
            set => _type = value is <= 100 and >= 1 ? value : 10;
        }

    }
}