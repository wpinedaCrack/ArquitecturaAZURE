using AutoMapper;

namespace Tarker.Booking.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region User
            //CreateMap<UserEntity, CreateUserModel>().ReverseMap();
            //CreateMap<UserEntity, UpdateUserModel>().ReverseMap();
            //CreateMap<UserEntity, GetAllUserModel>().ReverseMap();
            //CreateMap<UserEntity, GetUserByIdModel>().ReverseMap();
            //CreateMap<UserEntity, GetUserByUserNameAndPasswordModel>().ReverseMap();
            //#endregion

            //#region Customer
            //CreateMap<CustomerEntity, CreateCustomerModel>().ReverseMap();
            //CreateMap<CustomerEntity, UpdateCustomerModel>().ReverseMap();
            //CreateMap<CustomerEntity, GetAllCustomerModel>().ReverseMap();
            //CreateMap<CustomerEntity, GetCustomerByIdModel>().ReverseMap();
            //CreateMap<CustomerEntity, GetCustomerByDocumentNumberModel>().ReverseMap();

            //#endregion

            //#region Booking
            //CreateMap<BookingEntity, CreateBookingModel>().ReverseMap();


            #endregion
        }
    }
}
