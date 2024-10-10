

using Encuba.Ejemplo.Domain.Interfaces.Cryptography;

namespace Encuba.Ejemplo.Infrastructure.Cryptography;

public class BCryptCryptographyHelper : IBCryptCryptographyHelper
{
    public string HashWithBcrypt(string valueToHash, int workFactor)
    {
        return BCrypt.Net.BCrypt.HashPassword(valueToHash, workFactor);
    }

    public bool VerifyBcryptHash(string valueToCompare, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(valueToCompare, hash);
    }
}