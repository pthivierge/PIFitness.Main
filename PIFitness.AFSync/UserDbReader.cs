﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PIFitness.Domain;
using PIFitness.Domain.Interfaces;

namespace PIFitness.AFSync
{
    public class UserDbReader : ITableReader<UserEntry>
    {
        private UserRepository _userRepository;

        private ITableFilter<UserEntry> _filter;

        public UserDbReader(UserRepository gpxRepository, ITableFilter<UserEntry> filter)
        {
            _userRepository = gpxRepository;
            _filter = filter;
        }

        public IQueryable<UserEntry> Read()
        {
            IQueryable<UserEntry> gpxTable = _userRepository.UserTable;

            gpxTable = _filter.FilterTable(gpxTable);

            return gpxTable;
        }


    }
}
