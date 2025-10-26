using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class BottledSoulOfFright:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			// DisplayName.SetDefault("Bottled Soul of Fright");
			// Description.SetDefault("Increases critical strike chance by 2");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetCritChance(DamageClass.Generic) += 2;
		}
	}
}
