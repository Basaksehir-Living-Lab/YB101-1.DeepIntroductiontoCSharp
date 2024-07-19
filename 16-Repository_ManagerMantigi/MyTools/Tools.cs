namespace _16_Repository_ManagerMantigi.MyTools
{
    public static class Tools
    {
        public static bool BilgileriKontrolEt(GroupBox grp)
        {
            bool sonuc = false;

            foreach (var item in grp.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    if (string.IsNullOrEmpty(t.Text))
                    {
                        sonuc = true;
                        break;
                    }
                }
            }

            return sonuc;
        }
    }
}
