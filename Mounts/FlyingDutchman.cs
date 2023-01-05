using Terraria;
using Terraria.ModLoader;

namespace Tremor.Mounts
{
	public class FlyingDutchman : ModMount
	{
		public override void SetStaticDefaults()
		{
			MountData.buff = ModContent.BuffType<Buffs.FlyingDutchman>();
			MountData.heightBoost = 10;
			MountData.fallDamage = 0.5f;
			MountData.runSpeed = 5f;
			MountData.dashSpeed = 6f;
			MountData.flightTimeMax = 1200;
			MountData.fatigueMax = 0;
			MountData.jumpHeight = 40;
			MountData.acceleration = 0.19f;
			MountData.jumpSpeed = 6f;
			MountData.totalFrames = 8;
			int[] array = new int[MountData.totalFrames];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 20;
			}
			MountData.playerYOffsets = array;
			MountData.xOffset = 13;
			MountData.bodyFrame = 3;
			MountData.yOffset = -9;
			MountData.playerHeadOffset = 28;
			MountData.standingFrameCount = 8;
			MountData.standingFrameDelay = 6;
			MountData.standingFrameStart = 0;
			MountData.runningFrameCount = 8;
			MountData.runningFrameDelay = 25;
			MountData.runningFrameStart = 0;
			MountData.flyingFrameCount = 8;
			MountData.flyingFrameDelay = 6;
			MountData.flyingFrameStart = 0;
			MountData.inAirFrameCount = 8;
			MountData.inAirFrameDelay = 6;
			MountData.inAirFrameStart = 0;
			MountData.idleFrameCount = 8;
			MountData.idleFrameDelay = 6;
			MountData.idleFrameStart = 0;
			MountData.idleFrameLoop = true;
			MountData.swimFrameCount = MountData.inAirFrameCount;
			MountData.swimFrameDelay = MountData.inAirFrameDelay;
			MountData.swimFrameStart = MountData.inAirFrameStart;
			if (Main.netMode != 2)
			{
				MountData.textureWidth = MountData.backTexture.Width() + 20;
				MountData.textureHeight = MountData.backTexture.Height();
			}
		}
	}
}