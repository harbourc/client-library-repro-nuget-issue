﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace ClientLibrary
{
    public class Tester
    {
        public void TestOpenChrome()
        {
            var logger = new AdvancedLogger();
            logger.OpenChrome();
        }
        
    }
}
