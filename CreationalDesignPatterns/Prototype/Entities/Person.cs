namespace Prototype.Entities
{
    internal class Person : PersonPrototype
    {
        public Person() { }

        public string? Name { get; set; }
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public IdInfo? IdInfo { get; set; }

        public override PersonPrototype ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public override PersonPrototype DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();
            clone.IdInfo = new IdInfo(this.IdInfo?.IdNumber);
            clone.Name = new string(this.Name);

            return clone;
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Age} years old, Born on {this.BirthDate.Value:dd-MM-yyyy}, ID#: {this.IdInfo?.IdNumber}";
        }
    }
}
