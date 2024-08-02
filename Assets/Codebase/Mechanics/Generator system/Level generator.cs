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
        }
        private void OnDestroy()
        {
            Character.GenerateNewPartEvent -= Generate;
        }

        public void Generate(Transform generate_position)
        {
            GameObject part = _levelParts[Random.Range(0, _levelParts.Length)];
            Debug.Log($"{part.name} is generated");
            Instantiate(part, new Vector3(part.transform.position.x+generate_position.position.x,0,0) ,Quaternion.identity);
        }
    }
}
    