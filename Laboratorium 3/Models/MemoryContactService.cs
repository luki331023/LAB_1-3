namespace Laboratorium_3.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _items = new Dictionary<int, Contact>()
        {
            {
                1, new Contact() { id = 1, Name = "Adam", Email = "adam@example.com", Phone = "111222333", Birth = new DateTime(1995, 5, 15) }
            },
            {
                2, new Contact() { id = 2, Name = "Ewa", Email = "ewa@example.com", Phone = "444555666", Birth = new DateTime(1990, 7, 20) }
            },
            {
                3, new Contact() { id = 3, Name = "Jan", Email = "jan@example.com", Phone = "777888999", Birth = new DateTime(1985, 3, 10) }
            },
            {
                4, new Contact() { id = 4, Name = "Anna", Email = "anna@example.com", Phone = "123456789", Birth = new DateTime(1998, 9, 25) }
            },
            {
                5, new Contact() { id = 5, Name = "Piotr", Email = "piotr@example.com", Phone = "987654321", Birth = new DateTime(1982, 11, 8) }
            },
            {
                6, new Contact() { id = 6, Name = "Karolina", Email = "karolina@example.com", Phone = "555444333", Birth = new DateTime(1993, 1, 30) }
            },
            {
                7, new Contact() { id = 7, Name = "Mateusz", Email = "mateusz@example.com", Phone = "111999888", Birth = new DateTime(1980, 6, 5) }
            },
            {
                8, new Contact() { id = 8, Name = "Natalia", Email = "natalia@example.com", Phone = "333222111", Birth = new DateTime(1996, 4, 18) }
            },
            {
                9, new Contact() { id = 9, Name = "Krzysztof", Email = "krzysztof@example.com", Phone = "666777888", Birth = new DateTime(1987, 8, 12) }
            },
            {
                10, new Contact() { id = 10, Name = "Monika", Email = "monika@example.com", Phone = "999888777", Birth = new DateTime(1992, 12, 3) }
            }
        };
        private int id = 3;

        public void Add(Contact contact)
        {
            contact.id = id++;
            _items[contact.id] = contact;
        }

        public Contact? Find(int id)
        {
            return _items[id];

        }

        public List<Contact> FindAll()
        {
            return _items.Values.ToList();
        }

        public void RemoveById(int id)
        {
            _items.Remove(id);
        }

        public void Update(Contact contact)
        {
            _items[contact.id] = contact;
        }
    }
}
