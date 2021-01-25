﻿using System.Collections.Generic;

namespace SistemaERP.Infra.CrossCutting.Identity.ViewModels
{
    public class UserTokenViewModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public IEnumerable<ClaimViewModel> Claims { get; set; }
    }
}
