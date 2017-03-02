namespace Sample.Database.Models
{
    using System;
    using Base;

    public class Post : BaseModel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }

		public String Slug { get; set; }
    }
}
