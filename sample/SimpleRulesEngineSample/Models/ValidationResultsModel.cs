﻿using System.Collections.Generic;

namespace SimpleRulesEngineSample.Models
{
    public class ValidationResultsModel
    {
        public IEnumerable<string> UserValidationResults { get; set; }
        public IEnumerable<string> RegistrationValidationResults { get; set; }
        public IEnumerable<string> ActivityValidationResults { get; set; }
    }
}