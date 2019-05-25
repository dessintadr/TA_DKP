using System;


namespace WindowsFormsApp1
{
    class contact
    {
        private string namaAwal;
        private string namaAkhir;
        private string nomor;

        public string NamaAwal
        {
            get { return NamaAwal; }
            set{ namaAwal = value ;
            }
        }

        public string NamaAkhir
        {
            get { return NamaAkhir; }
            set { namaAkhir = value;
            }
        }
        public string Nomor
        {
            get { return Nomor;}
            set
            {
                if (value.Length <= 12)
                {
                    nomor = value;
                }
                else
                {
                    nomor = "00000";
                }
            }

        }
        public contact()
        {
            namaAwal = " ";
            namaAkhir = " ";
            nomor = " ";
        }
        public contact(string namaAwal, string namaAkhir, string nomor)
        {
            NamaAwal = NamaAwal;
            NamaAkhir = NamaAkhir;
            Nomor = Nomor;
        }
        public override String ToString()
        {
            
            String output = String.Empty;
            output += String.Format("{0}, {1}", namaAkhir, namaAwal);
            output += String.Format("({0})", nomor);

            return output;

        }

    }

        }

    

