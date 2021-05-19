using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Todos.Application.Contracts.Persistence.Common;
using Todos.Domain.Entities;

namespace Todos.Application.Features.Users.Queries.GetAllUsers
{
    class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserListVm>>
    {
        private readonly BaseRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(BaseRepository<User> userRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }
        public async Task<List<UserListVm>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var allUsers = (await _userRepository.GetAll()).OrderBy(x => x.UserName);
            return _mapper.Map<List<UserListVm>>(allUsers);
        }
    }
}
