﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema83_SolidPrinciples_Examples.Interface_Segregation_Principle._5
{
    public interface ICommentable
    {
        List<string> Comments { get; }
        void AddComment(string comment);
        void RemoveComment(string comment);
    }
}
