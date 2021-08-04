// This code is part of the Fungus library (https://github.com/snozbot/fungus)
// It is released for free under the MIT open source license (https://github.com/snozbot/fungus/blob/master/LICENSE)

/*This script has been, partially or completely, generated by the Fungus.GenerateVariableWindow*/

using UnityEngine;

namespace Fungus
{
    /// <summary>
    /// Collider2D variable type.
    /// </summary>
    [VariableInfo("Other", "Collider2D")]
    [AddComponentMenu("")]
    [System.Serializable]
    public class Collider2DVariable : VariableBase<UnityEngine.Collider2D>
    { }

    /// <summary>
    /// Container for a Collider2D variable reference or constant value.
    /// </summary>
    [System.Serializable]
    public struct Collider2DData
    {
        [SerializeField]
        [VariableProperty("<Value>", typeof(Collider2DVariable))]
        public Collider2DVariable collider2DRef;

        [SerializeField]
        public UnityEngine.Collider2D collider2DVal;

        public static implicit operator UnityEngine.Collider2D(Collider2DData Collider2DData)
        {
            return Collider2DData.Value;
        }

        public Collider2DData(UnityEngine.Collider2D v)
        {
            collider2DVal = v;
            collider2DRef = null;
        }

        public UnityEngine.Collider2D Value
        {
            get { return (collider2DRef == null) ? collider2DVal : collider2DRef.Value; }
            set { if (collider2DRef == null) { collider2DVal = value; } else { collider2DRef.Value = value; } }
        }

        public string GetDescription()
        {
            if (collider2DRef == null)
            {
                return collider2DVal != null ? collider2DVal.ToString() : "Null";
            }
            else
            {
                return collider2DRef.Key;
            }
        }
    }
}