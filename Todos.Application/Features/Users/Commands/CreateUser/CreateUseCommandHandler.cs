﻿using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Todos.Application.Contracts.Persistence;
using Todos.Domain.Entities;

namespace Todos.Application.Features.Users.Commands.CreateUser
{
    class CreateUseCommandHandler: IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUseCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);

            user = await _userRepository.Create(user);

            return user.Id;
        }
    }
}