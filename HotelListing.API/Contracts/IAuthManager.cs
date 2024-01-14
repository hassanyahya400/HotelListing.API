﻿using System;
using HotelListing.API.Models.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Contracts
{
	public interface IAuthManager
	{
        Task<AuthResponseDto> Login(LoginDto loginDto);
		Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<IEnumerable<IdentityError>> RegisterAdmin(ApiUserDto userDto);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);

    }
}

