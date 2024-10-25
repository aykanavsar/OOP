using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_4._3_Kutuphane
{
    internal class kitap
    {
        public string _bookName;
        public string _artName;
        public string _artSurname;
        public string _pageCount;
        public string _publisher;
        public DateTime _recordDate;

        public string BookName
        {
            get
            {
                return _bookName;
            }

            set
            {
                _bookName = value;
            }

        }

        public string ArtName
        {
            get
            {
                return _artName;
            }

            set
            {
                _artName = value;
            }

        }

        public string ArtSurname
        {
            get
            {
                return _artSurname;
            }

            set
            {
                _artSurname = value;
            }

        }

        public string PageCount
        {
            get
            {
                return _pageCount;
            }

            set
            {
                _pageCount = value;
            }
        }

        public string Publisher
        {
            get
            {
                return _publisher;
            }

            set
            {
                _publisher = value;
            }
        }

        public kitap()
        {
            _bookName = "Girilmedi";
            _artName = "Girilmedi";
            _artSurname = "Girilmedi";
            _pageCount = "Girilmedi";
            _publisher = "Girilmedi";
            _recordDate = DateTime.Now; 


        }

        public kitap(string bookName, string artName, string artSurname, string pageCount, string publisher)
        {
            _bookName = bookName;
            _artName = artName;
            _artSurname=artSurname;
            _pageCount = pageCount; 
            _publisher = publisher; 
            _recordDate = DateTime.Now;
        }

        public void Info()
        {
            Console.WriteLine($"Kitap Adı : {_bookName}\nYazar Adı Soyadı  : {_artName} {_artSurname}\nSayfa Sayısı : {_pageCount}\nYayın Evi : {_publisher}\nKayıt Tarihi : {_recordDate}");
            Console.WriteLine(new String('_', 33));
        }


    }
}
