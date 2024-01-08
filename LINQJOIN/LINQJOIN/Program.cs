using System;
using System.Collections.Generic;
using System.Linq;
using LINQJOIN.JOIN;
using LINQJOIN.Model;

namespace LINQJOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            // innerJoin = new LeftJoin();
            //innerJoin.LeftJoinInNormal();

            // LeftJoin leftJoin = new LeftJoin();
            //leftJoin.LeftJoinInNormal();
            //leftJoin.RightJoinInNormal();
            //var GroupByMS = Student.GetStudents().GroupBy(s => s.Barnch);
            //  foreach( var grp in GroupByMS)
            {
                //iterate throuh the branch
                // Console.WriteLine(grp.Key);
                //iterate through student
                // foreach ( var std in grp)
                //{
                // Console.WriteLine(std.Name + std.Age + std.Barnch);
                //}
                //}

                CastAndTypeof cast = new CastAndTypeof();
                var list = cast.getArray();
                IEnumerable<int> result = list.Cast<int>();
                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }
                IEnumerable<object> dataSource = cast.GetlistObject();
                var source = dataSource.OfType<string>().ToList();
                foreach (var i in source)
                {
                    Console.WriteLine(i);
                }

            }

        }

    }
}


  


