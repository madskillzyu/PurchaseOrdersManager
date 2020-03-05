using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NarudzbenicaModels.Models;

namespace NarudzbenicaModels.DataAccess
{
    public interface IDataConnection
    {
        bool DatabaseEmpty();
        // TODO - dodaj i ostale metode? trebalo bi za sqlite i za text fajlove
        PurchaseOrderModel NapraviNarudzbenicu(PurchaseOrderModel narudzbenica);
        PositionModel NapraviPoziciju(PositionModel pozicija);
        List<PurchaseOrderModel> GetAllFromLastMonth(string m);


       // List<PurchaseOrederPositionModel> NarudbeniceSaPozicijam();

        List<PurchaseOrderModel> GetAllOlderThen(int days);
        List<PurchaseOrderModel> GetAllForThisYear(string y);
        List<PurchaseOrderModel> GetAllWhereIzvestajPoslat(int poslat, string y);
        List<PurchaseOrderModel> GetAll();
        PurchaseOrderModel GetOne(int id);
        PurchaseOrderModel Update(PurchaseOrderModel narudzbenica);
        void Delete(PurchaseOrderModel narudzbenica);
        int SumaIzvestajPosla(int i);
        int SumaKompletiranih();
        int UkupanBrojUnosa();
        int UkupanBrojUnosaZaKorisnika(string korisnik);
        int UkupanBorjUNosaOvogMeseca(string mesec);

        DateTime DateOfFirstInsertInDatabase();

        PurchaseOrderModel DatOfLastInsert(string y);

        UsersModel CreateUser(UsersModel u);
        List<UsersModel> GetAllUsers();
        void RemoveUser(int id);




        //RacunModel GetLastRecordForThisYear(string y);
        //InicialisationModel Inicialisation(InicialisationModel inicialisation);
        //System.Collections.Generic.List<RacunModel> GetAll();


        //*******************************************INICIALISATION*****************************
        //InicialisationModel Inicialisation_GetLast();
        //List<RacunModel> GetAllForThisYear(string y);
    }
}
