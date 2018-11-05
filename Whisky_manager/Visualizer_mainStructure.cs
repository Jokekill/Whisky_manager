using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Whisky_manager
{
    //
    //Visualizer
    //

    

    abstract class Visualizer : IVisualizer
    {
        private IModel model;
        abstract public bool Ukaz(object ojb, TextWriter output);
    }

    class Lahev_vis : Visualizer
    {
        public override bool Ukaz(object ojb, TextWriter output)
        {
            throw new NotImplementedException();
        }
    }

    class UzivlatelStav_vis : Visualizer
    {
        public override bool Ukaz(object ID, TextWriter output)
        {
            throw new NotImplementedException();
        }
    }

    class UzivatelPlatby_vis : Visualizer
    {
        public override bool Ukaz(object ID, TextWriter output)
        {
            throw new NotImplementedException();
        }
    }

}
