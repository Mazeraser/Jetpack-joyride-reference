using Assets.Codebase.Infrastructure;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.GeneratorSystem
{
    public class Levelgenerator : MonoBehaviour,IGenerator
    {
        [SerializeField]
        private GameObject[] _levelParts;

        private void Start()
        {
            Character.GenerateNewPartEvent += Generate;

            Generate(transform);
        }

        public void Generate(Transform generate_position)
        {
            Instantiate(_levelParts[Random.Range(0,_levelParts.Length)], generate_position.position ,Quaternion.identity);
        }
    }
}
    