using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRat
{
    public class Exercise
    {
        public int Id;
        public string Name;
        public Video Video;
        public string Description;
        public List<BodyPart> Parts;
        public Sport Sport;
    }
}
