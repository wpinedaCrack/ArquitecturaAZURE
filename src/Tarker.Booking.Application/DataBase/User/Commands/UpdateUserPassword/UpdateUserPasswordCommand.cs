using Microsoft.EntityFrameworkCore;

namespace Tarker.Booking.Application.DataBase.User.Commands.UpdateUserPassword
{
    public class UpdateUserPasswordCommand: IUpdateUserPasswordCommand
    {
        private readonly IDataBaseService _databaseService;
        public UpdateUserPasswordCommand(IDataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<bool> Execute(UpdateUserPasswordModel model)
        {
            var entity = await _databaseService.Users
                .FirstOrDefaultAsync(x=> x.UserId == model.UserId);

            if (entity == null)
                return false;

            entity.Password = model.Password;
            return await _databaseService.SaveAsync();
        }
    }
}
