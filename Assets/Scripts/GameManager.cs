﻿// Created by h1ddengames
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using SFB;
using NaughtyAttributes;
using RotaryHeart.Lib.SerializableDictionary;

namespace h1ddengames {
	public class GameManager : Singleton<GameManager> {
		#region Exposed Fields
		[SerializeField] private string gameVersion;
		[SerializeField] private GameObject player;
		[SerializeField] private CharacterController2D playerCharacterController2D;
		[SerializeField] private SpriteRenderer playerSpriteRenderer;
		[SerializeField] private BoxCollider2D playerboxCollider2D;
		#endregion

		#region Private Fields
		#endregion

		#region Getters/Setters
		public string GameVersion { get => gameVersion; set => gameVersion = value; }
		public GameObject Player { get => player; set => player = value; }
		public CharacterController2D PlayerCharacterController2D { get => playerCharacterController2D; set => playerCharacterController2D = value; }
		public SpriteRenderer PlayerSpriteRenderer { get => playerSpriteRenderer; set => playerSpriteRenderer = value; }
		public BoxCollider2D PlayerboxCollider2D { get => playerboxCollider2D; set => playerboxCollider2D = value; }
		#endregion

		#region My Methods
		#endregion

		#region Unity Methods
		void OnEnable() {
			
		}
		
		void Start() {
			
		}

		void Update() {

		}
		
		void OnDisable() {
			
		}
		#endregion

		#region Helper Methods
		#endregion
	}
}