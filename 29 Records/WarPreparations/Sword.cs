using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarPreparations
{
    /* Create a Sword record with a meterial, gemstone, length, and crossguard width */
    public record Sword
    {
        public MaterialType Material { get; init; }
        public GemType Gemstone { get; init; }
        public int Length { get; init; }
        public int Crossguard { get; init; }

        public Sword(MaterialType material, GemType gemstone, int length, int crossguard)
        {
            Material = material;
            Gemstone = gemstone;
            Length = length;
            Crossguard = crossguard;
        }
    }
}
