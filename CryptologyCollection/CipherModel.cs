using CryptologyCollection.Contracts;

namespace CryptologyCollection
{
    internal class CipherModel
    {
        public int Id { get; }
        public string Title { get; }
        public ICipher CipherObject { get; }

        public CipherModel(int id, string title, ICipher cipherObject)
        {
            Id = id;
            Title = title;
            CipherObject = cipherObject;
        }
    }
}
