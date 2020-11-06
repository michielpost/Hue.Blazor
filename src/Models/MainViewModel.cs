using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hue.Blazor.Models
{
    public class MainViewModel
    {
        public List<GroupViewModel> Groups { get; set; } = new List<GroupViewModel>();
    }

    public class GroupViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<LightViewModel> Lights { get; set; } = new List<LightViewModel>();
    }

    public class LightViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public bool IsOn { get; set; }

        public string Color { get; set; }
    }
}
