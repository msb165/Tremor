using Terraria;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class Light:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Light Spell");
			Description.SetDefault("");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetAttackSpeed(DamageClass.Melee) += 0.03f;
			player.detectCreature = true;
			player.findTreasure = true;
			player.GetDamage(DamageClass.Generic) += 0.03f;
			player.moveSpeed += 0.2f;
			player.GetCritChance(DamageClass.Generic) += 2;
			player.jumpSpeedBoost += 0.2f;
		}
	}
}