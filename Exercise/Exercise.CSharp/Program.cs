
using System.Linq.Expressions;
using Exercise.CSharp.StructAndClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

ExecuteMyStractAndClass s = new ExecuteMyStractAndClass();

s.ExecuteStruct();
s.ExecuteClass();

//
//
// new List<int>().Where(a =>
//
//     new DbSet().Where()
//
//
// Expression<Func<int, int, int>> expr;
// Func<int, int, int> f;
// f()