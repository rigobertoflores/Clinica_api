using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class LasFoto
{
    public int Id { get; set; }

    public byte[]? BlobData { get; set; }
}
