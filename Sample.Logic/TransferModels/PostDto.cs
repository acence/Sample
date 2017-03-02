namespace Sample.Logic.TransferModels
{
    using Base;
    using System;

    public class PostDto: BaseDto
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
    }
}
