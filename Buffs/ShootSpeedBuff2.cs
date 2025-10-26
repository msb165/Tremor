using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ShootSpeedBuff2:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paratrooper's Lens");
			// Description.SetDefault("Increased projectile's speed twice");
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}
