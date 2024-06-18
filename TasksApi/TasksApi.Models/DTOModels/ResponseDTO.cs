﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApi.Models.DTOModels
{
    public class ResponseDTO<T>
    {
        public bool success { get; set; }
        public string? errorMessage { get; set; }
        public T? data { get; set; }
        public ResponseDTO() { }
    }
}
