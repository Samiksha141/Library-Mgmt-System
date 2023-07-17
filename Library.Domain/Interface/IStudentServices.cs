﻿using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Interface
{
    public interface IStudentServices
    {
        Task<bool> SignupStudent( EStudent eStudent);
    }
}
