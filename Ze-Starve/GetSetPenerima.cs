using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fauzan Reza Arnanda
//1302194003

namespace Ze_Starve
{
    class GetSetPenerima<T>
    {
        // Menginisialisasi Variable Penerima Bantuan
        private T _username, NoHP, AddressPenerima, _email, _password;

        // Membuat Data Penerima Bantuan Baru
        public GetSetPenerima(T _username, T NoHP, T AddressPenerima, T _email, T _password)
        {
            this._username = _username;
            this.NoHP = NoHP;
            this.AddressPenerima = AddressPenerima;
            this._email = _email;
            this._password = _password;
        }

        // Mendapatkan data username
        public T getUsername()
        {
            return _username;
        }
        // Menyimpan data username
        public void setUsername(T username)
        {
            this._username = username;
        }

        // Mendapatkan data Nomor HP
        public T getNoHP()
        {
            return NoHP;
        }
        // Menyimpan data Nomor HP
        public void setNoHP(T NoHP)
        {
            this.NoHP = NoHP;
        }

        // Mendapatkan data Address Pengguna
        public T getAddressPenerima()
        {
            return AddressPenerima;
        }
        // Menyimpan data Nomor Address Pengguna
        public void setAddressPenerima(T AddressPPenerima)
        {
            this.AddressPenerima = AddressPenerima;
        }

        // Mendapatkan data Email
        public T getEmail()
        {
            return _email;
        }
        // Menyimpan data Email
        public void setEmail(T email)
        {
            this._email = email;
        }

        // Mendapatkan data Password
        public T getPassword()
        {
            return _password;
        }
        // Menyimpan data Password
        public void setPassword(T password)
        {
            this._password = password;
        }


    }
}

