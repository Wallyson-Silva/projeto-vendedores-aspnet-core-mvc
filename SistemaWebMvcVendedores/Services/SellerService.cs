﻿using SistemaWebMvcVendedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebMvcVendedores.Services
{
    public class SellerService
    {
        private readonly SistemaWebMvcVendedoresContext _context;

        public SellerService(SistemaWebMvcVendedoresContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
