using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ze_Starve.Penerima_Bantuan
{
    class GetSetPenerima
    {
        // Menginisialisasi Variable Penerima Bantuan
        private string _username, NoHP, AddressPenerima, _email, _password;

        // Membuat Data Penerima Bantuan Baru
        public GetSetPenerima(string _username, string NoHP, string AddressPenerima, string _email, string _password)
        {
            this._username = _username;
            this.NoHP = NoHP;
            this.AddressPenerima = AddressPenerima;
            this._email = _email;
            this._password = _password;
        }

        // Mendapatkan data username
        public String getUsername()
        {
            return _username;
        }
        // Menyimpan data username
        public void setUsername(String username)
        {
            this._username = username;
        }

        // Mendapatkan data Nomor HP
        public String getNoHP()
        {
            return NoHP;
        }
        // Menyimpan data Nomor HP
        public void setNoHP(String NoHP)
        {
            this.NoHP = NoHP;
        }

        // Mendapatkan data Address Pengguna
        public String getAddressPenerima()
        {
            return AddressPenerima;
        }
        // Menyimpan data Nomor Address Pengguna
        public void setAddressPenerima(String AddressPPenerima)
        {
            this.AddressPenerima = AddressPenerima;
        }

        // Mendapatkan data Email
        public String getEmail()
        {
            return _email;
        }
        // Menyimpan data Email
        public void setEmail(String email)
        {
            this._email = email;
        }

        // Mendapatkan data Password
        public String getPassword()
        {
            return _password;
        }
        // Menyimpan data Password
        public void setPassword(String password)
        {
            this._password = password;
        }



    }
}
