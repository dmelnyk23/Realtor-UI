using DAL.ServiceReference1;
using DALUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MethodsUI
    {
        MethodsClient _WCF = new MethodsClient();
        public void AddUser(UserUI userUI)
        {
            User user = new User()
            {
                ID = userUI.ID,
                Favourite = userUI.Favourite.ToArray(),
                IsAdmin = userUI.IsAdmin,
                Login = userUI.Login,
                Name = userUI.Name,
                Password = userUI.Password,
                PhoneNumber = userUI.PhoneNumber
            };
            _WCF.AddUser(user);
        }

        public void ModifyUser(UserUI userUI)
        {
            User user = new User()
            {
                ID = userUI.ID,
                Favourite = userUI.Favourite.ToArray(),
                IsAdmin = userUI.IsAdmin,
                Login = userUI.Login,
                Name = userUI.Name,
                Password = userUI.Password,
                PhoneNumber = userUI.PhoneNumber
            };
            _WCF.ModifyUser(user);
        }

        public void DeleteUser(UserUI userUI)
        {
            User user = new User()
            {
                ID = userUI.ID,
                Favourite = userUI.Favourite.ToArray(),
                IsAdmin = userUI.IsAdmin,
                Login = userUI.Login,
                Name = userUI.Name,
                Password = userUI.Password,
                PhoneNumber = userUI.PhoneNumber
            };
            _WCF.DeleteUser(user);
        }

        public List<UserUI> GetUsers()
        {
            var WCFUsers = _WCF.GetUsers();
            List<UserUI> usersUI = new List<UserUI>();
            foreach (var item in WCFUsers)
            {
                UserUI userUI = new UserUI()
                {
                    ID = item.ID,
                    Favourite = item.Favourite.ToList(),
                    IsAdmin = item.IsAdmin,
                    Login = item.Login,
                    Name = item.Name,
                    Password = item.Password,
                    PhoneNumber = item.PhoneNumber,
                    Lots = ConvertToLotUI(item.Lots)
                };
                usersUI.Add(userUI);
            }
            return usersUI;
        }

        public ICollection<LotUI> ConvertToLotUI(ICollection<Lot> lot)
        {
            List<LotUI> lotsUI = new List<LotUI>();
            foreach (var item in lot)
            {
                LotUI lotUI = new LotUI
                {
                    ID = item.ID,
                    Apartment = item.Apartment,
                    IsForSale=item.IsForSale,
                    Description = item.Description,
                    Flour = item.Flour,
                    House = item.House,
                    IsReserved = item.IsReserved,
                    IsSold = item.IsSold,
                    Price = item.Price,
                    RoomsCount = item.RoomsCount,
                    Square = item.Square,
                    Address = ConvertToAddressUI(item.Address),
                    Photos = ConvertToPhotoUI(item.Photos)
                };
                lotsUI.Add(lotUI);
            }
            return lotsUI;
        }

        public AddressUI ConvertToAddressUI(Address address)
        {
            return new AddressUI
            {
                ID = address.ID,
                City = address.City,
                Country = address.Country,
                Street = address.Street
            };
        }

        public User ConvertToUserWCF(UserUI userUI)
        {
            return new User
            {
                ID = userUI.ID,
                Favourite = userUI.Favourite.ToArray(),
                IsAdmin = userUI.IsAdmin,
                Login = userUI.Login,
                Name = userUI.Name,
                Password = userUI.Password,
                PhoneNumber = userUI.PhoneNumber
            };
        }

        public ICollection<PhotoUI> ConvertToPhotoUI(ICollection<Photo> photo)
        {
            List<PhotoUI> photosUI = new List<PhotoUI>();
            foreach (var item in photo)
            {
                PhotoUI photoUI = new PhotoUI()
                {
                    ID = item.ID,
                    Path = item.Path
                };
                photosUI.Add(photoUI);
            }
            return photosUI;
        }

        public LotUI[] GetLots()
        {
            return ConvertToLotUI(_WCF.GetLots()).ToArray();
        }

        public void ReserveLot(int id)
        {
            _WCF.ReserveLot(id);
        }

        public void AddLot(LotUI lotUI)
        {
            Lot lot = new Lot()
            {
                Address = ConvertToAddressWCF(lotUI.Address),
                Photos = ConvertToPhotoWCF(lotUI.Photos).ToArray(),
                Apartment = lotUI.Apartment,
                IsForSale = lotUI.IsForSale,
                Description = lotUI.Description,
                Flour = lotUI.Flour,
                House = lotUI.House,
                IsReserved = lotUI.IsReserved,
                IsSold = lotUI.IsSold,
                Price = lotUI.Price,
                RoomsCount = lotUI.RoomsCount,
                Square = lotUI.Square,
                User = ConvertToUserWCF(lotUI.User)
            };
            _WCF.AddLot(lot);
        }

        public void LotEdit(LotUI lotUI)
        {
            Lot lot = new Lot()
            {
                Address = ConvertToAddressWCF(lotUI.Address),
                Photos = ConvertToPhotoWCF(lotUI.Photos).ToArray(),
                IsForSale = lotUI.IsForSale,
                Apartment = lotUI.Apartment,
                Description = lotUI.Description,
                Flour = lotUI.Flour,
                House = lotUI.House,
                IsReserved = lotUI.IsReserved,
                IsSold = lotUI.IsSold,
                Price = lotUI.Price,
                RoomsCount = lotUI.RoomsCount,
                Square = lotUI.Square,
                User = ConvertToUserWCF(lotUI.User)
            };
            _WCF.LotEdit(lot);
        }

        public void DeleteLot(int id)
        {
            _WCF.DeleteLot(id);
        }

        public Lot ConvertToWCFLot(LotUI lotUI)
        {
            Lot lot = new Lot()
            {
                ID = lotUI.ID,
                Apartment = lotUI.Apartment,
                Description = lotUI.Description,
                Flour = lotUI.Flour,
                IsForSale = lotUI.IsForSale,
                House = lotUI.House,
                IsReserved = lotUI.IsReserved,
                IsSold = lotUI.IsSold,
                Price = lotUI.Price,
                RoomsCount = lotUI.RoomsCount,
                Square = lotUI.Square,
                Address = ConvertToAddressWCF(lotUI.Address),
                Photos = ConvertToPhotoWCF(lotUI.Photos).ToArray()
            };
            return lot;
        }

        public Address ConvertToAddressWCF(AddressUI addressUI)
        {
            Address address = new Address()
            {
                City = addressUI.City,
                Country = addressUI.Country,
                ID = addressUI.ID,
                Street = addressUI.Street
            };
            return address;
        }

        public List<Photo> ConvertToPhotoWCF(ICollection<PhotoUI> photosUI)
        {
            List<Photo> photos = new List<Photo>();
            foreach (var item in photosUI)
            {
                Photo photo = new Photo()
                {
                    ID = item.ID,
                    Path = item.Path
                };
                photos.Add(photo);
            }
            return photos;
        }
    }
}
