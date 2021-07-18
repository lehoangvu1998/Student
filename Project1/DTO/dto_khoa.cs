namespace Project1.DTO
{
    public class dto_khoa
    {
        public dto_khoa(int makhoa, string tenkhoa, int phongban, int sdt)
        {
            Makhoa = makhoa;
            Tenkhoa = tenkhoa;
            this.phongban = phongban;
            Sdt = sdt;
        }

        public dto_khoa()
        {
        }

        public int Makhoa { get ; set; }
        public string Tenkhoa { get; set; }
        public int phongban { get ; set ; }
        public int Sdt { get; set; }


    }
}
