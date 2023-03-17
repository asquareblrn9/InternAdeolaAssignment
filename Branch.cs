using AdeolaConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeolaConsoleApp
{
    public class Branch
    {
        public List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }
    }

   

}
// Example usage:
var root = new Branch();
var child1 = new Branch();
var child2 = new Branch();

root.branches.Add(child1);
root.branches.Add(child2);

var grandchild1 = new Branch();
child1.branches.Add(grandchild1);
