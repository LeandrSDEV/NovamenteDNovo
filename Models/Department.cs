﻿namespace NovamenteDenovo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; }

        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller seller) 
        {
            Sellers.Add(seller);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(o => o.totalSales(initial, final));
        }
    }
}
