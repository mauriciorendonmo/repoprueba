﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.Identity;

namespace PartsUnlimited.Models
{

// cambio desarrollo local
// cambio servidor

    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
