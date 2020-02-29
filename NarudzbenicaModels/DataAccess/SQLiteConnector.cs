using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NarudzbenicaModels.Models;
using Dapper;
using System.Data;
using System.Windows.Forms;
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
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                //tring query = @"Insert into Racun (Datum, VisaTarifa, NizaTarifa, Ukupno, Info, Cena, CenaSaRacuna ) values (@Datum , @VisaTarifa, @NizaTarifa , @Ukupno , @Info, @Cena, @CenaSaRacuna);select max(ID) from Racun";
                string query = @"Insert into [Narudzbenice] (Id, BrojNarudzbenice, DatumNarudzbenice, DatumIstekaRokaNarudzbenice, OkvirniSporazum, Ogranak, NazivTrafostanice, DatumFakture, BrojFakture, IznosBezPDV, DatumPrijemEPS, BrojIzvestaja, Napomena, IzvestajPoslat, NarudzbenicaPDF, ZapsinikOIzvrsenjuUslugaPDF, FakturaPDF, PrimopredajniObrazacPDF, Korisnik, Datum  ) values (null,@BrojNarudzbenice,@DatumNarudzbenice,@DatumIstekaRokaNarudzbenice,@OkvirniSporazum,@Ogranak,@NazivTrafostanice,@DatumFakture,@BrojFakture,@IznosBezPDV,@DatumPrijemEPS,@BrojIzvestaja,@Napomena,@IzvestajPoslat,@NarudzbenicaPDF,@ZapsinikOIzvrsenjuUslugaPDF,@FakturaPDF,@PrimopredajniObrazacPDF,@Korisnik,@Datum);select max(Id) from Narudzbenice";

                //int id = connection.Query<int>(query, narudzbenica, commandType: CommandType.Text).Single();
                //const string sql = @"INSERT INTO [Course] (Name, StudentLimit) VALUES (@Name, @StudentLimit)";
                try
                {
                    //connection.Execute(query, narudzbenica, commandType: CommandType.Text);
                    int id = connection.Query<int>(query, narudzbenica).Single();
                    //long id = connection.Query<long>(query, racun).First();
                    narudzbenica.ID = id;
                    return narudzbenica;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Doslo je do greske, detaljne informaciju su: " + ex, "Greska sa bazom!", MessageBoxButtons.OK, MessageBoxIcon.Error); // TODO : Pocisti ovo
                    return null;
                }
                //long id = connection.Query<long>(query, racun).First();
                //narudzbenica.ID = id;
            }
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
