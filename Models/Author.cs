namespace Crisan_Melisa_lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // Proprietate pentru afișarea completă a numelui
        public string FullName => $"{FirstName} {LastName}";

        // Proprietate de navigare către cărți 
        public ICollection<Book> Books { get; set; }
        
    }
}
