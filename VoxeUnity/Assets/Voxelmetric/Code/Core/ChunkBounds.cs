﻿using Voxelmetric.Code.Utilities;

namespace Assets.Voxelmetric.Code.Core
{
    public class ChunkBounds
    {
        public int minX;
        public int maxX;
        public int minY;
        public int maxY;
        public int minZ;
        public int maxZ;
        public int lowestEmptyBlock;

        public ChunkBounds()
        {
            Reset();
        }

        public void Reset()
        {
            minX = minY = minZ = Env.ChunkMask;
            maxX = maxY = maxZ = 0;
            lowestEmptyBlock = Env.ChunkMask;
        }
    }
}
