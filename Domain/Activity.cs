namespace Domain
{
    public class Activity //the class name (in our case Activity) relates to a table in a db and each one of the properties 
                        //relates to a column and an object relates to a row
    {
        public Guid Id { get; set; } // guids are designed for ids and thus you cannot find 2 same guids
        public string Title { get; set; } 
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}

