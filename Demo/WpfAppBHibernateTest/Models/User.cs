﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBHibernateTest.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string UserPwd { get; set; }
        public virtual DateTime UserRegisterTime { get; set; }
    }
}
