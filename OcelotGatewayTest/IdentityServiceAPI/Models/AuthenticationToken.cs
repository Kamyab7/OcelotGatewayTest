﻿namespace IdentityServiceAPI.Models;

public record AuthenticationToken(string Token, int ExpiresIn);
