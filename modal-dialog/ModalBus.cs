using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modal_dialog {
    public class ModalBus {
        public Boolean HasOutline { get; set; } = true;
        public Boolean HasShadow { get; set; } = false;
        public Boolean HasGradient { get; set; } = false;
        public Color Color { get; set; } = Color.Red;
        public String Name { get; set; } = "No name";
    }

    public enum Color {
        Red,
        Blue,
        Green
    }
}
