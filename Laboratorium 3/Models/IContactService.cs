namespace Laboratorium_3.Models
{
    public interface IContactService
    {
        void Add(Contact contact);
        void RemoveById(int id);
        void Update(Contact contact);
        List<Contact> FindAll();
        Contact? Find(int id);
    }
}
