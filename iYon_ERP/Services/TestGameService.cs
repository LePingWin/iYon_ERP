﻿using iYon_ERP.Models;
using iYon_ERP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Services
{
    class TestGameService
    {
        private static TestGameRepository TestGameRepo = new TestGameRepository();
        public List<TestGame> TestGames { get { return TestGameRepo.GetAllItems(); } }

    }
}
