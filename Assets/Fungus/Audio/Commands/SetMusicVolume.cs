﻿using UnityEngine;
using System.Collections;

namespace Fungus.Script
{
	[CommandInfo("Audio",
	             "Set Music Volume",
	             "Sets the game music volume level.", 
	             1,1,1)]
	public class SetMusicVolume : FungusCommand
	{
		[Range(0,1)]
		public float volume = 1;

		[Range(0,30)]
		public float fadeDuration; 

		public override void OnEnter()
		{
			MusicController musicController = MusicController.GetInstance();
			if (musicController != null)
			{
				musicController.SetMusicVolume(volume, fadeDuration);
			}

			Continue();
		}

		public override string GetSummary()
		{
			return "Set to " + volume + " over " + fadeDuration + " seconds.";
		}
	}

}