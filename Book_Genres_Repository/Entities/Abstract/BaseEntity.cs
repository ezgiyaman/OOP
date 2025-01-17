﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Genres_Repository.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate= value ; }
    }
}
