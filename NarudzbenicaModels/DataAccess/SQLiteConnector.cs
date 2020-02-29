using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NarudzbenicaModels.Models;
using Dapper;
using System.Data;
using System.Linq;

namespace NarudzbenicaModels.DataAccess
{
    public class SQLiteConnector : IDataConnection
    {
        private const string db = "NarudzbenicaDatabase"; // ime baze


        public UsersModel CreateUser(UsersModel u)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Checking if database is empty
        /// </summary>
        /// <returns></returns>
        public bool DatabaseEmpty()
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                var number = 0;
                //string query1 = "select exists (select 1 from " + tabela + ");";
                string query = "select exists (select 1 from Korisnici);";
                number = connection.Query<int>(query).Single();
                if (number == 0)
                {
                    return true;
                }
                else return false;
            }
        }

        public DateTime DateOfFirstInsertInDatabase()
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderModel DatOfLastInsert(string y)
        {
            throw new NotImplementedException();
        }

        public void Delete(PurchaseOrderModel narudzbenica)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseOrderModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PurchaseOrderModel> GetAllForThisYear(string y)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseOrderModel> GetAllFromLastMonth(string m)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseOrderModel> GetAllOlderThen(int days)
        {
            throw new NotImplementedException();
        }

        public List<UsersModel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public List<PurchaseOrderModel> GetAllWhereIzvestajPoslat(int poslat, string y)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderModel GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderModel NapraviNarudzbenicu(PurchaseOrderModel narudzbenica)
        {
            throw new NotImplementedException();
        }

        public PositionModel NapraviPoziciju(PositionModel pozicija)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseOrederPositionModel> NarudbeniceSaPozicijam()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public int SumaIzvestajPosla(int i)
        {
            throw new NotImplementedException();
        }

        public int SumaKompletiranih()
        {
            throw new NotImplementedException();
        }

        public int UkupanBorjUNosaOvogMeseca(string mesec)
        {
            throw new NotImplementedException();
        }

        public int UkupanBrojUnosa()
        {
            throw new NotImplementedException();
        }

        public int UkupanBrojUnosaZaKorisnika(string korisnik)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderModel Update(PurchaseOrderModel narudzbenica)
        {
            throw new NotImplementedException();
        }
    }
}
