using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class LasReceta
{
    public int Id { get; set; }

    public byte[]? BlobData { get; set; }
}
