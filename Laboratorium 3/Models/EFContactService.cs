namespace Laboratorium_3.Models
{
    public class EFContactService:IContactService
    {
        private AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact contact)
        {
            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            var entity = _context.Contacts.Find(id);
            if (entity != null)
            {
                _context.Contacts.Remove(entity);
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList(); ;
        }

        public Contact? Find(int id)
        {
            return ContactMapper.FromEntity(_context.Contacts.Find(id));
        }

        public void Update(Contact contact)
        {
            _context.Contacts.Update(ContactMapper.ToEntity(contact));
        }
    }
}
