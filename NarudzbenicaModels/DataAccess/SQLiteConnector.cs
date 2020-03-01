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
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                //tring query = @"Insert into Racun (Datum, VisaTarifa, NizaTarifa, Ukupno, Info, Cena, CenaSaRacuna ) values (@Datum , @VisaTarifa, @NizaTarifa , @Ukupno , @Info, @Cena, @CenaSaRacuna);select max(ID) from Racun";
                string query = @"Insert into [Korisnici](ID, KorisnickoIme, KorisnickaLozinka, Privilegija, Datum) values  (null, @KorisnickoIme, @KorisnickaLozinka, @Privilegija, @Datum);";

                //int id = connection.Query<int>(query, narudzbenica, commandType: CommandType.Text).Single();
                //const string sql = @"INSERT INTO [Course] (Name, StudentLimit) VALUES (@Name, @StudentLimit)";
                connection.Execute(query, u, commandType: CommandType.Text);
                //long id = connection.Query<long>(query, racun).First();
                //narudzbenica.ID = id;
                return u;
            }
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
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "select * from Narudzbenice";
                try
                {
                    return (List<PurchaseOrderModel>)connection.Query<PurchaseOrderModel>(query);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Doslo je do greske, detaljne informaciju su: " + ex, "Greska sa bazom!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public List<PurchaseOrderModel> GetAllForThisYear(string y)
        {
            using(IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "SELECT * FROM Narudzbenice WHERE strftime('%Y', Datum) = '" + DateTime.Now.Year.ToString() + "'";
                return (List<PurchaseOrderModel>)connection.Query<PurchaseOrderModel>(query);
            }
        }

        public List<PurchaseOrderModel> GetAllFromLastMonth(string m)
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                //string query = "select * from Narudzbenice where Datum like '" + mesec + "-%-% %'";
                //string query = "SELECT * FROM Narudzbenice WHERE strftime('%m', Datum) = '" + mesec + "'";
                string query = "SELECT * FROM Narudzbenice WHERE strftime('%Y %m', Datum) = '" + DateTime.Now.Year.ToString() + " " + mesec + "'";
                try
                {
                    return (List<PurchaseOrderModel>)connection.Query<PurchaseOrderModel>(query);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Doslo je do greske, detaljne informaciju su: " + ex, "Greska sa bazom!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public List<PurchaseOrderModel> GetAllOlderThen(int days)
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "SELECT * FROM Narudzbenice WHERE(julianday('now') - julianday(DatumNarudzbenice)) <= " + days + "; ";
                return (List<PurchaseOrderModel>)connection.Query<PurchaseOrderModel>(query);
            }
        }

        public List<UsersModel> GetAllUsers()
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "select * from Korisnici";
                try
                {
                    return (List<UsersModel>)connection.Query<UsersModel>(query);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Doslo je do greske, detaljne informaciju su: " + ex, "Greska sa bazom!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public List<PurchaseOrderModel> GetAllWhereIzvestajPoslat(int poslat, string y)
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "SELECT * FROM Narudzbenice where IzvestajPoslat = " + poslat + " AND strftime('%Y', Datum) = '" + y + "';";
                return (List<PurchaseOrderModel>)connection.Query<PurchaseOrderModel>(query);
            }
        }

        public PurchaseOrderModel GetOne(int id)
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "select * from Narudzbenice where Id = @ID";
                return connection.QuerySingle<PurchaseOrderModel>(query, new { Id = id });
            }
        }

        public PurchaseOrderModel NapraviNarudzbenicu(PurchaseOrderModel narudzbenica)
        {
            // TODO : preimenuj imena promenljivih u upitu za bazu i promeni ih i u bazi posto si modele pisao na engleskom
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
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "delete from Korisnici where ID = @ID";
                int i = connection.Execute(query, new { id = id });
            }
        }

        /// <summary>
        /// Parametar nam sluzi da bi birali izmedju poslatih i neposlatih izvestaja
        /// </summary>
        /// <param name="i"> 0 ili 1 </param>
        /// <returns></returns>
        public int SumaIzvestajPosla(int i)
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "select count() from Narudzbenice where IzvestajPoslat = " + i + ";";
                //return connection.QuerySingle<int>(query, new { ID = id });
                return connection.ExecuteScalar<int>(query);
            }
        }

        public int SumaKompletiranih()
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = @"select count() From Narudzbenice where
                               Id !="""" 
                               AND BrojNarudzbenice !="""" 
                               AND DatumNarudzbenice !="""" 
                               AND DatumIstekaRokaNarudzbenice !="""" 
                               AND OkvirniSporazum !="""" 
                               AND Ogranak !="""" 
                               AND NazivTrafostanice !="""" 
                               AND DatumFakture !="""" 
                               AND BrojFakture !="""" 
                               AND IznosBezPDV !="""" 
                               AND DatumPrijemEPS !="""" 
                               AND BrojIzvestaja !="""" 
                               AND IzvestajPoslat = 1 
                               AND NarudzbenicaPDF !=""""
                               AND ZapsinikOIzvrsenjuUslugaPDF !="""" 
                               AND FakturaPDF !="""" 
                               AND PrimopredajniObrazacPDF !="""" 
                               AND Korisnik !="""" 
                               AND Datum != """";";
                //return connection.QuerySingle<int>(query, new { ID = id });
                return connection.ExecuteScalar<int>(query);
            }
        }

        public int UkupanBorjUNosaOvogMeseca(string mesec)
        {
            throw new NotImplementedException();
        }

        public int UkupanBrojUnosa()
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "select count() from Narudzbenice";
                //return connection.QuerySingle<int>(query, new { ID = id });
                return connection.ExecuteScalar<int>(query);
            }
        }

        public int UkupanBrojUnosaZaKorisnika(string korisnik)
        {
            using (IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = "select count() from Narudzbenice where Korisnik = '" + korisnik + "';";
                //return connection.QuerySingle<int>(query, new { ID = id });
                return connection.ExecuteScalar<int>(query);
            }
        }

        public PurchaseOrderModel Update(PurchaseOrderModel narudzbenica)
        {
            using(IDbConnection connection = new System.Data.SQLite.SQLiteConnection(GlobalConfig.CnnString()))
            {
                string query = @"UPDATE Narudzbenice SET BrojNarudzbenice = @BrojNarudzbenice,DatumNarudzbenice = @DatumNarudzbenice,DatumIstekaRokaNarudzbenice = @DatumIstekaRokaNarudzbenice,OkvirniSporazum = @OkvirniSporazum,Ogranak = @Ogranak,NazivTrafostanice = @NazivTrafostanice,DatumFakture = @DatumFakture,BrojFakture = @BrojFakture,IznosBezPDV = @IznosBezPDV,DatumPrijemEPS = @DatumPrijemEPS,BrojIzvestaja = @BrojIzvestaja,Napomena = @Napomena,IzvestajPoslat = @IzvestajPoslat,NarudzbenicaPDF = @NarudzbenicaPDF,ZapsinikOIzvrsenjuUslugaPDF = @ZapsinikOIzvrsenjuUslugaPDF,FakturaPDF = @FakturaPDF,PrimopredajniObrazacPDF = @PrimopredajniObrazacPDF,Korisnik = @Korisnik WHERE Id = @ID;";
                //cnn.Execute("update Table set val = @val where Id = @id", new { val, id = 1 });
                //string query = "update Racun set @Datum = '" + DateTimeSQLite(racun.Datum) + "', @VisaTarifa = '" + racun.VisaTarifa + "', @NizaTarifa = '" + racun.NizaTarifa + "', @Ukupno = '" + racun.Ukupno + "', @Info = '" + racun.Info + "', @Cena = '" + racun.Cena + "', @CenaSaRacuna = '" + racun.CenaSaRacuna + "' where ID = @ID;";
                var i = connection.Execute(query, narudzbenica);
                narudzbenica.ID = i;
                return narudzbenica;
            }
        }
    }
}
