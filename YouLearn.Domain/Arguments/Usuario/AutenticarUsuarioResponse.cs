﻿using System;
using System.Collections.Generic;
using System.Text;
using YouLearn.Domain.Entities;

namespace YouLearn.Domain.Arguments.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entities.Usuario v)
        {
            return new AutenticarUsuarioResponse()
            {
                Id = v.Id,
                PrimeiroNome = v.Nome.PrimeiroNome
            };
        }
    }
}
