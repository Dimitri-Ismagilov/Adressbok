namespace Adressbok.Classes
{
    public class Filehandler
    {
        //Instanciering 
        private List<Person> people = new List<Person>();

        //Tilldelar värdet till variabel på vårt datakälla.
        private string _filePath = @"C:\Inlämninguppgifter\Adressbok.txt";
        public List<Person> People => people;


        //Metoden som lägger till personen i listan.
        public void AddPerson(Person person)
        {
            people.Add(person);
            SavePeople();
        }
        //Metoden som uppdaterar personen i listan.
        public void UpdatePerson(int index, Person newPerson)
        {
            if (index >= 0 && index < people.Count)
            {
                people[index] = newPerson;
                SavePeople();
            }
        }
        //Metoden som raderar personer från listan.
        public void DeletePerson(int index)
        {
            if (index >= 0 && index < people.Count)
            {
                people.RemoveAt(index);
                SavePeople();
            }
        }
        //Metoden som sparar personen till textfilen i en viss ordning.
        public void SavePeople()
        {
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                foreach (var person in people)
                {
                    writer.WriteLine($"{person.Name},{person.Address},{person.PostalCode},{person.City},{person.Email},{person.Phone}");
                }
            }
        }
        //Metoden som laddar upp personer från textfilen i en viss ordning.
        public void LoadPeople()
        {
            if (File.Exists(_filePath))
            {
                using StreamReader reader = new StreamReader(_filePath);
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            var person = new Person
                            {
                                Name = parts[0],
                                Address = parts[1],
                                PostalCode = parts[2],
                                City = parts[3],
                                Email = parts[4],
                                Phone = parts[5]
                            };
                            people.Add(person);
                        }
                    }
                }
            }
        }       
    }
}
