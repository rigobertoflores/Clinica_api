﻿using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class ExpedienteX
{
    public int Clave { get; set; }

    public byte[]? Expediente { get; set; }
}
