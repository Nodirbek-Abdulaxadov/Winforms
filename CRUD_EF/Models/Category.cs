﻿using System;
using System.Collections.Generic;

namespace CRUD_EF.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
