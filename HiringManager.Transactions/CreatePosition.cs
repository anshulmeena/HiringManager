﻿using System;
using HiringManager.Domain;
using HiringManager.DomainServices;

namespace HiringManager.Transactions
{
    public class CreatePosition : ITransaction<CreatePositionRequest, CreatePositionResponse>
    {
        private readonly IRepository _repository;
        private readonly IFluentMapper _fluentMapper;

        public CreatePosition(IRepository repository, IFluentMapper fluentMapper)
        {
            _repository = repository;
            _fluentMapper = fluentMapper;
        }

        public CreatePositionResponse Execute(CreatePositionRequest request)
        {
            var position = _fluentMapper
                .Map<Position>()
                .From(request)
                ;

            _repository.Store(position);

            _repository.Commit();

            return new CreatePositionResponse()
                   {
                       PositionId = position.PositionId,
                   };
        }
    }
}