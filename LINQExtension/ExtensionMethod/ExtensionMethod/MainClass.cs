using System;
using ExtensionMethod.ExtensionOperatorClasses;

namespace ExtensionMethod
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Select selectMethod = new Select();
            selectMethod.SelectMethod();

            SelectMany selectManyOperator = new SelectMany();
            selectManyOperator.SelectManyMethod();

            Where whereOperator = new Where();
            whereOperator.WhereMethod();

            OfType ofType = new OfType();
            ofType.OfTypeMethod();

            OrderBy orderBy = new OrderBy();    
            orderBy.OrderByMethod();

            OrderByDesending orderByDesending = new OrderByDesending();
            orderByDesending.OrderByDesendingMethod();

            ThenBy thenBy = new ThenBy();
            thenBy.ThenByMethod();

            ThenByDescending thenByDescending = new ThenByDescending();
            thenByDescending.ThenByDescendingMethod();

            GroupBy groupBy = new GroupBy();
            groupBy.GroupByMethod();

            ToLookup toLookup = new ToLookup();
            toLookup.ToLookupMethod();

            Join join = new Join(); 
            join.JoinMethod();

            GroupJoin groupJoin = new GroupJoin();
            groupJoin.GroupJoinMethod();

            All all = new All();
            all.AllMethod();

            Any any = new Any();
            any.AnyMethod();

            Contains contains = new Contains();
            contains.ContainsMethod();










            Console.ReadLine();

        }
    }
}
