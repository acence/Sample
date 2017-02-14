namespace Sample.Logic
{
    using AutoMapper;
    using Base;
    using Database.Models;
    using Database.Repositories.Interfaces;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using TransferModels;

    public class ExampleFirstLogic : BaseLogic<IExampleFirstRepository, ExampleFirst, ExampleFirstDto>, IExampleFirstLogic
    {
        public ExampleFirstLogic(IExampleFirstRepository db, IMapper mapper)
            : base(db, mapper)
        {
        }
    }
}
