
namespace Tarker.Booking.Application.External.AesEncryption
{
    public interface IAesEncryptionService
    {
        Task<byte[]> Encrypt(string content);
        Task<string> Dencrypt(byte[] content);
    }
}
