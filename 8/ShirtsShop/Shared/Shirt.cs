using System;
using System.Collections.Generic;
using System.Text;

namespace ShirtsShop.Shared
{
    public class Shirt
    {

        public int Id { get; set; } = 0;

        public string Color { get; set; }

        public string Text { get; set; }

        public Size Size { get; set; }

        public int SizeId { get; set; }
    }
}