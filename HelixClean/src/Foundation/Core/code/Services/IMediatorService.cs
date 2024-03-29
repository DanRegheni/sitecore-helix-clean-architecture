﻿using System.ComponentModel.DataAnnotations;
using Helixclean.Foundation.Core.Models;

namespace Helixclean.Foundation.Core.Services
{
    public interface IMediatorService
    {
        MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel = default(T),
            ValidationResult validationResult = null, object parameters = null, string message = null);
    }
}
