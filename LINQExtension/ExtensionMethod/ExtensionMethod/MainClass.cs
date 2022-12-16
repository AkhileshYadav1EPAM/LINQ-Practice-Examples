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

            Aggregate aggregate = new Aggregate();
            aggregate.AggregateMethod();

            Average average = new Average();
            average.AverageMethod();

            Count count= new Count();
            count.CountMethod();

            Max max = new Max();
            max.MaxMethod();

            Sum sum = new Sum();
            sum.SumMethod();

            ElementAt elementAt = new ElementAt();
            elementAt.ElementAtMethod();

            ElementAtOrDefault elementAtOrDefault = new ElementAtOrDefault();
            elementAtOrDefault.ElementAtOrDefaultMethod();

            First first = new First();
            first.FirstMethod();

            FirstOrDefault firstOrDefault= new FirstOrDefault();
            firstOrDefault.FirstOrDefaultMethod();

            Last last = new Last();
            last.LastMethod();

            LastOrDefault lastOrDefault = new LastOrDefault();
            lastOrDefault.LastOrDefaultMethod();

            SingleOperator singleOperator = new SingleOperator();
            singleOperator.SingleMethod();

            SingleOrDefault singleOrDefault = new SingleOrDefault();
            singleOrDefault.SingleOrDefaultMethod();

            Skip skip = new Skip();
            skip.SkipMethod();

            SkipWhile skipWhile = new SkipWhile();
            skipWhile.SkipWhileMethod();

            Take take = new Take();
            take.TakeMethod();

            TakeWhile takeWhile = new TakeWhile();
            takeWhile.TakeWhileMethod();


            Console.ReadLine();

        }
    }
}
