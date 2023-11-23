namespace Laboratorium_4.Models
{
    public interface IContactService
    {
        int Add(Contact contact);
        void Delete(int id);
        void Update(Contact contact);
        List<Contact> FindAll();
        Contact? FindById(int id);
        List<Contact> GetAllContacts();
        void RemoveById(int id);
        Contact? Find(int id);
    }
}
