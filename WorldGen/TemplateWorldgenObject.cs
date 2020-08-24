using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace Aerothyte {
    public partial class AerothyteWorld {
        //
        internal bool MakeTemplateWGen(int i, int j) {
            if (Main.tile[i, j].active())
                return false;
            int[,] templateShape = {
            { 0, 1, 1, 0 },
            { 1, 0, 0, 0 },
            { 0, 1, 1, 0 },
            { 1, 0, 0, 1 },
        };
            for (int y = 0; y < templateShape.GetLength(1); y++) {
                for (int x = 0; x < templateShape.GetLength(0); x++) {

                    Tile tile = Framing.GetTileSafely(i, j);
                    switch (templateShape[y, x]) {
                        case 1:
                            tile.type = TileID.SlimeBlock;
                            break;
                        case 0:
                            tile.ClearTile();
                            break;
                    }
                }
            }
            return true;
        }
    }
}