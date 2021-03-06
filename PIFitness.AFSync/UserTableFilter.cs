﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIFitness.Entities;
using PIFitness.Common.Interfaces;

namespace PIFitness.UserSync
{
    public class UserTableFilter : ITableFilter<UserEntry>
    {

        public IQueryable<UserEntry> FilterTable(IQueryable<UserEntry> table)
        {
            var filteredTable = from user in table
                                select user;

            return filteredTable;
        }



    }
}
